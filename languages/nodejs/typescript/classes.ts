class Greeter {
 greeting: string;

 constructor(message: string) {
   this.greeting = message;
 }

 greet() {
   console.log("Woof! Wcaoof!");
 }
}

class Animal {
 move(distanceInMeters: number = 0) {
   console.log(`Animal moved ${distanceInMeters}m.`);
 }
}

class Dog extends Animal {
 bark() {
   console.log("Woof! Woof!");
 }
}

const dog = new Dog();
dog.bark();
dog.move(10);
dog.bark();

const greeter = new Greeter("world");
greeter.greet()


class Person{ } 
var obj = new Person() 
var isPerson = obj instanceof Person; 
console.log(" obj is an instance of Person " + isPerson);
