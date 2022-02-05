open System

// conditional structure
// if ..else
let f x = 
    if x = 1 
    then "a" 
    else "b"
let r = f 1
printfn "if else : value of r is %s" r


// match
let fm x =
    match x = 1 with
    | true -> "a"
    | false -> "b"
   
let r1 = fm 1
printfn "match () with value of r is %s" r1

// match v1
let fm1 x =
    match x with
    | 1 -> "a"
    | _ -> "b"
let r2 = fm1 1
printfn " (2) match () with value of r is %s" r1

// loop
// for-to-do (for i =1 to 100 do something i)
for i = 1 to 10 do
   printf "%i" i

 // for-in-do (for x in enumerable do something of x)
let l1 = [1..10]
for item in l1 do
  printf "%i" item

// while do (while test do something)
let mutable i =0
while i = 10 do
    printf "%i" i
    i <- i+1




