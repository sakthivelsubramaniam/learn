
kubectl
=======

| Command  | Description |
| ------------- | ------------- |
| kubectl action resource||
| `Kubectl   help ` | | 
| `Kubectl  version`| Displays the version |
| `Kubectl  cluster-info` | displays the information about the cluster |
| `Kubectl  cluster-info dump --output-directory=[path]` |dumps the cluster info to the specified directory |
|`Kubectl  get deployments`|configured the cluster to reschedule the instance on a new Node|
|`kubectl run deployname1 --image=gcr.io/google-samples/kubernetes-bootcamp:v1 --port=8080`| Deploy the app to the kubernetes. searched for a suitable node where an instance of the application could be run Schedules the application  configured the cluster to reschedule the instance on a new Node|
| `Kubectl  get nodes` | gets the list of nodes |
| `Kubectl  get pods --show-labels ` | gets the list of pods |
| `Kubectl  get pods` | gets the list of pods |
| `Kubectl  get pods -l [labelName]` | gets the list of pods that taged with the labels |
| `Kubectl  describe pods` | gets the container in the pods |
| `Kubectl  label pod [pod_name] [label] `||
| `Kubectl  get services` | gets the lists of service in the cluster |
| `Kubectl  get services -l  [label name]` | gets the lists of service in the cluster with the label |
| `Kubectl  delete services -l  [label name]` | deletes the service with label name |
| `Kubectl  logs [podname]` | gets the log in the container, container name is not specified since there is one container |
| `Kubectl  logs [podname]` | gets the log in the container, container name is not specified since there is one container |
| `Kubectl  exec [podname]` | executes the command inside the container |
| `Kubectl  exec -ti [podname] bash` | creates a bash session in the container |
| `cat server.js` | execution from the container |

## kubectl expose it to outside world

| Command  | Description |
| ------------- | ------------- |
| `kubectl expose deployment/kubernetes-bootcamp --type="NodePort" --port 8080`| creates a new services and expose it to outside|
|`kubectl describe deployment`| describe the deployments|
|`kubectl describe deployment`| describe the deployments|

## kubectl Running multiple Instances of the application

| Command  | Description |
| ------------- | ------------- |
|`kubectl scale deployments/kubernetes-bootcamp --replicas=4`| scale the replicas |
|`kubectl pods -o wide `| number of pods changes|




## proxy endpoint

| Command  | Description |
| ------------- | ------------- |
|`curl http://localhost:8001/version`| displays the versions |
|`curl http://localhost:8001/api/v1/namespaces/default/pods/deployname1-6754775fd6-zl886/proxy/`| Query the applicaiton inside the pods|

