// npm install rxjs
import { Observable} from 'rxjs'
import { of } from 'rxjs';
import { map } from 'rxjs/operators';

console.log("Ex1: Basic flow")
// observable
const observable = new Observable(subs => {

		subs.next(1);
		subs.next(33);
		subs.next(41);
});

const observer = {
	next(x) { console.log("value is " + x)},
	error(e) { console.log(" error is " + e)},
	complete() { console.log (" done")}
};

const subscription = observable.subscribe(observer);
subscription.unsubscribe();

console.log("Ex1: end");
//----------------
console.log("Ex2: With cleaning up");

const observable2 = new Observable( subs => {
 subs.next(1);
 const intervalId = setInterval(() => {
   subs.next(98);
 },3000);

 return function unsubscription() {
  clearInterval(intervalId);
 }
});

const subscription2 = observable2.subscribe(
	  x => console.log(x),
	  e => console.log(e)	
		);
subscription.unsubscribe();
console.log("Ex2: Done");

//----------------
console.log("Ex3:");
const observable3 = new Observable( subs => {
	subs.next(1);
	const intervalId = setInterval(() => {
		subs.next(98);
	},3000);

 return function unsubscription() {
  clearInterval(intervalId);
 }

});

const subscription3 = observable3.subscribe(
	  x => console.log(x),
	  e => console.log(e)	
		);
subscription3.unsubscribe();

// setTimeout( subscription2.unsubscribe(), 10000);
console.log("Ex3: Done");

console.log("##########")
console.log("Ex4: pipe operation");
 of(1,3,4)
 .pipe(map( (x) => x + 10))
 .subscribe(observer);

console.log("Ex4: Done");

console.log("##########")
