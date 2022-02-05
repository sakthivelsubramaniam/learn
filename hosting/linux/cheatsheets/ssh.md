SSH
---

1. it replaces telnet, rlogin and rsh
2. SSH runs as client server model  at port 22
3. client initiates the tcp connection with server and completes the handshake, ensuring symetic connection.


3. Each packet = {{Header}{body}}
4. Header = {mac} where MAC is F(symentric key, packet sequence number, message content )
5.   