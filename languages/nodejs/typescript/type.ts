
// type is alias to declare type.
type Point = {
  x: number;
  y: number;
};
 
// 

// Exactly the same as the earlier example
function printCoord(pt: Point) {
  console.log("The coordinate's x value is " + pt.x);
  console.log("The coordinate's y value is " + pt.y);
}

// union type 
type ID = number | string;

// type and interface are similar and type can be extended by

type Animal = {
  name: string
}

type Bear = Animal & { 
  honey: boolean 
}

//liternal types
// liternals can be type in it self. 
 
const constantString = "Hello World";

// can be used in Union types
function printText(s: string, alignment: "left" | "right" | "center") {
  // ...
}
printText("Hello, world", "left");
printText("G'day, mate", "centre"); // will throu an error