open System
open System.Collections
open System.Collections.Generic

module collectionturorial = 
 let product =
  [|2;5;3;6|]
  |> Array.reduce (fun x y -> x * y)

 let product1 = [5;3;6] |> List.fold (*) 1


 let results = new Dictionary<string,int>()
  
 results.Add("George", 10)
 results.Add("Peter", 5)
 results.Add("Jimmy", 9)
 results.Add("John", 2) 
  
 let sumArray =
  results
  |> Seq.map (fun item -> item.Value)
  |> Seq.fold (fun acc elem -> acc + elem) 0


