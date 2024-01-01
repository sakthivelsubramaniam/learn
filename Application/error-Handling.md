# Error-Handling

## Consideration

1. How the exception should be logged without any any redudant information. 
When an exception is thrown from 
    [funcA] - [funcB] - [funcC]
2. Mutiple Microservice will be involved.
    [SPAApp] -> MS-A ->MS-B -> MS-C
3. MS should follow Rest Priciple,Http Status should be correctly mapped.
4. User with sufficient priveledge should see the list of logs.


## Terms

## Scenarios

### When app flows is as follows

```plantuml

@startuml

rectangle MicroServiceA as A
rectangle MicroServiceB as B
rectangle MicroServiceC as C

A->B 
B->C

@enduml
```

<br/>
<br/>

1. When the  App Exception is thrown at MicroserviceC in Business Layer.
App Exception should be captured at  Error Handling Middleware
2. Error Handler will map the Exception to the Http Status code and embedding the errors with the Http Body using open Standard and returns the http error response.
3. When MicroserviceB, AppHttpClient see's the http error code, it propagates the error to the caller MS, If any.
4. One way to handle is to embed these kinds of error in an custom exception and rethrow it. Business Layer may choose to handle the error or defer it to error handling middleware.
5. Logging: Source component will be logging all the details, Callers should log only minimum error message, just saying Type of the error, name of the Microservice and Component from which the error originated. 
6. Each Microservice may maintain the range of error code and error messages to facilitate Support team.
