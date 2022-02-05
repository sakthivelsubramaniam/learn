// lodash library
// npm install lodash

import * as _ from "lodash";
import * as fp from "lodash/fp"

console.log("**maps and reduce ");

// display the numbers
var n = _.map([1, 2, 3], function(num){ return num * 3; });
console.log( "_ map function " +  n  );

// map transformation
n = _.map({one: 1, two: 2, three: 3}, function(num, key){ return num * 3; });
console.log( "_ map function " +  n  );


// reduce function
n =  _.reduce( [1,2,3], 
 function(acc,number) { return acc + number;}, 10 );
console.log( "reduce function " +n) ;

// right fold
var list = [[0, 1], [2, 3], [4, 5]];
var flat = _.reduceRight(list, 
  function(a, b) { 

   console.log( " right reduce  " + a) ;
   console.log( " right reduce  " + b) ;
   
   return a.concat(b);

   }, []);
console.log (flat);
console.log ("*****");

// find returns first find
console.log ("**find and filter")
var even = _.find([1, 2, 3, 4, 5, 6], function(num){ return num % 2 == 0; });
console.log (even);

// filter returns that matches the predicate
var evens = _.filter([1, 2, 3, 4, 5, 6], function(num){ return num % 2 == 0; });
console.log ( evens);

console.log ("*****");
// find where 
// console.log ("find where ");

// // findwhere
// var  mylist = [{k1:123},{k2:123}]
// var matched = _.findWhere( mylist, { k1:123 });
// console.log (" find where " + matched);


// where 
// var  mylist = [{k1:123},{k2:123}]
// var matched = _.where( mylist, { k1:123 });
// console.log ("  where " + matched);

console.log ("*****");
console.log ("**functional javascript");
// partial application
var subtract = function(a, b) { return b - a };
var fun1 = _.partial( subtract,5);
console.log ( "partial application " + fun1(20));

var fun2 = _.partial( subtract,_,20);
console.log ( "partial application with place holder " + fun2(5));

console.log ("* Compose function");

var fun1 = function(b:number) { return b * 3};
var fun2 = function(a:number) {return a + 2};
var fun3 = function() { return 2 };
var composefn = fp.compose( fun1, fun2, fun3 );
console.log ( composefn() );


