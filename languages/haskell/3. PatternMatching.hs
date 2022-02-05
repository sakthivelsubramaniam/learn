
--Pattern matching
lucky :: (Integral a) => a -> String
lucky 7 = "LUCKY Seven "
lucky x = "you are not lucky"


-- function with gaurds
bmiTell :: (RealFloat a) => a -> String  
bmiTell bmi  
    | bmi <= 18.5 = "You're underweight, you emo, you!"  
    | bmi <= 25.0 = "You're supposedly normal. Pffft, I bet you're ugly!"  
    | bmi <= 30.0 = "You're fat! Lose some weight, fatty!"  
    | otherwise   = "You're a whale, congratulations!"  

-- function with gaurds with where class
bmiTell1 :: (RealFloat a) => a -> a -> String  
bmiTell1 weight height  
    | bmi <= skinny = "You're underweight, you emo, you!"  
    | bmi <= normal = "You're supposedly normal. Pffft, I bet you're ugly!"  
    | bmi <= fat    = "You're fat! Lose some weight, fatty!"  
    | otherwise     = "You're a whale, congratulations!"  
    where bmi = weight / height ^ 2  
          (skinny, normal, fat) = (18.5, 25.0, 30.0)

-- let binding
-- let <bindings> in <expression>

cylinder::(RealFloat a) => a-> a-> a
cylinder r h = 
    let sideArea = 2* pi * r * h
        topArea = pi * r ^2 
    in  sideArea + 2 * topArea  
--
fun1 :: (Integral a) => a -> a 
fun1 p1 
  | p1 < 10 = 10 - 1
  | p1 > 10 = 10 + 1
  | p1 == 10 = 10 + 1


----
-- case expression
--form
-- case expression of pattern -> result
--                    pattern -> result
--                    patthen -> result
---------------------------------------------

describeList :: [a] -> String  
describeList xs = "this is the list of " ++ case xs of [] -> "empty list"
                                                       [x] -> "singleton list"
                                                       xs -> "longer list"
