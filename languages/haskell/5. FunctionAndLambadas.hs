fun1 = do 
   let var1 = 2 
   let var2 = 3 
   putStrLn "The addition of the two numbers is:" 
   print(var1 + var2) 

--fun with param
fun2 n = do 
   let var1 =3
   putStrLn "The addition of the two numbers is:" 
   print(var1 +  n) 

fun3 = print (fac 20)

--pattern matching and recursion
fac 0 = 1
fac n = n * fac (n-1)

-- gaurds
---Guards is a concept that is very similar to pattern matching. In pattern matching, we usually match one or more expressions, but we use guards to test some property of an expression.
fact :: integer -> integer 

fact n | n == 0 =1
       | n /=0 = n* fact(n -1)

--lambada expression
--print (( \x -> x+ 1) 4)

--functional composition
eveno :: Int -> Bool 
noto  :: Bool -> String 

eveno x = if x `rem` 2 == 0 
   then True 
else False 
noto x = if x == True 
   then "This is an even Number" 
else "This is an ODD number" 

main = do 
   putStrLn "Example of Haskell Function composition" 
   print ((noto.eveno)(16))

