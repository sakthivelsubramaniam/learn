# Commonly used operations


 ***Verify IP level connectivity to another computer ***
```batch 
 ping HOST   
 ping IP_ADDRESS

 rem continue ping till interrupted
 ping -t HOST  
``` 

***check port connection***

```batch
Test-Connection <HOst> -Port <portNumber>


```

***Display all the current Network configuration***

```batch
ipconfig
ipconfig /All
```

***Display route detail***
netstat -rn
route print

***Display DNS Name***
nslookup
nslookup <idadress> <DNS Server>
nslookup <hostname> <DNS Server>
nslookup -type soa HOSTNAME
nslookup -type any HOSTNAME

***Flush and reset client resolver***
ipconfig /flushdsn

***Get mac address***
getmac
getmac /s srvmain
getmac /s srvmain /u maindom\hiropln /p p@ssW23a

***Displays from ARC cache***
arp -a

***Delete the entries***
arp -d

***Display active ports***
netstat -an
-a : displays all active tcp port
-n : address and port number are expressed numerically.


