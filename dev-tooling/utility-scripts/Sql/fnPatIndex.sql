
 
 if exists ( select 1 from sys.objects where name like '%fnPatIndex%' and type= 'FN')
  drop function fnPatIndex
 go
 
 /*
    Name: fnPatIndex
	parameter : @stringExpression - string to be searched
	@pattern : pattern to search
	@startIndex : index from where search has to take place
 */
 
 Create Function fnPatIndex (@pattern varchar(10),  @stringExpression nvarchar(100), @startIndex int = 1)
 returns int
 as 
 begin
	
	return (patindex(@pattern, substring(@stringExpression,@startIndex, len(@stringExpression)-@startIndex))
			+ @startIndex -1)
 end	
 go
  
  
 -- select dbo.fnPatIndex('%[/-]%','01-04-2001',4 )

 
  