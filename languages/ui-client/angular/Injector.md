# Injector (DI)
* creates hierarchical dependency injection system
* Each injector is assocated with Angular Providers
* Eagerly loaded modules share the injector with root module.
* Lazy loaded module associated with an instance of Injector.


There are two injectors
1. Module Injector.
2. Element Injector.

## Module Injector heirarchy
* Null Injector - top level injector tree
* Platform Injector - Created under Null Injector
* Root Module Injector - Created under PlatForm injector.
* Lazy Loaded Module Injector - Created under root module. 

### Root Module Injector
* Configured with Providers annotated in Root Module 
* Modules mentioned in Imported module.
* All the services that has ProvidedIn: root configuration in @Injectable decorator,the service includes both eagerly loaded and lazy loaded modules.



## Element Injector
* Injector for Dom Elements like components and directortives. 
* Created when application starts.
* Root Injector for Element Injector is created for root component.
* Child Injector are created for child element thus creating hierarchy. 
* 

