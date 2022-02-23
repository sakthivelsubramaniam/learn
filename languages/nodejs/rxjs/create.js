// npm install rxjs
import { from} from 'rxjs'
import { of } from 'rxjs';
import { Observable} from 'rxjs'

console.log("Ex1: creating from from")
const observable = from ([33,44,55]);
const subscription = observable.subscribe(
	x=> console.log(x),
  e => console.log(e)
);
subscription.unsubscribe();
console.log("Ex1:Done");

// creating observable by subscribers
console.log("Ex2: creating from subscribers")
const observable2 = new Observable(subs => {
  subs.next("first");
  subs.next("second");
  subs.next("thrid");
});
const subscription2 = observable2.subscribe(
	x=> console.log(x),
  e => console.log(e)
);
subscription2.unsubscribe();
console.log("Ex2:Done");


console.log("Ex3: From of ")
 of(1,2,3) 
 .subscribe(
		x=> console.log(x),
		e => console.log(e)
	);

	console.log("Ex2:Done");
