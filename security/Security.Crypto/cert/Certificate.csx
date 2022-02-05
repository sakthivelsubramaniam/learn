using System;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.Azure.KeyVault;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class CertUtil
{
    public static X509Certificate2 GetCertificate2(string certificateThumbprint)
        {
            X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            try
            {
                store.Open(OpenFlags.ReadOnly);
                X509Certificate2Collection certificateCollection = store.Certificates.Find(X509FindType.FindByThumbprint, certificateThumbprint, false);
                if (certificateCollection == null || certificateCollection.Count == 0)
                {
                    throw new Exception("Certificate not installed in the store");
                }

                return certificateCollection[0];
            }
            finally
            {
                store.Close();
            }
        }
     

}