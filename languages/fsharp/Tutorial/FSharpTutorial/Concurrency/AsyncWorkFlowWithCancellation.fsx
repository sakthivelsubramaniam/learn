open System
open System.Threading


let print1To100 =
     async {
        for i in [1..100] do
            printf "%i before.. " i
        do! Async.Sleep 1000 
        printfn "..after"
    }
//Async.RunSynchronously print1To100 

    // create a cancellation source
let cancellationSource = new CancellationTokenSource()
// start the task, but this time pass in a cancellation token
Async.Start (print1To100,cancellationSource.Token)
// wait a bit
Thread.Sleep(200)
// cancel after 200ms
cancellationSource.Cancel()


