// -----------------
const R = require('ramda');

const greet = R.replace('{name}', R.__, 'Hello, {name}!');
greet('Alice');

// ----------------

const R = require('ramda');

myarray = [1,23,53,34]

for (const value of myarray) {
  console.log(value)
}

//----------------

// ramba foreach
R.forEach( item => console.log(item), myarray )

// ramba map
R.map( item => item +1, myarray)

// filter
const isEven = x => x % 2 === 0
R.filter(isEven, [1, 2, 3, 4])  // --> [2, 4]

// find
R.find(isEven, [1, 2, 3, 4]) // --> 2

//reduce
const add = (accum, value) => accum + value
R.reduce(add, 5, [1, 2, 3, 4]) // --> 15

//----------------------------------------------------