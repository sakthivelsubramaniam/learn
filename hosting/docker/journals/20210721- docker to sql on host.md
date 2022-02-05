
* can use host.docker.internal as server name to connect to sql server
* sql server 
    - ensure tcp is enabled 
    - ensure to accepts remote connections.

## acceptes remote connection
    OPen SQL Server Management Studio
    Properties -> Connection -> Allow Remote Connections

 
 ## Enable tcp 
    Open SQL Server Configuration Manager
    Enable TCP/IP in Server Network Configuration
    Restart SQL Service Service

## commands used 

``` docker
  docker rmi asp-perf-mick-rousos-combine-demo -f 
  docker build . -f CombinedDemo\Dockerfile -t asp-perf-mick-rousos-combine-demo
  docker run asp-perf-mick-rousos-combine-demo -d -p 8080:80

  docker exec 4dcfade34ed8 curl http://localhost:8080/api/test/test1

``` 