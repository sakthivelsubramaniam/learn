# Versioning

There are two types of compatibility
* Forward Compatibility
- Upgrading the service in the future will not break existing clients
- Requires some agreements on future design features, and the design of new versions to respect old 
interfaces
* Backward Compatibility
- Newly created service is compatible with old clients
- Requires the design of new versions to respect old interfaces
The hard type of compatibility is forward compatibility

Json: It validates what is only needed, it ignores the old one.

Versioning
Three options are 

## Versioning URI

> http://bank.com/v2/accounts

## Custom Http Headers
> api-version: 2

## Accept Http Headers
> Accept: application/vnd.accounts.v2+json

ref:
1. [versioning-medium](https://medium.com/geekculture/clean-architecture-using-c-api-versioning-128559de808f)
2. [versioning-InfoWorld ]( https://www.infoworld.com/article/3671870/how-to-version-minimal-apis-in-aspnet-core-6.html )