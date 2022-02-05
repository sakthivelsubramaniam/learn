open System
open System.Threading

//IAsyncResult
let fileWriteWithAsync = 
    use stream = new System.IO.FileStream("test.txt",System.IO.FileMode.Create)
    printf "start aync write"
    let asyncResult = stream.BeginWrite(Array.empty,0,0,null,null)
    let async = Async.AwaitIAsyncResult(asyncResult) |> Async.Ignore
    printf "do something useful"
    Async.RunSynchronously async
    printfn "Async write completed"

//simple work flow to sleep 2 sec
let sleepWithAsync =
    async {
        printfn "start sleep %O" DateTime.Now.TimeOfDay
        do! Async.Sleep 2000
        printfn "end sleep %O" DateTime.Now.TimeOfDay
    }
//Async.StartImmediate sleepWithAsync 


let nestedWithAsync =
    async {
        printfn "start nested with async %O" DateTime.Now.TimeOfDay
        let! childWorkFlow = Async.StartChild sleepWithAsync
        do! Async.Sleep 3000
        printfn "doing something useful"
        let! result = childWorkFlow
        printfn "end nested with async %O" DateTime.Now.TimeOfDay
    }
Async.RunSynchronously nestedWithAsync 



