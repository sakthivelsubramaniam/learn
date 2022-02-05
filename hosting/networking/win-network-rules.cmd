rem  by default, firewall will block all the connection, unless it is allowed by rule.
rem  firewall open and close
netsh firewall set opmode DISABLE      
netsh firewall set opmode    ENABLE   

rem allow and deny port using netsh
netsh firewall add portopening TCP _port_number_ _name_ DISABLE ALL
netsh firewall add portopening TCP 3264 CCMAIL DISABLE ALL

netsh firewall add portopening TCP _port_number_ _name_ ENABLE ALL
netsh firewall add portopening TCP 8443 PLESK-ADMIN ENABLE ALL

rem all and deny program
netsh firewall add allowedprogram _path_ _name_ DISABLE ALL
netsh firewall add allowedprogram C:\WINDOWS\Cluster\CluAdmin.exe CLUSTER-ADMIN DISABLE ALL

rem all and deny multi cast rule
netsh firewall set multicastbroadcastresponse DISABLE

rem desktop popup
netsh firewall set notifications DISABLE

rem allow and deny network service
netsh firewall set service REMOTEDESKTOP ENABLE


rem all and deny network logging
netsh firewall set logging _path_ _size_ ENABLE
netsh firewall set logging C:\WINDOWS\system32\LogFiles\firewall.log 4096 ENABLE

rem confire firewall reporting
netsh firewall  show config verbose = ENABLE
netsh firewall show state verbose = ENABLE

rem load backup configuration using file 
netsh -f filename
