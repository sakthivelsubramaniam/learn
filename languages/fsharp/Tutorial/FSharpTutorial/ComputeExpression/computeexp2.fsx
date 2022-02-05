module optiondiv =
    let divideBy bottom top =
        if bottom = 0
        then None
        else Some(top/bottom)

    type MaybeBuilder() =
        member this.Bind(x,f) =
            match x with
                | None -> None
                | Some a -> f a
        member this.Return(x) = 
            Some x

    let maybe = new MaybeBuilder()
    let divideByWorkflow init x y z = 
        maybe 
            {
                let! a = init |> divideBy x
                let! b = a |> divideBy y
                let! c = b |> divideBy z
                return c
            }    

    let good = divideByWorkflow 12 3 2 1
    
    match good with
        | None -> printf "none"
        | Some a -> printf "%d" a
""""""

        

