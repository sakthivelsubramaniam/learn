# Calculate and Subtotals



```dax

EVALUATE SELECTCOLUMNS ( 
Filter(Sales, [ProductId] IN {1,2,3,4} ),
"Productid" , Sales[ProductId],
"YearMonth" , Sales[SalesMonth],

"SumOf Qty" , Sum(Sales[Qty]),
"SumX of Qty", SumX ( sales,Sales[Qty] ),
"CalOf SumOf Qty", Calculate ( Sum(Sales[Qty])),
"CalOf SumXOf Qty", Calculate (  SumX ( sales,Sales[Qty] )),
"CalOf SumOf Qty,All", Calculate ( Sum(Sales[Qty]) , All(sales)), 
"CalOf SumOf Qty,All with filter with row context", 
    Calculate ( 
       Sum(Sales[Qty]) ,
       All(sales), Sales[SalesMonth] = EARLIER(Sales[SalesMonth]))
)

```

--------------------
* level1
     - rowcontext : current row prodid and salesMonth
     - filterconext : productid in (1,2,3,4)  
* level2-after Calculate at Calculate first filter execution 
    - step1:inital state  
        - rowcontext:
        - filter context : productid in (1,2,3,4)
            and current row prodid and salesMonth
    - step2: first filter is applied
        - rowcontext:
        - filter context : entire table 
    - step3: second filter is applied 
        - rowcontext
        -  filter context : rows filter for current row,

-------------------------