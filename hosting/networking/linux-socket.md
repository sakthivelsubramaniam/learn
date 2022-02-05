Command | description 
---|---
Syntax| ss [options] [filter]
OPTIONS |
-s | socket summary
-H | suppress header lines

-O --oneline | print in one line
-n --numeric | try not to resolve the service name
-r --resolve | resolve the numeric port address  
-a --all | show all the sockets  
-l --Listening | displays listening socket (default)  
-o -- options |shows the timeing information  
-e --extended | show the detail information  
-m --memoery | show the memory usable  
-P --process | show the propress using the socket  
-i --info | show the internal TCP information  
-t --tcp | displays tcp socket   
FILTER |
- a | all   
- Z | SE linux security context  
samples |
ss -s | socket summary  
ss -pl | porcess name using the socket    
ss -t -a | all tcp sockets  
ss -u -a | all udp sockets   
ss -w -a | all raw sockets  
ss -x -a | all unix sockets  
 ss -o state established '( dport = :smtp or sport = :smtp )' | displays all established  
 


