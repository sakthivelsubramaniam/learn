## Physical Interface  - Layer 1
``` cmd

ip link show 
ip -br link show
ip link set eth0 up

rem additional statistic about the devise
ip -s link show eth0
```

## link layer

``` cmd

rem check the ARP command 
ip neighbor show



```

## Layer 3 command 
ip -br address show

``` cmd
traceroute www.google.com
ip route show 10.0.0.0/8
nslookup www.google.com
```

## layer 4 command 
``` cmd
ss -tunlp4

rem check the connection.
telnet database.example.com 3306

rem check the connection for udp
Ncat: Connection refused.
nmap
```

## iptables
1  filter tables
2. Nat tables
1. Mangle tables - 
1. Raw
1. Security 

## chains
1. Pre Routing
1. Input
1. Forward
1. Output
1. Post Routing

## Rules
It has two part
Match part + Action


## Syntacts

```bash
 
iptables -t [tables] -OPTIONS [CHAINS] [matching component] [action component]



```