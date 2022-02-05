**iptables**
Command | description 
---|---
iptables -L | list all the rules
sudo iptables -L  {chain} --line-numbers | list the rules with line numbers
iptables -v | show information in more detail format
iptables -a | appends ip address to the rule, options are 
 || -i  interface name (etho)
 || -p  name of protocal can be tcp, udp, udplite, icmp, sctp, icmpv6, and so on.
 || -s (source) — the address from which traffic comes from. You can add a hostname or IP address.
 || –dport (destination port) — the destination port number of a protocol, such as 22 (SSH), 443 (https), etc.
 || -j (target) — the target name (ACCEPT, DROP, RETURN). You need to insert this every time you make a new rule.
sudo iptables -A <chain> -i <interface> -p <protocol (tcp/udp) > -s <source> --dport <port no.>  -j <target> | syntax
sudo iptables -A INPUT -i lo -j ACCEPT | to allow traffic at localhost
sudo iptables -A INPUT -p tcp --dport 80 -j ACCEPT | to allow http traffic
sudo iptables -A INPUT -p tcp --dport 443 -j ACCEPT | to allow https traffic
sudo iptables -A INPUT -p tcp --dport 22 -j ACCEPT | to allow ssh traffic
sudo iptables -A INPUT -s 192.168.1.3 -j ACCEPT | to filter the traffic on source ip address
sudo iptables -A INPUT -s 192.168.1.3 -j DROP | reject the ip address 
sudo iptables -A INPUT -m iprange --src-range 192.168.1.100-192.168.1.200 -j DROP | to reject range of ip address
sudo iptables -A INPUT -j DROP | rejecting all traffic
sudo iptables -F |(F flushes) removing all the rules
sudo iptables -D INPUT 3 | Delete the rule with line number 3
sudo iptables  | -L List the the iptables
|| -D Delete the rule spec
|| -I Insert at specific location
|| -R Replace the rule spec
|| -F Flush the rule spec






sudo /sbin/iptables-save | rules that are changed will be in memory, this command persist to the disk
