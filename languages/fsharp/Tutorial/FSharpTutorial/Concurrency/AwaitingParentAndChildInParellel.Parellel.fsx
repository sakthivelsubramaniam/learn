open System
open System.Threading

// Async workflow will be run in different thread 
// Async.RunSynchronously- will wait till child task complete
//  Parent task will be executes after child task completes

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
let childFlowAsync2 =
    async { 
        do someTask "childflow2"
    }
    
let parentFlowAsync () =
    printfn "@@Parent started %i" System.Threading.Thread.CurrentThread.ManagedThreadId
    let parllelWrkFlow =Async.Parallel [childFlowAsync1;childFlowAsync2]
    Async.RunSynchronously parllelWrkFlow |> ignore
    do someTask "parenttask"
    Async.Sleep(1000)


printfn "*****start run 1****"
parentFlowAsync () |> ignore
printfn "*****end run 1*****"


