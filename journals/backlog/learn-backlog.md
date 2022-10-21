
# Topic of interest
###  Language 
	- langague features
	- functional programming
	- oops
	- powershell
	- csharp
	- fsharp
	- typescript 
	- haskell
    - funcational javascript libs
    - Scala
    - Python
	- Ui/Html 5

### dev and devops tools
	- git
	- dotnet cli
    - code-project:tyre
	- Nuget tools
	- linux network tools
   	- code metrics: Sonar cubes and lints
  	- perf|loadtesting: nBombard
	- tyre
	- dapper


### conceptual
	- Doc Arch: Approach documents
    - Doc Arch: Architecturally significant requirement.
	- UI framworks blazor, angular, react, aspt.net
	- hosting: container
	- hosting: kubernetis
	- hosting: networing tools 
	- hosting: linux
	- hosting: windows
    - hosting: Issues in hosting the applications
	- Azure
		- computes
		- Azure Gateways
			-WAF
			-API Gateways
	- data: Designing NoSQL 
	- data: kinds of big data workloads
	- data: Big data processing
	- data transfer: file format, lib to read file formats
	- ETL/ELT: Delta lake architecture
	- Integration issues
	- Perf: Performane enginerring
	- perf: Benchmark-lib 
	- Security: Iot security considerations
	- security: desiging and configuring  microservice
	- Networks: dsn, ssh, remote connecting networks
	- Observability
	- Search


# Resources

## Data Resource
- [Big table original article.](file:///D:/Documents/Study%20Materials/Data/WideColumnStore/bigtable-osdi06.pdf)
- [] ()

## fsharp
[F# docs](https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2010/hh314518(v=vs.100)?redirectedfrom=MSDN)  
[F# Tutorial](https://www.pluralsight.com/blog/software-development/tutorial-f-sharp)  
[F# Samples]( https://archive.codeplex.com/?p=fsharpsamples)  

### list of project  
https://github.com/fsprojects/awesome-fsharp  
https://fsharp.org/learn/  
https://fsharp.org/community/projects/  

 you tube to complete  
https://www.youtube.com/watch?v=JeK979aqqqc  
https://ffconsultancy.com/products/fsharp_journal/index.html?se  

## Observability

https://docs.microsoft.com/en-us/azure/azure-monitor/app/correlation  
https://docs.microsoft.com/en-us/azure/azure-monitor/app/auto-collect-dependencies  
https://medium.com/prospa-engineering/implementing-distributed-tracing-with-azures-application-insights-5a09cc1c200c  
https://brettmckenzie.net/2019/10/02/things-i-wish-i-knew-earlier-about-distributed-tracing-in-azure-application-insights/  


# Explore 

## Architecture, principle and patterns
1.  microservices design anti patterns 
2.  microservice reactive  


## Server
	web app cross cutting concert - dotnet core samplei
        - Authentication/authorization for webapi/webapp
        - open-API/swagger
        - configuration
        - dependecy-understand scope
        - logging and traceing
            - Request/Response logging ref implementation.ś
        - distributed tracing 
        - enbling cors
        - routing
        - Endpoint routing
     * helper for httpclient 
        - typed httpclient to call other microservice
     * transaction
     *  Retry and circuit breaker
     * start up
    

## Integration 
1. principle and best practices
1. list of considerations

### Enterprise Integration. 
 0. Enterprise Integration - resouces

### Messaging
1.  Features needed
1.	Expore - Azure Service Bus
1.	Expore - Azure Queues 

### Events Streaming
1. Features needed
1. Event Hub - explore
1. IOT Hub - exlore
1. mass transit library 
1. Kafta

### Web Protocal 
1. Http
2. gpc 
3. Web Socket
4. Signal R
5. Socket IO

### messaging protocol
1. AMQP

## Code
### algorithmn
1.  distributed - Byzantine General Problems - understanding and algorithmn
2.  circuit breaker - approach and alorithmn.

### functional progromming 
1. Revise computational Expression
1. Monands - using bind operator
2. catamorphisim and folds
1. reactive programming

### language and dotnet bcl
 1. C#
	- task parallel library 
	- span
    - records
	- Explore language new features after C# 8
 1. F# 
 	- supports data providers and LINQ


 1. dotnet 
 	- Aspnet:pipeline/ routing

 1. Client
 	- fp-js: Rambda
	- typeScript: 
		  revise: Type script run the tutorials
		  revise: control and loop structures
		  revise: aync and await
		  revise: namespace and modules and files
	- Anglular
		- Unit testing

 1. dotnet libs: Boilerplate 


## Hosting
## container and kubernetes
1.	docker perf image.
2.	custom objects

 interation between docker and windows

### Os-Linux
   - user management
   - directory -
   - service - example web serviers
   - connectivity - ssh
### Network
	what is swap ?
	iptables  and route tables, understand the command.
	sofware process responsible for internet and trasport in windows and linux
	vlan
	diff between vlan and vnet
	linux  networks- iptable

## Devops
### editor 
1. vim - config 
2. practise vim register  
3. vs/vscode/vim - vssplit and hsplit
4. vim tabs
5. vim/vs/vscode - block operation



## Data 
 - synapses
 - parquet and similar format  
 - Diff between inmemory vs persistent db
 - azur:mount the file from windows
 - cosmosdb - manage dtu
		- cosmosdb caching
		- changeset events
- Dax:Explore Dax function - keep filters
- datafactory
- Etl:delta architecture

## Observability
What are the pre-request for dependency telemetry ?
 - understand how http request is logged.

### Tools 
 Azure : AppInsights - query language.

exercises
 create server A
 Create server b
 call A -> B
 log http log to A
 log out-going request

 

## Perf
1.	ytube on db connection -- have sample application


## Security
### iot security
1. how iot devices are identified.


