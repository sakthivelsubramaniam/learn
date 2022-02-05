$certDirectory = "D:\Projects\Psms\Deployment\"
$certList = Get-ChildItem $certDirectory
# For each cert in the folder, grab the thumbprint
foreach ($cert in $certList) 
    {
        $certPrint = New-Object System.Security.Cryptography.X509Certificates.X509Certificate2
        Write-Host  "$certDirectory$cert"
        $certPrint.Import("$certDirectory$cert")
        
        Write-Host $certPrint.Thumbprint
       
    }