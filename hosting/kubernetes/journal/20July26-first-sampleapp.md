Endpoints where not created in the service, possible issues were 
metadata not defined in pod and service creation does not use meta data

```
apiVersion: v1
kind: Pod
metadata:
    name: weather-backend-pod1
    labels: 
        name: weather-backend-pod1
spec:
    containers:
    -  name: weather-backend-server 
       image: weather-backend:v1
       ports:
       - containerPort: 80    

kubectl apply -f weatherbackendPods.yml

apiVersion: v1
kind: Service
metadata:
    name: weather-backend-service
spec:
    selector:
        name :  weather-backend1
    ports: 
    - port: 80
      targetPort: 80
```
now checking the service, displays the endpoint

To diplay result from backend-pod1
```cmd
kubectl exec weather-backend-pod1 curl http://localhost/api/weatherforecast
```

to display result from frontend-pod1
```cmd
kubectl exec weather-frontend-pod1 curl http://weather-backend-service/api/weatherforecast
```

