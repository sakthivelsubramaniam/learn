# webapi

This is a simple webapi.
ref valuecontroller 


# Execute following powershell commnd

```Powershell
docker build -t mywebapi .
docker run -d -p 5001:80 --name myapp mywebapi
docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" myapp

```
