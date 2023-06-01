 if exists ( select 1 from sys.objects where name like '%GetISD%')
     drop function dbo.GetISD

go
 create function dbo.GetISD(@utcTime datetime)
 returns datetime
 as
 begin
   return  dateadd(mi,30, dateadd(hh,5, @utcTime))
  
 
 end

go 