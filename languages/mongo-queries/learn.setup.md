# Mongo Docker Setup

``` batch
docker pull mongo:latest
docker run -d -p 27017:27017 --name=mongo-example mongo:latest
docker ps 
docker exec -it mongo-example mongo


```
