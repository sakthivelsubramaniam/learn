rem list the route
rem package should be  routed to interface and then to gateway
rem if destination is another vm/docker then gateway entry will not be there
rem if destination is another machine in same network then gateway will not be there.
route print

rem syntax
ROUTE [-f] [-p] [command [destination] []

 –f  - switch is optional. This switch tells Windows to clear the routing table of all gateway entries.
 –p  - switch makes a specified route persistent.

 command - PRINT | ADD | DELETE | CHANGE.

rem  print can use wild card entries
ROUTE PRINT	192.*

rem delete the route 
ROUTE DELETE 192.0.0.0.

rem add and change 
ROUTE ADD | CHANGE  [destip] [subnet mask] [gateway]



