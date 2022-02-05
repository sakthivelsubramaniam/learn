interface IPerson { 
	firstName:string, 
	lastName:string, 
	sayHi: ()=>string 
} 

var customer:IPerson = { 
	firstName:"Tom",
	lastName:"Hanks", 
	sayHi: ():string =>{return "Hi there"} 
}


// --------------------------------------------

// interface
interface IHello {
	hello():void;
}

var Hello : IHello = {
	hello():void { 
		console.log("Hello interface !!!") 
 } 
}
Hello.hello();

// -------------------------------------------
// union type and interface

interface RunOptions { 
	program:string; 
	commandline:string[]|string|(()=>string); 
} 
//commandline as string 
var options:RunOptions = {program:"test1",commandline:"Hello"}; 
console.log(options.commandline)  

//-------------------------------
interface namelist { 
	[index:number]:string 
}
var list2:namelist = ["John","1","Bran"]
console.log(list2);

//-------------------------------
// interface and inheritance

interface Person { 
	age:number 
} 

interface Musician extends Person { 
	instrument:string 
} 
var drummer = <Musician>{}; 
drummer.age = 27 
drummer.instrument = "Drums" 
console.log("Age:  "+drummer.age) 
console.log("Instrument:  "+drummer.instrument)
//-----------------------------------------------------

interface IParent1 { 
	v1:number 
} 

interface IParent2 { 
	v2:number 
} 

interface Child extends IParent1, IParent2 { } 

var myobj:Child = { v1:12, v2: 14}

//