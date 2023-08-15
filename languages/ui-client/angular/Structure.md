# Modules and Components

1. Modules
2. Component
3. Views

## Modules
* Provides a compilation context and contains components, directives and pipes

### Components

A Component consist of 

* An HTML template that declares what renders on the page
* A TypeScript class that defines behavior
* A CSS selector that defines how the component is used in a template
* Optionally, CSS styles applied to the template

* components can contain view hierarchy
* componetns are associated with a single view called host view.
* Host view can be root of view hierarchy
* Host view contains Embedded view.
* Components uses services. Service Providers are injected to components as dependecies  

## View

* Component class and Template form a view
* View hierarchy can mix components from different module.
* Components have host view, which becomes a root view, it can have multiple child view.

