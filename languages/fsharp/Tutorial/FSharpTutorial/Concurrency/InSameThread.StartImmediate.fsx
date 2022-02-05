open System
open System.Threading

// thread id will be same 
let childFlowAsync =
    async { 
    
    printfn "@@child started %i" System.Threading.Thread.CurrentThread.ManagedThreadId

    for i = 1 to 10 do
        printfn "childFlow %i" i
    printfn "@@child flow completed"
    }

let parentFlowAsync () =
    printfn "@@Parent started %i" System.Threading.Thread.CurrentThread.ManagedThreadId
    Async.StartImmediate childFlowAsync
    Async.Sleep(1000)


printfn "*****start run 1****"
parentFlowAsync () |> ignore
printfn "*****end run 1*****"
