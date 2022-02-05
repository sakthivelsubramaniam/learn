
## creates a ssl server certificate in the store local machine
## subject alternative name is "www.fabrikam.com", "www.contoso.com"
## subject name is "www.fabrikam.com"
New-SelfSignedCertificate -DnsName "www.fabrikam.com", "www.contoso.com" -CertStoreLocation "cert:\LocalMachine\My"


## clones the previsous generated certs
Set-Location -Path "cert:\LocalMachine\My"
Cert:\LocalMachine\My> $OldCert = (Get-ChildItem -Path E42DBC3B3F2771990A9B3E35D0C3C422779DACD7)
Cert:\LocalMachine\My> New-SelfSignedCertificate -CloneCert $OldCert

## self-signed S/MIME certificate in the user MY store
## The certificate uses the default provider, which is the Microsoft Software Key Storage Provider.
New-SelfSignedCertificate -Type Custom `
  -Subject "E=patti.fuller@contoso.com,CN=Patti Fuller" `
  -TextExtension @("2.5.29.37={text}1.3.6.1.5.5.7.3.4","2.5.29.17={text}email=patti.fuller@contoso.com&upn=pattifuller@contoso.com") 
   -KeyUsage DataEncipherment `
   -KeyAlgorithm RSA ` 
   -KeyLength 2048 `
   -SmimeCapabilities ` 
   -CertStoreLocation "Cert:\CurrentUser\My" 

#creates self-signed client authentication certificate in the user MY store

 New-SelfSignedCertificate -Type Custom `
  -Subject "CN=Patti Fuller,OU=UserAccounts,DC=corp,DC=contoso,DC=com"
  -TextExtension @("2.5.29.37={text}1.3.6.1.5.5.7.3.2","2.5.29.17={text}upn=pattifuller@contoso.com") `
  -KeyUsage DigitalSignature `
  -KeyAlgorithm RSA `
  -KeyLength 2048  `
   -CertStoreLocation "Cert:\CurrentUser\My" 


## a self-signed client authentication certificate in the user MY store.
## The certificate uses an elliptic curve asymmetric key and the curve parameters nist256, which creates a 256-bit key
New-SelfSignedCertificate -Type Custom `
-Subject "CN=Patti Fuller,OU=UserAccounts,DC=corp,DC=contoso,DC=com"
 -TextExtension @("2.5.29.37={text}1.3.6.1.5.5.7.3.2","2.5.29.17={text}upn=pattifuller@contoso.com") `
 -KeyUsage DigitalSignature `
 -KeyAlgorithm ECDSA_nistP256 -CurveExport CurveName `
 -CertStoreLocation "Cert:\CurrentUser\My"


#  self-signed client authentication certificate in the user MY store
#  The certificate uses the Microsoft Platform Crypto Provider.
#  This provider uses the Trusted Platform Module (TPM) of the device to create the asymmetric key

New-SelfSignedCertificate -Type Custom `
-Provider "Microsoft Platform Crypto Provider" `
-Subject "CN=Patti Fuller" `
-TextExtension @("2.5.29.37={text}1.3.6.1.5.5.7.3.2","2.5.29.17={text}upn=pattifuller@contoso.com") `
-KeyExportPolicy NonExportable `
-KeyUsage DigitalSignature `
-KeyAlgorithm RSA -KeyLength 2048 `
-CertStoreLocation "Cert:\CurrentUser\My"

#  a self-signed client authentication certificate in the user MY store

New-SelfSignedCertificate -Type Custom `
 -Container test* `
 -Subject "CN=Patti Fuller" `
 -TextExtension @("2.5.29.37={text}1.3.6.1.5.5.7.3.2","2.5.29.17={text}upn=pattifuller@contoso.com") `
 -KeyUsage DigitalSignature `
 -KeyAlgorithm RSA -KeyLength 2048 `
 -NotAfter (Get-Date).AddMonths(6)

## link to the full description
https://docs.microsoft.com/en-us/powershell/module/pkiclient/new-selfsignedcertificate?view=win10-ps