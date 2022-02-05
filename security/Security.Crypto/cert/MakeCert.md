Make a certificate issued by the default test root. Save the certificate to a file.

`makecert   "MyNew.cer"`

Make a certificate issued by the default test root. Save it new store.

`MakeCert -ss MyNewStore`


Make a certificate issued by the default test root. Create a key container and save the certificate to  a file.

`MakeCert -sk MyNewKey  MyNew.cer`

Make a certificate issued by the default test root. Create a private key file and save the certificate to  a file.

`MakeCert -sv MyKeyFile MyNew.cer`

`MakeCert -sk MyNewKey -ss My MyNew.cer -pe`

Make a certificate by using the default test root. Save the certificate to a store. Then make another certificate issued by the newly created certificate. Save the second certificate to another store.

`MakeCert -sk MyNewKey -ss MyNewStore MakeCert -is MyNewStore -ss My`

 Generate the root certificate

 -cy - authority (ca authority) or end (end user) 
 -r  - self signed certificate 
 -sky - signature| Exchange | integer(like 3) 

`makecert.exe -r -pe -n "CN=Sample.CA" -ss CA -sr CurrentUser -a sha1 -cy authority -sky signature -sv d:\Sample.CA.pvk d:\Sample.CA.cer`

 Create the certificate for code signing

`.makecert.exe -pe -n "CN=Sample.CodeSigning" -eku "1.3.6.1.5.5.7.3.3,1.3.6.1.4.1.311.10.3.13" -a sha1 -cy end -sky signature -ic d:\Sample.CA.cer -iv d:\Sample.CA.pvk -sv d:\Sample.CodeSigning.pvk d:\Sample.CodeSigning.cer`


Create a self-signed CA certificate

`makecert -r -pe -n "CN=ScottBrady91Root" -a sha512 -sky signature -cy authority -sv ScottBrady91Root.pvk -len 4096 -e 01/04/2099 ScottBrady91Root.cer`


Using the CA certificate to create Key exchange certificate

`makecert -pe -n "CN=ScottBrady91" -a sha512 -len 4096 -sky exchange -ic ScottBrady91Root.cer -iv ScottBrady91Root.pvk -sv ScottBrady91.pvk ScottBrady91.cer`

Create a self-signed SSL certificate

`makecert -r -pe -n "CN=sakthivel" -b 01/01/2015 -e 01/01/2020 -sky exchange -a sha256 -len 2048 -ss my -sr localMachine  mysslcert.pfx mysslcert.cer`

Create a self-signed Signing certificate

`makecert -r -pe -n "CN=%1" -b 01/01/2015 -e 01/01/2020 -sky signature -a sha256 -len 2048 -ss my -sr LocalMachine`

Create a self-signed Signing certificate and saving to file

`makecert -r -pe -n "CN=%1" -b 01/01/2017 -e 01/01/2025 -sky signature -a sha256 -len 2048 -sv %1.pfx %1.cer`


certificate to pfx file format

`.\pvk2pfx.exe -pvk d:\Sample.CodeSigning.pvk -spc d:\Sample.CodeSigning.cer -pfx d:\Sample.CodeSigning.pfx`

open ssl self sign certificate

`openssl req -x509 -newkey rsa:4096 -keyout key.pem -out cert.pem -days 365`




