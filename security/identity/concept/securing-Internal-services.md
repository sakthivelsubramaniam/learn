# Securing Internal Services

## Options available



## Using Certs signed by CA

Public certificate authorities generally won't work for internal services as your services are not reachable from the outside, so they have no way to verify that the certificate is being issued to the right entity. For example, if you asked Let's Encrypt for a server certificate for backend0001.myapp.myinternaldomain, Let's Encrypt needs to be able to verify that the request case from that hostname. For internal services, this is usually not reachable from the outside world.

Certificate authority: Instead, you should have an organization-wide CA managed with the same paranoia as a real CA (you need to absolutely control access to the CA key and ensure that you only issue certificates to the right entity).

### CA certificate 

The CA certificate will need to be available to all your servers and clients to be able to validate certificate chains.

### Server and client certificates  

Server and client certificates can be issued to your apps and client after verification of hostname or client identity. Deployment of certificate keys is something to be very careful about. You could use something like keywhiz or vault (just some examples, there are many others) to deploy certificate keys only on the correct hosts.

The biggest complexity is making sure that keys are only available to the right parties. Getting that part right is more of a process setup and less about the technical aspects. But then again, the same problem exists with a public CA (minus the CA key issue).

