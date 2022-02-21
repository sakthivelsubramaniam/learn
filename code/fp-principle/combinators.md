# Combinators

## overview
- Jhon Huges: Builds Program fragments from Program fragments.
examples
* map
* filter
* reduce/folds
* compose
* fmap
* pipe

## map

- other names : fmap, select, lift
- descr: Lifts the functions to elevated world
- signature: (a->b) -> E<a> + E<b> or  E<a> -> (a -> b) -> E<b>  
 

## return

- other names : return, pure, unit, yield, point
- descr: creates a elevated value from the normal value
- signature: a -> E<a>

## apply
- other names: appy, ap 
- descr: unpack a function wrapped inside a elevated value into a lifed function.   
- signature: E<(a->b)>  -> E<a> -> E<b>  
- operator: <*>  

## lift2, lift3, lift3
- descr: Combines 2 (3 o 4) elevated value using specific function
- signation: E<a>









