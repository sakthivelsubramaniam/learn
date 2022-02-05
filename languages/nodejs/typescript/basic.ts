
// comments

// commnets 
/*  */

// basic types

var message:string = "Hello World" 
var num:number = 12 
var boolvar:boolean = true
var nullvar = null;
var undefinedvar = undefined;

console.log(message)
console.log(num)

// ----
var val:string|number 
val = 12 
console.log("numeric value of val "+val) 
val = "This is a string" 
console.log("string value of val "+val)

// --------
// defineing union types in function parameter
function disp(name:string|string[]) { 

}

// -----------------------
// union types with arrays
var arr:number[]|string[]; 
var i:number; 
arr = [1,2,4] 
console.log("**numeric array**") 