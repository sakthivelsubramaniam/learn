var var1 = new Number(200.34234);

console.log("var1.toFixed() is "+var1.toFixed()) 
console.log("var1.toFixed(2) is "+var1.toFixed(2)) 
console.log("var1.toFixed(6) is "+var1.toFixed(6))

//Returns a string representing a Number object in fixed-point or exponential notation
var num = new Number(7.123456); 
console.log(" num.toPrecision() : " + num.toPrecision()); 
console.log(" num.toPrecision(1) : " + num.toPrecision(1)); 
console.log(" num.toPrecision(2) : " + num.toPrecision(2));

console.log( var1.toExponential());
console.log( var1.toLocaleString());
console.log( var1.toString()); 
console.log( var1.valueOf()); 


console.log("Maximum value that a number variable can hold: " + Number.MAX_VALUE); 
console.log("The least value that a number variable can hold: " + Number.MIN_VALUE); 
console.log("Value of Negative Infinity: " + Number.NEGATIVE_INFINITY); 
console.log("Value of Negative Infinity:" + Number.POSITIVE_INFINITY);
console.log(" Not a number:" + Number.NaN);

