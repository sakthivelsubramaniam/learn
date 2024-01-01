
# Language concepts

## Type Guard

## Narrowing

Processing of refining types to more specific type is called narrowing.

## Coroutines

They are computer program components that allow execution to be suspended and resumed, generalizing subroutines for cooperative multitasking. Coroutines are well-suited for implementing familiar program components such as cooperative tasks, exceptions, event loops, iterators, infinite lists and pipes.

## Parametric Polymorphism

C# Generics

## Generators

A generator is a routine that can be used to control the iteration behavior of a loop. All generators are also iterators.[1] A generator is very similar to a function that returns an array, in that a generator has parameters, can be called, and generates a sequence of values. However, instead of building an array containing all the values and returning them all at once, a generator yields the values one at a time, which requires less memory and allows the caller to get started processing the first few values immediately. In short, a generator looks like a function but behaves like an iterator.


## Primary Constructors

``` C#

public class NamedItem(string name)
{

  public string Name => name;

}
```
Parameters to the constructors are scoped in the entire body of the declaring type. They can initialize the property or fields. They can also be used as variable in method or fields and they be be passed to base constructors.

## Null Operators

### Null-coalescing operator

  if the value is null, it substitues another value
  example in C# -- ?? --

### null-coalescing assignment operator

 If the value is null, it assigns another value
  example in C# -- ??= --
  
## null-conditional operators

 It applies the member access ?. or element access ?[] only if operand evaluates to non-null otherwise it return null
  example in C# -- ?. or  ?[] --
  
## null-forgiving operator

It has compile time function, it suppress the warning when static analyses runs.
 
 example ``` !  ```
 ne