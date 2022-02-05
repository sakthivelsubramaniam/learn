
/*
 Name: fnValidateDate
 Date: May,25th 2012
 parameter: DateString   - date in string
			FormatString - yyyy/dd/MM
 */
 
if exists ( select 1 from sys.objects where name like '%fnValidateDate%' and type= 'FN')
  drop function fnValidateDate
 go
 Create Function fnValidateDate ( @dateString nvarchar(10), @formatString varchar(20))
 returns int
 as 
 begin
 
	if (@formatString like ('MM/dd%') or  @formatString like ('dd/MM%'))
	begin
	declare @pos2 int	 
		set @dateString = case when len(substring( @dateString,1, PatIndex('%[/-]%',@dateString)-1)) < 2 
							then '0' +@dateString else @dateString end

		set @pos2 = (patindex('%[/-]%', substring(@dateString,4, len(@dateString)-4))+ 4 -1)  
		set @dateString =  case when len(substring(@dateString,4, @pos2 -4)) < 2 then 
				substring(@dateString,1,3)+ '0' + substring(@dateString,4, @pos2 -4) + substring(@dateString,@pos2, len(@dateString)-@pos2) 
				else @dateString end
	end		

			
	 
	declare  @formatspec varchar(4) , @datepart varchar(4), @datepartvalue int
	declare  @MM int, @dd int, @yyyy int, @hh int,@mmm int, @ss int, @sss int


	declare @index int, @sindex int
	declare @ch char, @pch  char, @substr varchar(5)

	select @index = 1, @sindex = 1
	set @pch = ''
	while ( @index  <= len(@FormatString))
	begin
		
		set @ch = substring(@FormatString,@index,1)
		if (@pch != @ch)
		begin
			if(@pch not in ('\','-', '/', ' ','.',':'))
			begin
				set @formatspec	= substring(@FormatString,@sindex,(@index- @sindex) )
				set @datepart 	= substring(@dateString,@sindex,(@index - @sindex))
				goto ExtactDataPart
				sprocess:			
			
			end 
			set @sindex = @index 
		end 
		set @pch = @ch
		set @index = @index + 1
	end 
		set @formatspec	= substring(@FormatString,@sindex,(@index- @sindex))
		set @datepart 	= substring(@dateString,@sindex,(@index- @sindex))
		goto ExtactDataPart		
				
	validateDate:
	--select @YYYY,@MM,@DD,@hh,@mmm,@ss,@sss

	 if(@YYYY < 0) 	return -1
	 if(@MM > 12)	return -2
	 if(@DD > 31)	return -3
	 if(@hh > 24)	return -4
	 if(@mmm > 60)	return -5
	 if(@ss > 60)	return -6
	 if(@sss > 999) return -7
	
	 if(@YYYY%4 > 0  and @MM = 2 and @dd > 28) return -3
	 if(@YYYY%4 = 0  and @MM = 2 and @dd > 29) return -3
	 if(@MM in (2,4,7,9,11) and @dd	> 30) return -3

	goto ExitFuc

	ExtactDataPart:
		if (@formatspec = '') goto sprocess
		if (isnumeric(@datepart) = 0) return -8
		set @datepartvalue = cast(@datepart as int)
		
		if(@formatspec = 'MM'  COLLATE SQL_Latin1_General_CP1_CS_AS)
			set @MM = @datepartvalue
		else if (@formatspec = 'mm'  COLLATE SQL_Latin1_General_CP1_CS_AS)
			set @mmm = @datepartvalue
		else if (@formatspec = 'yy' )
			set @yyyy = 2000 + @datepartvalue
		else if (@formatspec = 'yyyy' )
			set @yyyy = @datepartvalue
		else if (@formatspec = 'dd' )
			set @dd = @datepartvalue
		else if (@formatspec = 'ss' )
			set @ss = @datepartvalue
		else if (@formatspec = 'sss' )
			set @sss = @datepartvalue

		
	if( @index  <= len(@FormatString))
		goto sprocess
	else
		goto validateDate

	ExitFuc:
	 return 1
end -- end of function 

/*
 -- unit test
	if ( dbo.stfValidateDate('2012/02/28', 'yyyy/MM/dd' ) < 0) select 'Normal case, test should pass'
	if ( dbo.stfValidateDate('2012/11/31', 'yyyy/dd/MM' ) > 0) select 'Month day interchange'
	if ( dbo.stfValidateDate('2012/31/04', 'yyyy/dd/MM' ) > 0) select 'April cannot have 31 days'
	if ( dbo.stfValidateDate('04/30/2012', 'MM/dd/yyyy' ) < 0) select 'Normal case, test should pass'
	if ( dbo.stfValidateDate('4/30/2012', 'MM/dd/yyyy' ) < 0) select 'Normal case, test should pass'
	
	
	if ( dbo.stfValidateDate('22:55', 'hh:mm' ) < 0)	select 'Hourse min'
	if ( dbo.stfValidateDate('2255', 'hhmm' ) < 0)	select 'Hourse min'
	if ( dbo.stfValidateDate('2262', 'hhmm' ) > 0)	select 'Has invalid minutes part'
	
 */