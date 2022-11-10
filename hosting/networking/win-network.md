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

