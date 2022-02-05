# Variables for common values
$rgn = "myRG"
$location = "eastus2"
$vmName =  "testVM"

#virtual network
#subnet config
$subnetConfig = New-AzureRmVirtualNetworkSubnetConfig  -Name "subnet1" -AddressPrefix 192.168.1.0/24


$vnet = New-AzureRmVirtualNetwork `
        -Location $location        `
        -ResourceGroupName  $rgn  `
        -Name myVnet1  `
        -AddressPrefix 192.168.0.0/16 `
        -Subnet $subnetConfig 

#create network security group
$sr = New-AzureRmNetworkSecurityRuleConfig  `
        -Name Mynr         `
        -Protocol Tcp     `
        -Direction Inbound `
        -Priority 1000 `
        -SourceAddressPrefix * `
        -SourcePortRange * `
        -DestinationAddressPrefix * `
        -DestinationPortRange 3389 `
        -Access Allow

$nsg = New-AzureRmNetworkSecurityGroup `
        -Location $location `
        -ResourceGroupName  $rgn `
        -Name mynsg `
        -SecurityRules $sr
        

#Create a virtual network card and associate with NSG
$nic = New-AzureRmNetworkInterface `
        -Location $location  `
        -ResourceGroupName  $rgn `
        -Name mynic `
        -SubnetId $vnet.Subnets[0].Id `
        -NetworkSecurityGroupId $nsg.Id 

#create the virtual machine
$cred =Get-Credential -Message "Enter a username and password for the virtual machine."
#sakthivelcs
#Aditi01*

$vmconfig = New-AzureRmVMConfig  `
           -VMName $vmName  `
           -VMSize Standard_B1s | 
            Set-AzureRMVMOperatingSystem -Windows -ComputerName $vmName -Credential $cred |
            Set-AzureRmVMSourceImage  -PublisherName MicrosoftWindowsServer -Offer WindowsServer -Skus 2016-Nano-Server -Version latest |
            Add-AzureRmVMNetworkInterface -Id $nic.Id

$Vm  = New-AzureRMVM `
        -Location $location `
        -ResourceGroupName  $rgn `
        -VM $vmConfig
            






 

