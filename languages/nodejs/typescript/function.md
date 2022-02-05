## optional parameters

*  A parameter can be marked optional by appending a question mark to its name.

```Typescript
function function_name (param1[:type], param2[:type], ?param3[:type])

function disp_details(id:number,name:string,mail_id?:string) { 
   console.log("ID:", id); 
   console.log("Name",name); 
   
   if(mail_id!=undefined)  
   console.log("Email Id",mail_id); 
}
disp_details(123,"John");
disp_details(111,"mary","mary@xyz.com");


```




## rest paramters

 * It is similar to variable arguments

```Typescript

function addNumbers(...nums:number[]) {  
   var i;   
   var sum:number = 0; 
   
   for(i = 0;i<nums.length;i++) { 
      sum = sum + nums[i]; 
   } 
   console.log("sum of the numbers",sum) 
} 

```

## default paramter

*  A parameter cannot be declared optional and default at the same time.
*  

```typescript
function function_name(param1[:type],param2[:type] = default_value) { 
}

function calculate_discount(price:number,rate:number = 0.50) { 
   var discount = price * rate; 
   console.log("Discount Amount: ",discount); 
} 
calculate_discount(1000) 
calculate_discount(1000,0.30)
```

## functional constructor

```typescript

var res = new Function( [arguments] ) { ... }.
var myFunction = new Function("a", "b", "return a * b");

```

## recursive function
Supports and it is same as javascript

## Lambda function

```typescript

( [param1, parma2,…param n] )=>statement;

// type script code
var foo = (x:number)=>10 + x 
// equavalent javascrpt code
var foo = function (x) { return 10 + x; };



```

## functional overload
Note − The function signature doesn’t include the function’s return type.

