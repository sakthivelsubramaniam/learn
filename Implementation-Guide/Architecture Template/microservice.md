# Microservices

## Software components

### Pass Service components

* Azure AD ( similar identity management service)
* Email/SMS Notification service
* Log and Telemetry aggregation (App insights)
* Caching (redis cache)

### Packages  

* Authentication and Authorization
* Telemetry
* Error Handling
* configuration  consumptions

### Platform Services

* Workflow Orchestrator - To Execute complex long running business logic in a resilient and fault tolerant manner.
* Data Exchange - Rest Api service to exchange the data between external system.
* Job Orchestrator - To Execute and track ETL/ELT jobs.Jobs will be run on Spark/Hadoop clusters or similar job engines.
* Notification engine - Send notification to client, Send notification via SMS/Email.

### Other Concerns

* Api Versioning
