// Importing everything from the exportedFile.ts module
// Import all is indicated using 'import *' 
// and here 'as' keyword 
import * as importAll from "./ex2-exportedFile";
let user = "Geeks";
  
// Calling the imported function
console.log(importAll.sayHello(user));
  
// Implementing the imported interface
class hru implements importAll.howareYou {
    howareyou(user: string){
        return "How are you "+user+"!";
    }
}
  
// Calling the implemented function in the 
// Interface which is imported
let jd = new hru();
console.log(jd.howareyou(user));
  
// Creating the object of the imported class
// and calling it's function
let bye = new importAll.sayGoodByeTo();
console.log(bye.goodbye(user));
