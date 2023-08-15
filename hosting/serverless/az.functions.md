# Azure functions

## Limits and consideration

|---|--|---|
|Plan |Default |Maximum |
|---|--|---|
|Consumption plan|5|10|
|Premium plan|302|Unlimited3|
|Dedicated plan|302|Unlimited3|

* Regardless of the function app timeout setting, 230 seconds is the maximum amount of time that an HTTP triggered function can take to respond to a request. This is because of the default idle timeout of Azure Load Balancer.
* For unlimited setting, Guaranteed is up to 60 minutes. OS and runtime patching, vulnerability patching, and scale in behaviors can still cancel function executions so ensure to write robust functions.
