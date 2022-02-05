module File1 = 
    let a2 = [1..10]
    let a1 = 4
    let a3 = [|1..10|]
    let a4 = 11::a2
    
    // concatenate two list
    let a5 = a2@a4
    printfn "print integer"
    
    //The first argument is the desired length of the new list, and the second argument is an initializer function which generates items in the list. 
    let a6 = List.init 5 (fun index -> index*3)
    let a7 = List.map (fun x -> x+ 1) [1..10];;
    
    //list using cons operator
    let a8 = 1 :: 2 :: 3 :: [];;

   //Generators have the construct [for x in collection do ... yield expr]
     let a9 = [for i in a8 ->i*i ]
    
