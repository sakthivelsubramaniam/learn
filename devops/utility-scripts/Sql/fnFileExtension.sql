

 
 if exists ( select 1 from sys.objects where name like '%fnFileExtension%' and type= 'FN')
  drop function fnFileExtension
 go
 
 /*
    Name: fnFileExtension
	parameter : @fileName - string from which the extension will be retreived
	
 */
 
 Create Function fnFileExtension (@fileName varchar(250))
 returns varchar(10)
 as 
 begin
	
	 return case when  charindex('.',@fileName) > 0 then
	 Right(@fileName,charindex('.', REVERSE(@fileName))-1)
	 else '' end  
 end	
 go
  
  
