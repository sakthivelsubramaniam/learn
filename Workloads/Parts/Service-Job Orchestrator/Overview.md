# Job/Service Orchestrator

## Terms

### Job Request.

 A request to process a Job that contains sequence of  steps Action. It contains  parameters to identify the job that need to be executed

### Job Template 
Templates that defines the sequence of Actions that has to be executed. 
 It contains
-Job Priority
-Successors
-Predecessors

### Actions
 An instance of Job Template Item

### Job Store
  Request Table : To store the request received from the Job Queue.
  Action Table : To store the Actions define by the Job Orchestor.

### Job Queue
  A Queue that receives the Job Request, Subscribed by job orchestrator.

### Job Orchestor
- Listen for the message in Job Queue. 
- Identifies the Job Template based on the JobId from the Request
- Creates the Actions based on the Job defined in the Template and Inserts the Record in the DB.
- Action Record contains Successors, Predecessors, Action Id, Parameters from the Request that a Action Needs

### Job Scheduler.
 A Cron Job that runs in the configured time interval. Reads the Action Items that have the all predecessor in complete state  from the Action Table. Schedules the Action based on Priority.
- Scheduling is done by having a Action Queue. 
- Scheduler sends a message in a queue to Trigger the Executor.
- The Azure Function Executes identities the Class that corresponds the Action Id and executes the same.

 ### Action Executor 
- Identifies the input parameters
- If the input parameter is output parameters of other Actions, finds the same from tables.
- If the input parameter is Request, It fills the request the from the table.
- Executes the Action.