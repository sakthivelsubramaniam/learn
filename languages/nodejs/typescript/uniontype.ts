//----
console.log("Union Type") 

var val:string|number 
val = 12 
console.log("numeric value of val "+val);

console.log("type is "+ typeof(val));
val = "someString";
console.log("value of val "+val);
console.log("type is " + typeof(val));

console.log("*******") 
// --------
// defineing union types in function parameter
console.log("union types in function parameter") 

function disp(name:string|string[]) { 

}
console.log("*******") 

// -----------------------
// union types with arrays

console.log("union type of array") 
var arr:number[]|string[]; 
var i:number; 
arr = [1,2,4] 
console.log("**numeric array**") 

//----------------
