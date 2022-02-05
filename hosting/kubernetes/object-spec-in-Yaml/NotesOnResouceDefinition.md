
##Service Definition
target port - By default the target port is same as port. It is the port number that is exposed by selected Pods.

Service will also assigned cluster ip.

Service without selector

```
apiVersion: v1
kind: Endpoints
metadata:
  name: my-service
subsets:
  - addresses:
      - ip: 1.2.3.4
    ports:
      - port: 9376

```
in this case the traffic will be routed to 1.2.3.4:9376

## Igress Resourcec
