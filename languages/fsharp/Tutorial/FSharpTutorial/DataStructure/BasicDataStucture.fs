  namespace mynamespace
   open System;
   module mylisttuplerecord =

        let alist = [10;20;30;40]
        let atuple = (1,"name",30)
        // record type
        type contracttype = 
            {
                Name: string;
                Phone: string;
                Verified:bool
            }

        let contact1 = { Name = "Alf" ; Phone = "(206) 555-0157" ; Verified = false }

    module mydiscriniateunion =
        let greeting name = 
            match name with
                | "sakthi" -> "hello"
                | "kaveri" -> "good morning"
                | _ -> "default value"
        
        let r1 = greeting "sakthi"
        printfn "name of the value %A" r1 
      



