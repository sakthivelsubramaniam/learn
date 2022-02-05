open System.Security.Cryptography.X509Certificates
let certificateThumbprint = "1E1400C0C3EB7589FF2A06303F553E858A1AEFB4"
let store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
store.Open(OpenFlags.ReadOnly) 
let certificateCollection = store.Certificates.Find(X509FindType.FindByThumbprint, certificateThumbprint, false);
store.Close();;
let cert = certificateCollection.[0]
printf "certificate is %s " cert.Thumbprint 
