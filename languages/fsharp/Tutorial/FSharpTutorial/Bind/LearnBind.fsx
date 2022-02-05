// Combinator library
// use flow when request triggers a use case  and request data flows through the system
// Categories into Constructors, adaptors and combinators
// 

 module combinators = 
  open System

  type Result<'TSuccess, 'TFailure> =
   | Success of 'TSuccess
   | Failure of 'TFailure

  type Request = {name:string; email:string}

  // constructors
  // Success - are defined when union type is define
  // Failures - 
  // >> Normal Composition

  // bind - adaptor  
  let bind fnToBind =
    fun result -> 
      match result with 
      | Success s -> fnToBind s
      | Failure f -> Failure f

  // bind 
  let (>>=) (input:Result<Request,string>) (fnToBind) =
    bind fnToBind input

  // >=> switch composition
  let (>=>) (fnA) (fnB) x = 
    match fnA x with 
      | Success s -> fnB s
      | Failure f -> Failure f 
  // another way to compose switch composition is 
  // let (>=>) (fna) (fnb) = fna >> bind fnb
  
  // converts simple function to a switch function
  let switch f x =
    f x |> Success

  // creating two track to one track functions.
  let map oneTrackfn  twoTrackFn =
    match twoTrackFn with  
      | Success s -> Success ( oneTrackfn s)
      | Failure f -> Failure f
 
  // an adapter that takes dead end function, applies it to the value and return the input
  // other names : tab
  let tee f x =
    f x |> ignore
    x
  
  let tryCatch f x =
    try 
      f x |> ignore
      x
    with 
    | ex -> Failure ex.Message

  let doubleMap fnA fnB  twoTrackInput =
    match twoTrackInput with 
    | Success s -> fnA s
    | Failure f -> fnB f

  let plus addSuccess addFailure fnA fnB x =
    match (fnA x) (fnB x) with  
    | Success s1, Success s2 -> Success (addSuccess s1 s2)
    | Failure f1, Success _ -> Failure f1
    | Success _, Failure f2 -> Failure f2
    | Failure f1, Failure f2 -> (addFailure f1 f2)


  module sampleflow =

    let validateInput1 input =
      if input.name = "" then Failure "Name must not be blank"
      else if input.email = "" then Failure "email must not be blank"
      else Success input 

    let validateInput2 input =
      if input.name.Length < 10  then Failure "Length validation failed"
      else Success input 

    let printValidation (input:Result<Request,string>) =
      match input with 
      | Success s -> printfn "validation is passed %A " s.name
      | Failure f -> printfn "validation Message: %A" f      

    let flow1 (req1: Request) =
      req1 
        |> validateInput1 
        >>= validateInput2
        |> printValidation

    let flow2 (req1: Request) =
      let fn = validateInput1 >> bind validateInput2 >> printValidation
      fn req1

    let execFlow1 =
        let request1 = {name = "sakthivel subrmaniam"; email = ""}
        flow1 request1
        flow2 request1

        let request2 = { name = "sakthivel"; email = "sakthivel@hotmail.com"}
        flow1 request2
        flow2 request2

        let request3 =  {request1 with email = "sakthivel@hotmail.com"}
        flow1 request3
        flow2 request3

    let execTestCases =

      do printfn "executing flow1-1 "
      execFlow1 
      ()
    
    execTestCases 