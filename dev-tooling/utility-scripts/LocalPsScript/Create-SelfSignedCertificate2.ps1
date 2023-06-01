New-SelfSignedCertificate -CertStoreLocation cert:\currentuser\my ` 
-Subject "CN=Local Code Signing" ` 
-KeyAlgorithm RSA ` 
-KeyLength 2048 ` 
-Provider "Microsoft Enhanced RSA and AES Cryptographic Provider" ` 
-KeyExportPolicy Exportable ` 
-KeyUsage DigitalSignature ` 
-Type CodeSigningCert

#
# New-SelfsignedCertificate -Subject "CN=Test Code Signing" `
#-EKU "Code Signing" `
#-KeySpec "Signature" ` 
#-KeyUsage "DigitalSignature" `
#-FriendlyName "Test code signing"
#-NotAfter $([datetime]::now.AddYears(5))


get-help New-SelfSignedCertificate
