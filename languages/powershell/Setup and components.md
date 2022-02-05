
# Powershell

## Version
current version is Powershell Core 6.1 and PowerShell Core 

## set permission
`set-executionpolicy -ExecutionPolicy Unrestricted` 

## Modules

  * Modules are installed from public repository  
  * It is installed in one of the installation path

  Command | Description
------------ | ------------- 
`Get-Module `   | list the modules that have been imported to to current session.
`Get-Module –ListAvailable`   | list the available module in the system that can be imported
`Get-InstalledModule` | get list of installed module
`Uninstall-Module` | uninstall the modules
`Import-Module` | imports the module into the current session
`Get-Command -Module` | gets the list of command from the module
`Find-Module` | from module name, gets the repository from which powershell modules are published
`get-PsRepository` | public repository registried in the powershell
`set-PSRepository`|  `Set-PSRepository -Name "PSGallery" -InstallationPolicy Trusted` to make it trusted 
 
## Help File updation
Command | Description
------------ | ------------- 
`Update-HelpFile` | Updates the help file 




## Ps Script
 Script to kill the process  
`get-process | where { $_.ProcessName -eq "*powershell" }|Stop-Process {$_.Handles}
` 
