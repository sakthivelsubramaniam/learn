
open System;
module myclasses =
    type aclass() =
            let name = "sakthivel"
            member this.firstName = name
            member this.lastName = "subramaniam"
    let a1class = aclass()

    type bclass() =
        let name = "sakthivel"
        member this.firstName = name
        member this.lastName = "subramaniam"
    let b1class = bclass()

    printfn "print fn %s" b1class.firstName
    

