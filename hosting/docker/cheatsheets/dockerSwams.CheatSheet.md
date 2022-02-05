 
 #initialize swarm
 `docker-machine ssh myvm1 "docker swarm init --advertise-addr 192.168.43.222"`
 
 #initialize join
 `docker swarm join --token SWMTKN-1-11oy90nzm2255ka9guurfts8a1un8j5989du9j8sxwywxpsrgr-antfe78exerrxqknzz7dut3j0 192.168.43.222:2377`

`docker swarm join-token worker` | displays the join token for worker
`docker swarm join-token manager` | displays the join token for manager

`eval $(docker-machine env myvm1)` | configures the shell to talk to docker in the vm in linux
`docker-machine env myvm1 | invoke-Expression` |  configures the shell to talk to docker in the vm in windows

 docker-machine regenerate-certs myvm1