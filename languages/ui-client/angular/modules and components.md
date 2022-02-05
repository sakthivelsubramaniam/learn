* NgModules - basic building block fo Angular applicaiton  
* App has a root modules to enable bootstapping and can have many feature modules  
* declaration - Contains Components, directives and pipes  
* Imports/ Export property : Modules Imports functionality from Exported from Other Modules.  
* providers - Di container  
* bootstrap - initial container to load. 

```ts
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
@NgModule({
  imports:      [ BrowserModule ],
  providers:    [ Logger ],
  declarations: [ AppComponent ],
  exports:      [ AppComponent ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
```

```plaintext
* Modules share compilation context.

```

```plaintext
### components
* components can contain view hierarchy
* View hierarchy can mix views from different module.
* Components have host view, which becomes a root view, it can have multiple child view.
* 
```
