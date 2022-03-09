* Context is environement under which formulat is evaluated.

Filter Context
----
* set of filters applied for the cell to caculate
* Filter context is added when you specify filter constraints on the set of values allowed in a column or table,
* Can be modified by the functions like CALCULATE().
* Follows the one to many relationships automatically.
* Bidirectional filtering can be forced.
* Another way to think is the filter context, is set of single column table and all the values of that column that engine considers visible to the context.All of these filters put in logical AND forms the filter context.

Row Context 
----
* It always contain a single row 
* Exists in calculated columns.
* Exists in special DAX functions like SUMX and FILTER.
* Does not follow relationship.
* A row Context does not create a filter context.
* row that is used to perform the operation, that is not stored inside the formula

* It is created for caculated columns, 
* It inlcudes the values from all columns of the current rows
* There are functions that iterates calculation over the table, so they have multiple row context
* for each, Ealier which gets the row context of previous operation

Context Transition
---

 In Calculate and CalculateTable, the row context is converted into equivalent filter context.
 * For aggregate functions that does not have notion of rowwise operation, it operates on entire table restricted by filter.
 * For aggregate functions within Calculate, Context Transition take palce, hence the columns mentions in the rows are added to the filter context.So unless filter is modified within calculate,it only operates for the row.

```dax
EVALUATE SELECTCOLUMNS ( 
Filter(Sales, [ProductId] IN {1,2,3,4} ),
"Productid" , Sales[ProductId],
"YearMonth" , 
 YEAR(Sales[OrderDate]) ,

"SumOf Qty" , Sum(Sales[Qty]),
"SumX of Qty", SumX ( sales,Sales[Qty] ),
"SumOf Cal of Qty", Calculate ( Sum(Sales[Qty])),
"SumX Of Cal of Qty", Calculate (  SumX ( sales,Sales[Qty] ))

)
```

---------------------
point to remember
----
* Dax Columnal DB, it applies the filter to the column only not entire table
* When Analysing the formula,check how individal function is evaluated.
* Deduce what should be the filter context, in which it will execute.
* 