## diff between var, let and const
---
* var variables are functional scope
* const/let variables are block scope
* vaiarable declared using const cannot be modified and should contain initial value.

## An type
any : it is the supertype of all type

## Type assersion
*  converion of one type to another 
*  S can be converted to T if S is subtype of T Or T is subtype of S
*  It is not called as type casting as it is purely the compile type construct.


```typescript
// var varname = <targetType> identifier
var str = '1' 
var str2:number = <number> <any> str   //str is now of type number 
console.log(typeof(str2))
// 


```
