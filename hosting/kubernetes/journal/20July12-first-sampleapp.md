precondition : docker image is created and it is in the local docker image registry.

create a manifest file as below
```
apiVersion: v1
kind: Pod
metadata:
    name: weather-backend-pod1
spec:
    containers:
    -  name: weather-backend-server 
       image: weather-backend:v1
       ports:
       - containerPort: 80    

kubectl create -f weatherbackendPods.yml
```

validate the pods creation 

```
kubectl get pods
kubectl get pods/weather-backend-pod1
kubectl describe pods/weather-backend-pod1
````
create a service based on manifest file 

```
apiVersion: v1
kind: Service
metadata:
    name: weather-backend-service
spec:
    selector:
        application :  weather-backend-pod1
    ports: 
    - port: 5001
      targetPort: 80
```
```
kubectl apply -f weatherbackendservice.yml
```
Validate the service creation

```
kubectl get services
kubectl describe services/weather-backend-service
```




