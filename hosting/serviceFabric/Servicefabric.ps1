# setup script for dev cluster 

& "C:Program Files\Microsoft SDKs\Service Fabric\ClusterSetup\DevClusterSetup.ps1"

# import service fabric module

$AppPath = "$PSScriptRoot\CounterServiceApplication"
#$sdkInstallPath = (Get-ItemProperty 'HKLM:\Software\Microsoft\Service Fabric SDK').FabricSDKInstallPath
$sdkInstallPath = "C:\Program Files\Microsoft SDKs\Service Fabric\"
$sfSdkPsModulePath = $sdkInstallPath + "Tools\PSModule\ServiceFabricSDK"

Import-Module $sfSdkPsModulePath\ServiceFabricSDK.psm1

Copy-ServiceFabricApplicationPackage -ApplicationPackagePath $AppPath -ApplicationPackagePathInImageStore CounterServiceApplicationType -ImageStoreConnectionString (Get-ImageStoreConnectionStringFromClusterManifest(Get-ServiceFabricClusterManifest)) -TimeoutSec 1800
Register-ServiceFabricApplicationType CounterServiceApplicationType
New-ServiceFabricApplication fabric:/CounterServiceApplication CounterServiceApplicationType 1.0.0