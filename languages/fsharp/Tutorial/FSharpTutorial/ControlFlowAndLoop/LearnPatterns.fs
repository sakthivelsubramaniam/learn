namespace learnfsh
 module learnPattern = 
   type Sometype = 
      | Fname of string 
      | Lname of string 
      | FullName of string*string

   let matchValueToFun =
      let f1 x = 
         match x with
         | 10 -> printfn "10"
         | 20 -> printfn "20"
         | _ ->  printfn "wild card match"
      f1 20
      f1 10

   let matchForOR =
      let f1 x =
            match x with
            | 10 | 20 -> printfn "value is %A" x
            | _ -> printfn "other values %A" x
      f1 20
      f1 10
      f1 30
   
   let matchForOptionType = 
      let data1 = Some "sakthivel"
      let f1 (x:string option) =
         match x with 
         | Some s -> printfn "some value is %A" s
         | None -> printfn "value is null"
      f1 data1

   let matchTypes = 
      printfn "test prinfn " 
      
      let f1 (x:Sometype) =
         match x with 
         | Fname(firstName) -> printfn "first name %A " firstName
         | Lname (lastName) -> printfn "last name %A " lastName
         | FullName (first,last) -> printfn "first name : %s last name: %s " first last
      let sample1 = Fname "sakthivel"
      printfn "sample %A" sample1
      let sample2 = Lname "sainathan"
      let sample3 = FullName ("sakthi", "sainath")
      f1 sample1
      f1 sample2
      f1 sample3


   let execTestCases =
      printfn "executing matchValueToFun "
      matchValueToFun
      printfn "matchForOR"
      matchForOR
      printfn "matchForOptionType"
      matchForOptionType
      printfn "matchTypes"
      matchTypes
      

   
