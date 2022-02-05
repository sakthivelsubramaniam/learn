const R = Require('ramda')
// simple composistion1

// complement of ( ie complement of even is odd, it is like not)
const isEven = x => x % 2 === 0
find(complement(isEven), [1, 2, 3, 4,5,20,32]) // --> 2


// both and either -- it is replacement for and and or


const isEven = x => x % 2 === 0
const isDivibleBy5 = x=> x % 5 === 0

const inputArray = [1, 2, 3, 4,7,5,,20,32]
const result = R.find( R.both( isEven, isDivibleBy5 ), inputArray)  // --> 20
console.log(result)

const result2 = R.find( R.either( isEven, isDivibleBy5 ), inputArray)  // --> 
console.log(result2)

// pipelines
const multiply = (a, b) => a * b
const addOne = x => x + 1
const square = x => x * x
 
const operate = R.pipe(
  multiply,
  addOne,
  square
)
 
console.log(operate(3, 4)) // => ((3 * 4) + 1)^2 => (12 + 1)^2 => 13^2 => 169

//-----------------------------------
//compose


const multiply = (a, b) => a * b
const addOne = x => x + 1
const square = x => x * x
 
const operate = R.compose(
  square,
  addOne,
  multiply
)
 
console.log(operate(3, 4)) // => ((3 * 4) + 1)^2 => (12 + 1)^2 => 13^2 => 169
// -----------------------------------


