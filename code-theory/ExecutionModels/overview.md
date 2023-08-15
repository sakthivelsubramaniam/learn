# Execution Models

* Continuously running Service.(Hosted Service)
* Timer Triggered Services (Scheduler service).
* API-example web api.
* Event Triggered Services.

## Hosted Computation

There are three distinct steps.

* Startup
* Execute
* Stopping

### Design Consideration

* Generally initialization happens during startup stage. Initialization can db initialization or some external initialization,In those cases the startup should time limited. There should explicit time out.
* When the service is stopped externally, there should be graceful shutdown process.
