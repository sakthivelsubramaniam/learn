

Two types of Modules
 1. Internal Modules now it is named as namespace. 
 1. External Modules - Use for manageing the dependencies
 
To load external modules, we need a module loader.

For browser following module loaders is used
 1. Required.JS

The syntax for declaring an external module is using keyword ‘export’ and ‘import’.


```typescript
//FileName : SomeInterface.ts 
export interface SomeInterface { 
   //code declarations 
}

// to use it, following should be used.

import someInterfaceRef = require(“./SomeInterface”);

// IShape.ts 
export interface IShape { 
   draw(); 
}

// Circle.ts 
import shape = require("./IShape"); 
export class Circle implements shape.IShape { 
   public draw() { 
      console.log("Cirlce is drawn (external module)"); 
   } 
} 

// Triangle.ts 
import shape = require("./IShape"); 
export class Triangle implements shape.IShape { 
   public draw() { 
      console.log("Triangle is drawn (external module)"); 
   } 
}
   
// TestShape.ts 
import shape = require("./IShape"); 
import circle = require("./Circle"); 
import triangle = require("./Triangle");  

function drawAllShapes(shapeToDraw: shape.IShape) {
   shapeToDraw.draw(); 
} 

drawAllShapes(new circle.Circle()); 
drawAllShapes(new triangle.Triangle()); 

```

Command to compile the typescript is 

```typescript
tsc --module amd TestShape.ts

//but check modules folder, below command to compile works
tsc ex-mainfile.js 

```
## import 

Basic syntax is 
### import default module

```typescript
import MODULE_NAME from './MODULE_LOCATION'
```

// if multiple modules are to be imported
### import named module
```typescript
import { MODULE_NAME1, MODULE_NAME2, ... , MODULE_NAMEn } from ./MODULE_LOCATION'
```
// if multiple modules are to be imported
### import  all modules
```typescript
import * as 'new module name' from ./MODULE_LOCATION'
```

### import  default modules and named values
```typescript
import DEFAULT_EXPORT, { MODULE_NAME1, MODULE_NAME2, ... , MODULE_NAMEn } 
    from './MODULE_LOCATION'

```

