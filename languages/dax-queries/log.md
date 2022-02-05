* dax studio, dmv can be viewed using sql queries

```sql
-- to view the table using the following
select * from $SYSTEM.TMSCHEMA_TABLES Where [Name] = 'SubCategory'

-- to view the relationship 
select [ToTableID], [ToColumnID], [FromTableID], [FromColumnID], [IsActive]
from $SYSTEM.TMSCHEMA_RELATIONSHIPS Where [ToTableID] = 22
order by FromTableID

-- Get the name corresponding to the ToColumnID
select [ID], [TableID], [ExplicitName] from $SYSTEM.TMSCHEMA_COLUMNS where [id] = 201




```
