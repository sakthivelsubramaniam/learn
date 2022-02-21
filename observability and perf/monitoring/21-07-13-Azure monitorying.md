
## Overview
 - It is tool to collect, monitor and act on Application metrics, logs and events
 - It consist of Application Insight, Azure Monitor, Log Analytics and alerts
 - Single Metric database for each subscription.
 - Can create multiple Log Analytical workspace.
 - 

## Log Analytical workspace
    - Workspace is essentially conainter where data log is collected from variety of sources.
## Viewing the Data
  - solution and insight - set of logic applied to view log data
  - log queries using Kusto Query Language
  - metric analysis.
  - 
## Data Expolorer
  - fast and scalable data explorationservice for log and telemetric data.

## Azure 
    Build on top of data explorer, uses same kusto language

## Azure Portal
### Activity log
    - operation on each azure resources 
### view metric
    - Metrics are numerical values that describe some aspect of your resource at a particular time.
    - Azure Monitor collects metric about Platform resource at 1 min intervals
    
### Log Analytics
    - create log Analytics workspace
    - for viewing activity log in log analytics
        - go to Azure monitor/Activity Log/ diagnostic setting
        - give diagnostic setting name and select log analytic workspace.
        - in destination details, send to log analytics
        - Log query, Azure Monitor/log ,select the scope and select workspace
            - In the Query type Azure Activity and Run the query to see the logs

### log data structure
    - It has Properties as Key/Value pairs
    - It has Category

## monitor azure resources

## monitor azure application
   - asp.net application : 
       - https://docs.microsoft.com/en-us/azure/azure-monitor/app/dotnet-quickstart
       - dotnet add package Microsoft.ApplicationInsights.AspNetCore --version 2.17.0 
       - add instrumentation key in configuration
       - configure server side,  services.AddApplicationInsightsTelemetry();
       - 
             
## App insight
    - app insight initializer, 
    
```
          public class CustomPropertyTelemetryInitializer : ITelemetryInitializer
        {
            public void Initialize(ITelemetry telemetry)
            {
                telemetry.Properties["MyCustomProperty"] = "Some Useful Value";
                telemetry.CloudRole = "cloud role"
            }
        } 
```

    - Request Telemetry
        -  it is Telemetry that App Insight sdk collects by default about the http request

```cs
public void ConfigureServices(IServiceCollection services)
{
services.AddControllers();
services.AddApplicationInsightsTelemetry();
}

ar requestTelemetry = HttpContext.Features.Get<RequestTelemetry>();
requestTelemetry.Properties["TenantId"] = "ACME_CORP";

```
