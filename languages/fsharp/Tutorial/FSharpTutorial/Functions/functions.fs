module functions
 open System
 let myfunc a b  = 
    a + b
 let result1 = myfunc 10 15
 printf "func value %d\n" result1

 let myfunc2(a, b) = 
    a + b

 let  result2 = myfunc2(20,20)
 printf "func value %d\n" result2
