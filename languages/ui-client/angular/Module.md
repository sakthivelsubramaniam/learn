
## Modules

* NgModules - defines the moduels
* Module defines the complilation context for the components it contains. 
* Earlier angular applicaiton, provide root module app-module, which bootstrap  initial container to load. 
* Imports/ Export property : Modules Imports functionality from Exported from Other Modules.  
* declaration - Contains Components, directives and pipes  
* providers - Di container  

```ts
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
@NgModule({
  declarations: [ AppComponent ],
  exports:      [ AppComponent ],
  imports:      [ BrowserModule ],
  providers:    [ Logger ], 
  bootstrap:    [ AppComponent ] // main application view that host other views
})
export class AppModule { }
```

## Metadata

* Metadata is used during compilation process, it is used to build injector. 
* It falls into three categories
	 1. Static - (Declaration) used by compilter
	 2. runtime - Providers used by injectors at runtime to resolve the dependency.
	 3. Composability/Grouping of NgModules - Brining NgModules together using import/export arrays.

### Declaration and Imports

* selector are used to trigger the directors and pipes during compilation.
* When the template's of the components are compiled, the directive and pipes used in the templates are triggered using selectors which are determine by declaration/Imports in the ng module. 

### Providers

* List the dependencies 
* Angular registers the Providers with injectors. These services are available for injection to any components which is the child of this injector.
* Lazy loaded modules has its own injectors.
* If the Module is used as bootstraper, the injectors is root injector.

