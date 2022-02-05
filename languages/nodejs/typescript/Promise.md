
## Basic usage
``` typescript
var promise1 = new Promise( (resolve, reject) => {
      
    })
```

*  Promise takes the executor as the paramter that contains two params
* if async call is sucessful then call resolve
* if it fails call reject


* There are three different states -   reject , pending  and fulfilled


```typescript
 

var demo = new Promise((resolve, reject) => {
// our logic goes here ..
reject();
}

demo().then( () => { console.log("success function")})
.catch((err) => { console.log("error handler")});
.finally() {
  console.log("finally called");
}

```

## Promis all
```typescript
var pAll = Promise.all([ p1, p2, ... ])
pAll.then( ( [ r1, r2, ... ] ) => {___});
```
