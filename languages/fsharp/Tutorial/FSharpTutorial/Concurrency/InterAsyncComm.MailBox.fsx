
open System

type Message = {ID:int;Contents:string}

let mailBox = MailboxProcessor.Start (fun inbox ->
 
    let rec messageLoop() = async {
        
        let! msg = inbox.Receive()
        printfn "message inside the loop %i " msg.ID
        return! messageLoop()
    }
    messageLoop ()
) 
printfn "****message inside the loop ***"
mailBox.Post {ID=1;Contents ="test caseMessage3"}