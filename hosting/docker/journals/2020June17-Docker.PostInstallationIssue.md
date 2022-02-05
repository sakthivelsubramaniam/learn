Docker client was very slow
Recommendation from internet
    1. Issue related with network.
    2. Disable the IP 6. 
    3. issue Ipconfig /flush to flush dsn cache.

Docker cli is connecting to the host based on environment variable

```markdown
#override the host by
 Docker -H 172.24.96.1:2376

#Found it is working relatively fast 
# reset environment variable by 

 $env:DOCKER_HOST= "tcp://172.24.96.1:2376"
```
