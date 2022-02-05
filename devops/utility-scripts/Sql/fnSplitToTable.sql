/*-----------------------------------------
  Name : fnSplit 
  parameter : 1.StrToSplit nvarchar(1000)
			  2.seperator  char(1)
  return : table			  
 -----------------------------------------*/
 
 if exists ( select 1 from sys.objects where name like '%fnSplitToTable%' and type= 'TF')
  drop function fnSplitToTable
 go
 Create Function fnSplitToTable ( @StrToSplit nvarchar(1000), @seperator char(1))
 returns @RetTable table ( item nvarchar(50))
 as 
 begin
   
   declare @index int,@sindex int
 set @index =0
 set @sindex = 0
 
	
 set  @index = charIndex(',',@StrToSplit,@sindex)
 while(@index > 0) 
 begin
	insert into @RetTable 
	select ltrim(rtrim(substring( @StrToSplit,@sindex,(@index-@sindex)))) 
	set @sindex =  @index + 1
	set  @index = charIndex(',',@StrToSplit,@sindex)
 end 
 insert into @RetTable 
 select ltrim(rtrim(substring( @StrToSplit,@sindex,len(@StrToSplit) - @sindex + 1))) 
    
    return 
 end 
 
 /*
  --Testing 
  select * from  dbo.fnSplitToTable ('first,sec, thrid' , ',')
  select * from  dbo.fnSplitToTable ('first' , ',')
  select * from  dbo.fnSplitToTable (',' , ',')
 */