namespace DataStructure

module MyList =
 let rec sum list = 
    match list with
        | h::tail -> (sum tail) + h
        | [] -> 0

 let rec sumAux acc list =
    match list with
        | h::tail -> sumAux (acc + h) tail
        | [] -> acc