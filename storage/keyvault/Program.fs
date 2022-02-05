open System
open Util.Model

[<EntryPoint>]
let main argv =
    
    
    let appcredential = {Appid=""; AppKey=""}
    // appid is application id is azure
    // appkey is app secret, This generated when azure ad setting blad is saved with private key name
    let appCretcredential = AppCertCredential {Appid=""; ClientCertThumpprint=""}
    
    //let client = Util.Helper.getClient appcredential
    let client = Util.Helper.getClient appCretcredential

    let secret = client|> Util.Helper.getSecret ""

    printf "%s" secret.Value
    0 // return an integer exit code
