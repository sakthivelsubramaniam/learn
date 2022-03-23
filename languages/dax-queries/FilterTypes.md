## Filters

``` Dax
Evaluate (
	Filter ( Product, PRODUCT[Brand] = "Fabrikam"),
	 And ( <codition>, <conditionj)
)
```

### Select All
When context transition happens, there are two context is formed. 
1. Filter Context 
2. Row Context, it overwrites the filter context. 

SelectALL operates on Filter Context rather that row context.

### ALL 

``` Dax

// tables
Evaluate ALL(Product)

// fields
Evaluate ALL ( Product[Class])

// many fields
Evaluate All (Product[class], Product[Color]) 

//All Except , can exlclude the column that is not needed 

Evaluate AllExcept ( Product, product[ProductKey])

``` 
