```dax-language
[measure]:= Calculate ( Expression, condition, conidtion)
```

* It takes the filter context and copy of it to use.
* It evaluates each filter aurgument and produces the list of valid values for each column.
* If the column has already has filter, it replaces that column with new values.
* Once the filter context is formed, it evaluates the first aurguments.
* It tansfoms the any existing row context to equivalent filter context.

* Finally it modifies the fitler context to  data model.
