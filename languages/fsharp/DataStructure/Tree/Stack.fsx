module MyStack =
    type  'a MyStack =
        | EmptyMyStack 
        | MyStackNode of 'a * 'a MyStack

    let hd = function 
        | EmptyMyStack -> failwith "empty stack"
        | MyStackNode(hd, t1) -> hd
    
    let tl = function 
        | EmptyMyStack -> failwith "empty stack"
        | MyStackNode(hd, tail) -> tail

    let empty = EmptyMyStack

    let cons hd tl = MyStackNode(hd, tl)
 
    let rec update s index value  =
        match index, s with
            | index, EmptyMyStack -> failwith "empty stack"
            | 0, MyStackNode(hd,tail) -> MyStackNode(value, tail)
            | n, MyStackNode(hd,tail) -> MyStackNode(hd, update tail (index - 1) value )   

// append
// x =1,2,3,4,5   
// y=   2,3,3,4,6,7

    let rec append sx sy =
        match sx with
            | EmptyMyStack -> sy
            | MyStackNode(hd,tail) -> MyStackNode(hd, append tail sy)  


    let rec print = function    
        | EmptyMyStack -> printf "Empty"
        | MyStackNode(hd,tail) -> 
            printf "mas %i" hd
            print tail

    //
    //append
    //maps
    //reverse
    //contains
    //folds
let stack = MyStack.MyStackNode(3,MyStack.MyStackNode(2,MyStack.MyStackNode(1,MyStack.EmptyMyStack)))
let ostack = MyStack.update stack 10 1 
MyStack.print ostack



  