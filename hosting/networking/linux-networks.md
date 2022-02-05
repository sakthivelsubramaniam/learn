Command | description 
---|---
sudo apt install net-tools | installs the network tools
**if config**|
ifconfig | view the details of the Interface, Enable/Disable the iterface etc
ifconfig [adaptor name] | view the details of specific interface
ifconig -a | view all the details of the interface
ifup [interface] | enablespecific config
ifdown [interface] | disable config
ifconfig eth0 mtu XXXX | setting MTU size
ifconfig eth0 - promisc |  promisc mode - to recieve all the packets that does not belong to particular NIC
**PING** | Packet internet Groper - uses ICMP (internet control message protocol)
Ping [ipaddress] | Linux pings continuesly till Ctl + C 
ping -c 5 <IpAddress> | pings 5 request and exists
**TraceRoute** | No of hops and path between source and destination
**netstat** | to view connection and routing table info
**dig** | domain information Groper - query DSN related info like A records
**NsLoopup** | DNS related infomation
 **host**| finds the name to ip and ip to name
 **ARP** | content of kernal arp table
 **hostname**| host name of the host
 **configuration**|
 /etc/hosts | localhost configuration
 /etc/resolv.conf | default domain name server
 /etc/nsswitch.conf | order in which to contact differenct name service
 **PCMA Card ** |
**port no**|
/etc/services | list the ports used by application