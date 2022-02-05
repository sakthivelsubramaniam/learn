open System
open AzDocDb

[<EntryPoint>]
let main argv =
    RouteRepository.getRouter |> ignore
    0 // return an integer exit code