Re-installed docker 
 - it took less space, space reduced from 30 gb to 5 gb

remapping image store from c to d
 - stop the docker service
 - remove the docker storage directory
 - create a new directory
 - use bind mount to set new location
 - restart the docker service

 https://levelup.gitconnected.com/docker-desktop-on-wsl2-the-problem-with-mixing-file-systems-a8b5dcd79b22

 https://docs.microsoft.com/en-us/windows/wsl/faq

 https://devblogs.microsoft.com/commandline/access-linux-filesystems-in-windows-and-wsl-2/

 https://dev.to/kimcuonthenet/move-docker-desktop-data-distro-out-of-system-drive-4cg2 

``` batch
wsl --shutdown
wsl --list --verbose

 wsl --export docker-desktop-data "D:\programdata\docker\docker-desktop-data.tar"
 
 wsl --unregister docker-desktop-data

 wsl --import docker-desktop-data "d:\programdata\docker" "D:\programdata\docker\docker-desktop-data.tar" --version 2

```
start the distro by nav via windows terminal
start the docker desktop
docker and kubectl should work
