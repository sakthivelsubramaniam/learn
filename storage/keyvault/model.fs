namespace Util

module Model =
    type AppCredential = { Appid:string;  AppKey:string}
    type KeyVaultInfo = {Uri:string; SecretName:string}
    type AppCertCredential = { Appid:string;  ClientCertThumpprint:string}

    type CredentialInfo =
        | AppCredential of AppCredential
        | AppCertCredential of AppCertCredential
