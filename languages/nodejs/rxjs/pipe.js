import { Observable} from 'rxjs'
import { of } from 'rxjs';
import { map, first } from 'rxjs/operators';


const p = (x) => console.log(x);
p("##########")
p("Ex1: pipe with map");

of(1,3,4)
 .pipe(map( (x) => x + 10))
 .subscribe( console.log);

p("Ex1: Done");
p("##########")
p("Ex2: pipe with first");

of(1,3,4)
 .pipe(first())
 .subscribe(console.log);

p("Ex2: Done");

p("##########")
p("Ex3: piping more than one method");

of(1,3,4)
 .pipe(first(), map((x) => x + 10))
 .subscribe(console.log);

p("Ex3: Done");

