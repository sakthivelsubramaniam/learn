## Hosting Decision
  

## Tech Stack

 1. Hosted on premises or VM (should be used only for legacy application)
 2. Containers 
 3. ServiceLess
 4. App service 
 5. App Service Plan
 6. Azure Functions 
 7. Azure Durable functions
 8. Web Jobs

  Orchestrating the container.
      - AKS
      - Manual Configured Kubernetes.
      - docker swamp.
   
# Decision on serverless vs Containers
 
 ## ServerLess
   1. Scale:the backend inherently and automatically scales to meet demand.
   2. There is un predictable nature. When multiple instance of the compute is spined off, it may affect service/ resource that it consumes. For instance when the serverless consumes a database, database will become a bottle neck.
   3. Maintainability, Serverless leads too many small Independent service, that it becomes difficult to manage when very many functionalities are added.
   4. Infra maintainance: Provides takes care of infra maintenance. Vendor take's care of the server software updates and security patchtes updates. 
   4. Insome cases, it may lead to vendor lock-in.
   5. Cost: There is no coninues cost because the application does not always runs.
        - Cost can be saved if the application does not see consistent traffic and usage. 
   7. Cost may go out of hand if you the application is used always.
   6. testing: it is hard to replicate the testing environment locally
   8. Release and iterate quickly without worrying about how to scale the application.
  
  ## Type of Work loads that fits the Azure functions
      - Threshold alerts coming from stream Analytics
      - Order processing with Service Bus
      - Custom Processing steps using Logic App.
      - processing that have low and variable scale
      - Infrequent task such as DB clean up.
      - API for something like Concert/Conferance which will run hot during the event and cold otherwise.
      - IOT Processing where usage is high during some part of the hour and cold otherwise.
  ## not good fit.
      - When state is involved.
      - Langauge contstraint
      - Stateful stream processing
      -  
 
 ## container.
  1. the number of containers deployed is determined by the developer in advance. 
  2. Containers gives more controls to the devs, so it good fit for moving legacy application to the container.
  3. Cost: There is pertictable and fixed cost of running the service.
  4. Infra Maintenance:  Developers have to take care of software and patch updates.
  5. Time of deployment: initial setup time for container is longer and after this it becomes easier to deploy.
  6. testing. Same image can be deployed locally and can be tested.
  7. If the usage is consistent then the containers can be good fit. 
