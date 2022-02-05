namespace Util

module  Helper =
    open System
    open System.Threading.Tasks
    open Microsoft.Azure.KeyVault;
    open Microsoft.Azure.Services.AppAuthentication
    open Microsoft.IdentityModel.Clients.ActiveDirectory
    open Util.Model
    open System.Security.Cryptography
    open System.Security.Cryptography.X509Certificates
   
     

    let getCert (thumpprint:string) : X509Certificate2 =
        let store:X509Store = new X509Store(StoreName.My, StoreLocation.LocalMachine)
        store.Open(OpenFlags.ReadOnly)
        let certificateCollection:X509Certificate2Collection = store.Certificates.Find(X509FindType.FindByThumbprint, thumpprint, false)
        store.Close ()
        certificateCollection.[0]

    let private getAccessToken (appcredential:AppCredential ) (authority:string) (resource:string) (scope:string) =
        let authcontext = new AuthenticationContext(authority, TokenCache.DefaultShared)
        async {
            let adcredential = new ClientCredential(appcredential.Appid,appcredential.AppKey)
            let! result = authcontext.AcquireTokenAsync(resource, adcredential) |> Async.AwaitTask
            return result.AccessToken;
        } |> Async.StartAsTask

    let private  getAccessTokenCert (appcredential:AppCertCredential ) (authority:string) (resource:string) (scope:string) =
        let authcontext = new AuthenticationContext(authority, TokenCache.DefaultShared)
        async {
            let cert = getCert appcredential.ClientCertThumpprint
            let clientAssertionCertificate = new ClientAssertionCertificate(appcredential.Appid, cert)
            let! result = authcontext.AcquireTokenAsync(resource, clientAssertionCertificate) |> Async.AwaitTask
            return result.AccessToken;
        } |> Async.StartAsTask

    let getClient (credentialInfo:CredentialInfo) = 
        let getAccessToken = 
            match credentialInfo with 
                |  AppCredential appcredential -> getAccessToken appcredential
                |  AppCertCredential certCredentail -> getAccessTokenCert certCredentail    

        new KeyVaultClient(new KeyVaultCredential(KeyVaultClient.AuthenticationCallback getAccessToken))

    let getKey  valueUri name (client:KeyVaultClient ) =
        async {
            
            let! result = client.GetKeyAsync(valueUri, keyName = name) |> Async.AwaitTask
            return result
        } |> Async.RunSynchronously

    let getSecret (name:string) (client:KeyVaultClient) =
        async {
            
            let! result = client.GetSecretAsync(name) |> Async.AwaitTask
            return result
        } |> Async.RunSynchronously
    
    



   