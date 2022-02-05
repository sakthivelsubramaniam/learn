| Command  | Description |
| ------------- | ------------- |
| **user define network** ||
| `docker network create my-net` | create a user define network with default network type |
| `docker network create --driver bridge my_isolated_bridge_network` | create a user define network with default network type
| `docker network rm my-net` | removes the user define network if containers are not connected to the network|
| `docker network disconnect my-net my-nginx` | connects the running container to running network|
| `docker network connect my-net my-nginx` | connects the running container to running network|
| `docker network ls` | list the network |
| `docker network inspect` | gives the details of the network|
| `docker run {image name} --net={network name} | runs the docker within the network |
| 