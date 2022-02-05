using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication1
{

    public class SignAndVerifyUsingRSAPKCS1SignatureDeformatter
    {
        private string _rsaPrivateKey = "<RSAKeyValue><Modulus>vU3Yfu1Z4nFknj9daoDmh+I0CzR+aLnTjUSejQyNJ0IgMb59x4mVe17C6U+bl4Cry7gXAk3LEmmE/BRxjlF8HKlXixoBWak1dpmr89Ye7iaD2UWwl5Dmn07Q9s27NGdywy0BsD1vDcFSgno3LUbVznkw/0hypbnOPxWKlBCao2c=</Modulus><Exponent>AQAB</Exponent><P>6veL+pbUjOr0PAiFcvBRwNlTz/+8T1iLHqkCggRPDSsTg25ybSqDa98mP5NQj9LHSYCECjOGZkiN4NoxgPPDxw==</P><Q>zj/l0Z36A/iD2IrVQzrEsvp31cmU6f9VCyPIGiM0FSEXbj23JuPNUPCzSo5oAAiSZfs/hR9uuAx1xQFAfTzjYQ==</Q><DP>dsW7VGh5+OGro80K6BbivIEfBL1ZCyLO8Ciuw9o5u4ZSztU9skETPawHQYvN5WW+p0D3fdCd14ZFcavZ6j1OcQ==</DP><DQ>YSQBRzgjsEkVOCEzjsWYLUAAvwWBiLCEyolgzsaz2hvK4FZa9AspAa1MlJn768Ady8CJS1bhm/fqZA5R5GqQIQ==</DQ><InverseQ>zEGFnyMtfxSYHwRv8nZ4xVcFctnU2pYmmXXYv8NV5FvhZi8Z1f1GE3tmS8qDyIuDTrXjmII2cffLMjPOVmLKoQ==</InverseQ><D>Ii97qDg+oijuDbHNsd0DRIix81AQf+MG9BzvMPOSTgOgAruuxSjwaK4NLsrkgzCGVayx4wWfZXzOuiMK+rN2YPr6IPeut3O14uuwLH7brxkit+MnhclsCtKpdT2iuUGOnbEhWccepCO7YLyyczhT9GE0rEtbEK6S7wvVKab/osE=</D></RSAKeyValue>";
        private string _rsasPublicKey = "<RSAKeyValue><Modulus>vU3Yfu1Z4nFknj9daoDmh+I0CzR+aLnTjUSejQyNJ0IgMb59x4mVe17C6U+bl4Cry7gXAk3LEmmE/BRxjlF8HKlXixoBWak1dpmr89Ye7iaD2UWwl5Dmn07Q9s27NGdywy0BsD1vDcFSgno3LUbVznkw/0hypbnOPxWKlBCao2c=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";


        public DigitalSignatureResult BuildSignedMessage(string message)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            
             RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.FromXmlString(_rsasPublicKey);

            byte[] cipherBytes = csp.Encrypt(messageBytes, false);
            byte[] cipherHash = ComputeHashForMessage(cipherBytes);
            byte[] signatureHash = CalculateSignatureBytes(cipherHash);
        
            string cipher = Convert.ToBase64String(cipherBytes);
            string signature = Convert.ToBase64String(signatureHash);
            return new DigitalSignatureResult() { CipherText = cipher, SignatureText = signature };
        }

        
        private void VerifySignature(byte[] computedHash, byte[] signatureBytes)
        {
            RSACryptoServiceProvider senderCipher = new RSACryptoServiceProvider();
            senderCipher.FromXmlString(_rsasPublicKey);

            RSAPKCS1SignatureDeformatter deformatter = new RSAPKCS1SignatureDeformatter(senderCipher);
            deformatter.SetHashAlgorithm("SHA1");

            if (!deformatter.VerifySignature(computedHash, signatureBytes))
            {
                throw new ApplicationException("Signature did not match from sender");
            }
        }

        private byte[] ComputeHashForMessage(byte[] cipherBytes)
        {
            SHA1Managed alg = new SHA1Managed();
            byte[] hash = alg.ComputeHash(cipherBytes);
            return hash;
        }

        private byte[] CalculateSignatureBytes(byte[] hashToSign)
        {
             RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.FromXmlString(_rsaPrivateKey);

            RSAPKCS1SignatureFormatter signatureFormatter = new RSAPKCS1SignatureFormatter(csp);
            signatureFormatter.SetHashAlgorithm("SHA1");
            byte[] signature = signatureFormatter.CreateSignature(hashToSign);
            return signature;
        }
    }

    public class DigitalSignatureResult
    {
        public string CipherText { get; set; }
        public string SignatureText { get; set; }
    }
}