
# Nuget 

* it does not work with project file. It is only used manage package outside the package. dotnet cli or visual studio or visual studio powershell is used for adding reference to the project. 

* list nuget packages from default source
* list nuget package from specified source
  
##  Pre-condition
* create a solution with project1 and project2 

## Exercise

1. list package from any of the source defined in config.
    will list package name containing specified.
   `nuget list IdentityModel `

1. list package from specific source   
   `nuget list IdentityModel -Source devget`

1. list package name containing either of two name   
    `nuget list IdentityModel Microsoft -Source devget`

1. list package name containing either of two name   
    `nuget list IdentityModel Microsoft -Source devget`

1. list with details   
    `nuget list IdentityModel -Verbosity -Source devget`

1. list all versions   
    `list Microsoft.IdentityModel.Protocols  -AllVersions  -Source devget`

1.  list include pre release   
    `list Microsoft.IdentityModel.Protocols  --Prerelease  -Source devget`

1.  install the package to the solution's package directory   
 `nuget Install Newtonsoft.Json -Version 11.0.2 -SolutionDirectory .`


* Persist source information
* determine version compatiblility
* specify custom location for project's package
