# Long running Process

## Example

1. ETL/ELT jobs.
2. Salary Calculations
3. Inventory evaluations
4. Project Creations or Creation of complex objects.
5. Specific reports generations.
6. Decision engine.

### Consideration

1. After initiates the long running process,user should be able to work on other functionality that is not dependent on long running process feature.  
2. When User A initiates the long running process P1 ,whether another User B can initiate same long running Process P1 may depend on scenarios of the application.
3. Since it is Asynchronous process, if user wants to executes some work after the job completes, user need to save the context/state and should be able to retrieve it. Async system should provide a way to pass these state information and when it completes we will get back the state. Or Some identifier is required to pass around.
4. Should support distributive tracing.
5. Should pass user access token.


## Interface

It should have following features

1. Invoke.
2. GetStatus
3. Code to Execute when complete.

### By Polling

a. Having the async call that returns a token, 
b. It initiate the background process to complete the jobs.
c. Caller can poll the status with the token and Can retrieve the result when it completes.

### Notification

- Have an api that can take the web hook, Long running process can send the notification with the webhook.

## Async call that returns immediately

### Design  

```
 table Job ( jobId, name, timeout)
 table JobIntance (JobInstanceId, jobId, statetime,lastupdatedtime, status )
 table jobIntanceLog (JobInstanceId,logid, datetime, message )
 
 Getlogs(JobInstanceId)
 GetStatus(JobInstanceId): (completed| jobInstance/ JobInstanceLog List)
  - if the currTime - lastupdatedtime is greater than timeout then update the status as completed with timeout and show the completed status
 Cancel(JobInstanceId, time)
 LogMessage(JobInstanceId,time, message) 
 CreateJobInstance(JobId, time)


```
