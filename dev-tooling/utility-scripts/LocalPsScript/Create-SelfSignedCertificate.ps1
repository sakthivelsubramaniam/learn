$cert = New-SelfSignedCertificate -certstorelocation cert:\localmachine\my -dnsname  katasys.com

$pwd = ConvertTo-SecureString -String ‘password1234’ -Force -AsPlainText

$path = ‘cert:\localMachine\my\’ + $cert.thumbprint

Export-PfxCertificate -cert $path -FilePath d:\temp\powershellcert.pfx -Password $pwd