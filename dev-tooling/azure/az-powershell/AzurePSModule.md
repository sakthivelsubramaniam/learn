# Azure Powershell Module


`Uninstall-AllModules -TargetModule AzureRM -Version 4.4.1 -Force`

# installing powershell module
 `Install-Module -Name Az -AllowClobber -Scope CurrentUser`

# Get the modules that are installed in the system
`Get-InstalledModule -Name Az -AllVersions`

# update the module
`Install-Module -Name Az -AllowClobber -Force`

# to install multiple version
`Get-InstalledModule -Name Az -AllVersions | select Name,Version`

# to insstall with required version
# Install Az version 0.7.0
`Install-Module -Name Az -RequiredVersion 0.7.0 `
# Load Az version 0.7.0
`Import-Module -Name Az -RequiredVersion 0.7.0`

# for uninsalling the powershell module
 # for MSI installed module : Need to uninstall through windows uninstall.
 # for module installed using powershell get : uninstall by running the uninstall-all module.ps1



