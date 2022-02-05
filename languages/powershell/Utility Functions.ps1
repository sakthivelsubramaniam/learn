

#Dates
#get dates
Get-Date -DisplayHint Date

#get time
Get-Date -DisplayHint Time

#modifiy dates
set-date -Date (Get-Date).AddDays(1)


#String convertion
#converts the string output into powershell objects
docker images | ConvertFrom-String | select { $_.P1}