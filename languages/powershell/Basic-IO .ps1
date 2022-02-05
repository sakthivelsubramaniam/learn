

# standard console
Clear-Host
Write-host 


#create folder
new-item -path "D:\temp\test1" -ItemType "Directory"

#create file
New-Item -Path 'D:\temp\test1\Test File.txt' -ItemType File

#copy folder/files
copy-item 'D:\temp\test1' 'D:\temp\t1'

#delete folder/files

remove-item 'D:\temp\t1' -Recurse

#moveing folder/files
new-item -path "D:\temp\t1" -ItemType "Directory"
move-item 'D:\temp\t1' 'D\temp\t3'

#rename the folder/files
Rename-Item D:\temp\Test D:\temp\Test1

#check the existing
test-path 'D:\temp\test1\Test File.txt'

#resolve the path of file
resolve-Path -path '.\resources\sample.xml'

#joins the path
Join-Path -Path "path" -ChildPath "childpath"

#retrieve item
get-content 'D:\temp\test1\Test File.txt'

#set the content
Set-Content 'D:\temp\test.txt' 'Welcome to TutorialsPoint'

#create a text file
New-Item D:\temp\test\test.xml -ItemType File

#clear the content file
Clear-Content "Path" 

#append the content file
Add-Content D:\temp\test\test.txt 'World!'

 ## Registry
 #gets the items in registry
 Get-Childitem hklm:\

 
#write warning
Write-Warning "warning : "


#write host
Write-host "test"
Write-Host (2,4,6,8,10,12) -Separator ", -> " -ForegroundColor DarkGreen -BackgroundColor White



#output 
Get-ChildItem c:\windows\system32 | Format-Table

Get-ChildItem c:\windows\system32 | Format-List
 
Get-ChildItem c:\windows\system32 | Format-Wide

#Environment variables
Get-Item -Path Env:*
