# Long running Process
l Can be address if the application provide, framework for creating the Job  .
2 Having the async call that returns a token, It initiate the background process to complete the jobs.

## Exampls
1.	ETL/ELT jobs.
2.  Salary Calculations
3.  Inventory evaluations
4.  Project Creations or Creation of complex objects.
5.  Specific reports generations.

## Async call that returns immidiatly
### Consideration
 
1.	After initiates the long running process,user should be able to work on other functionality that is not dependent on long running process feature.  
2.	When User A initiates the long running process P1 ,whether another User B can initiate same long running Process P1 may depend on scenarios of the application.   

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
