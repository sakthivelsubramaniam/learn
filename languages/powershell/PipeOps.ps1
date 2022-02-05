#child of the items
#measure-object
Get-ChildItem | Measure-Object

#compare-object
Compare-Object -ReferenceObject $(Get-Content D:\temp\test\test.txt) -DifferenceObject $(Get-Content D:\temp\test\test1.txt)

#format-list
Get-ChildItem D:\ |
 Format-list

#format-wide
Get-ChildItem D:\ |
 Format-wide

 #format-table
 Get-Process | Format-table


#where condition
Get-Service | Where-Object {$_.Status -eq "Stopped"}

#using match
Get-Service | Where-Object {$_.Name -match "^W.*c"}


#pipling
#? short cut for Where used 
Get-Service * | ?{ $_.Name -eq "WSearch"}


#foreach
100,200,300 | foreach-object -Process {$_/100} 
#%  
Get-Service * | %{ $_.Name}


#select-object
Get-Process | Select-Object -Property ProcessName, Id, WS -Last 5

#unique
"a","b","c","a","a","a" | Select-Object -Unique

#sort
Get-Process | Sort-Object -Property WS | Select-Object -Last 5


#start-sleeep
start-sleeep 10


#user intpu
$choice = Read-Host "input any char" 
$choice 

#output 
Get-ChildItem c:\windows\system32 | Format-Table

Get-ChildItem c:\windows\system32 | Format-List
 
Get-ChildItem c:\windows\system32 | Format-Wide

