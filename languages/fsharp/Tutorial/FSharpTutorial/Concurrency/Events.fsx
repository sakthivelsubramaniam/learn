 open System  

 // raising event and  handling the event
 let simpleHandler1 = fun x->printfn "this is handler1, event aurgument value is : %d" x
 let simpleHandler2 = fun x->printfn "this is handler2, event aurgument value is : %d" x
 
 let simpleEvent = new Event<int>()
 simpleEvent.Publish.Add(simpleHandler1)
 simpleEvent.Publish.Add(simpleHandler2)
 simpleEvent.Trigger(4)


// directly invoking the  handling the event
 let myhandler sender eventArg =
    printf "sakthivel" 
 let eventHandler = new EventHandler(myhandler)
 eventHandler.Invoke("mystring", new EventArgs())
 
 //timer event 
 open System.Timers
 let timerEventHandler = new ElapsedEventHandler(fun _ _ -> printf "timer event is  handled" )
 let timer:Timer = new Timer(500.0)
 timer.AutoReset <- true
 timer.Elapsed.AddHandler(timerEventHandler)
 timer.Start()
 System.Threading.Thread.Sleep(5000)
 timer.Stop()
 
 
 //timer event with Async block
 open System.Timers
 let createAsyncTimer =
    let timerEventHandler = new ElapsedEventHandler(fun _ _ -> printf "timer event is  handled" )
    let timer:Timer = new Timer(1000.0)
    timer.AutoReset <- true
    timer.Elapsed.AddHandler(timerEventHandler)
    async {
        // start timer...
        timer.Start()
        // ...run for five seconds...
        do! Async.Sleep 5000
        // ... and stop
        timer.Stop()
        } 

 Async.RunSynchronously createAsyncTimer 