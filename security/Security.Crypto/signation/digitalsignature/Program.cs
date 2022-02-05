using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
namespace ConsoleApplication1
{

    class Program
    {

        static void Main(string[] args)
        {
            // Usage sample

            try
            {
                // Sign text
                byte[] signature = Sign("Test", "cn=my cert subject");
                // Verify signature. Testcert.cer corresponds to "cn=my cert subject"

                if (Verify("Test", signature, @"C:\testcert.cer"))
                {
                    Console.WriteLine("Signature verified");
                }
                else
                {
                    Console.WriteLine("ERROR: Signature not valid!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Sender sender = new Sender();
            DigitalSignatureResult res = sender.BuildSignedMessage("Hello digital sig!");

            Console.WriteLine(res.CipherText);
            Console.WriteLine(res.SignatureText);
        
            Console.ReadKey();
        }


    }

}

