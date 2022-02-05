need to try
ssh -p <myCustomPort> <myWindowsIPstartingWith192.168..>

Windows 10 considers localhost as ::1 Ubuntu considers localhost as 127.0.0.1
 C:\Users<your_username>.wslconfig

``` config
    [wsl2]
    localhostForwarding=true
```

to know the ip address in linux
 ip a

So, in order to access the server from your local devices, you need to port forward the WSL local IP using netsh.

install the network tools
sudo apt install net-tools

## https://dev.to/vishnumohanrk/wsl-port-forwarding-2e22

## netsh interface portproxy show v4tov4

https://abdus.dev/posts/fixing-wsl2-localhost-access-issue/
https://superuser.com/questions/1535269/how-to-connect-wsl-to-a-windows-localhost
https://github.com/microsoft/WSL/issues/4554
https://stackoverflow.com/questions/64763147/access-a-localhost-running-in-windows-from-inside-wsl2
https://stackoverflow.com/questions/64763147/access-a-localhost-running-in-windows-from-inside-wsl2
https://github.com/microsoft/WSL/issues/5336
https://github.com/microsoft/WSL/issues/4275
##------------------------
---19/7/
=============================================================================
FIX WSL2 NETWORKING IN WINDOWS 10
=============================================================================
cmd as admin:
wsl --shutdown
netsh winsock reset
netsh int ip reset all
netsh winhttp reset proxy
ipconfig /flushdns

Windows Search > Network Reset

Restart Windows
-----------------------------------------------------------------------------
configured following but unable to restart the networking service

configure wsl gateway by 
 /etc/netwrok/interfaces.d/eth0
address 172.20.96.1
netmask 255.255.240.0
gateway 192.168.0.1
 -----------------------------------
sudo apt-get update

got an errory saying error 'unable to resolve the ''archive.ubuntu.com'

------------------------
 ip route
Error: ipv4: FIB table does not exist.
Dump terminated

rem deleted /etc/netwrok/interfaces.d/eth0
 ip route
gets the same error
--------------------------------------------
 C:\Users<your_username>.wslconfig

``` config
[wsl2]
swap=0
   
```
worked
---------





