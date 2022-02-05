#load "List.fsx"
#load "Creators.fsx"
open DataStructure

let nums = [1;2;3;4;5];
let a1 = MyList.sum nums

let a2 = MyList.sumAux 5 nums

a2

let add10 = Creators.createAdder 10

add10 32
// Define your library scripting code here
