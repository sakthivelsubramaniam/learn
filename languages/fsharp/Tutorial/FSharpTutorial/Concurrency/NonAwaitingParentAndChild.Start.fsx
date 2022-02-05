open System
open System.Threading

// Async workflow will be run in different thread 
// Async.Start - will not wait for child task to complete
//  Parent will be executed parellel with child child task

let someTask (name:string) =
    let threadid = Thread.CurrentThread.ManagedThreadId

    printfn "@@%s started %i" name threadid    

    for i = 1 to 100 do
        printfn "@@%s  %i" name i
        Async.Sleep(5000) |> ignore 
    printfn "@@%s flow completed" name

let childFlowAsync1 =
    async { 
        do someTask "childflow1"
    }
    
let parentFlowAsync () =
    printfn "@@Parent started %i" System.Threading.Thread.CurrentThread.ManagedThreadId
    Async.Start childFlowAsync1 |> ignore
    do someTask "parenttask"
    Async.Sleep(1000)


printfn "*****start run 1****"
parentFlowAsync () |> ignore
printfn "*****end run 1*****"


