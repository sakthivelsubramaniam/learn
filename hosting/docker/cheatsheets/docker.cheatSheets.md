| Command  | Description |
| ------------- | ------------- |
|**docker service**||
||`net start com.docker.service`| start the docker service |
|**docker**||
|  `docker `  | List the Cli command|
|  `docker --version `  | Displays version|
|  `docker --Info `  | Displays version|
|  `docker inspect`  | Displays the environment variable.|  
|**Images**||
| `Docker pull` {imageName} | pulls the image 
| `Docker build --tag={tagname} ` | builds the image with tag name |
| `docker image ls`| list the docker images|
| `Docker rmi {image name}` | Removes the image name  from the image id|
|**Images - tag**||
| `docker tag d583c3ac45fd {new image name}:{tag name}`  | Associates  new image name (displayed under column repository) to the image id   |
| **Docker Container** ||
| `Docker container ls `| List the docker container that are active|
| `Docker container ls --all `| List the docker container that are active as well as inactive |
| `Docker container ls --aq `| List the docker container that are active as well as inactive |
| `Docker run [image-name] `|executes the docker image|
| `Docker run  -d `|Run docker in detach mode|
| `Docker run  -p 4000:80 username/repository:tag` | Pull and run the image from the repository host port is 4000 
| `Docker run -p [host port]:[docker port]` | host port occurs first and then docker port
and docker port is 80|
| `Docker ps ` |  0.0.0.0:49155->5000/tcp  means host 49155 is mapped to containers' 50000  
| `Docker logs -f  <containerId>` | When in detach mode, Attach the log output to std output  
| **Docker Compose** ||
| `docker-compose up` | start and run entire docker up|
| `docker-compose down` | stop the containers|
| `docker-compose build` | rebuilds the image|
| **Docker Repository** ||
| `docker tag [image] [username]/[repository]:[tag]` |tags the image with repositoryName and tag name |
| `docker login` | login the repository hub |
| `push username/repository:tag` | Pushes the image with the tag to the repository |
**Docker Swarm** |
`docker swarm init` | initialize the node as swarm manager
`docker swarm join` | running this command on the worker makes the work join the swarm manager

 





 

