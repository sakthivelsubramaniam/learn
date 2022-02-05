Command | description 
---|---
**ip**|
ip | similar to ifconfig, used to view and configure the ip addresses
ip link | show the link 
ip addr show | shows ip address and routing information
ip route show | shows route address
ip route add default gw 192.168.1.254 enp0s3 |
ip route add 192.168.1.0/24 dev enp0s3 |
sudo ip route add 10.0.2.0/24 via 192.168.43.223 dev enp0s3 | add a route
sudo ip route del  10.0.2.0/24 via 192.168.43.223 dev enp0s3 | delete a route
**route** | routing information
route add -net 10.10.10.0/24 gw 192.168.0.1 | adding a rounte
route del -net 10.10.10.0/24 gw 192.168.0.1 | delting a route
 route add default gw 192.168.0.1 | add default gateway


