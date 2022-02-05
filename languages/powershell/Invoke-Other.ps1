

#invoke -perform default action
# following cmd opens the test file
Invoke-item "D:\temp\test.txt"


#invoke-expression - evaluate the expression and invoke the cmd
Invoke-Expression  "Get-Process"


#start-porcess to run the dotnet 
Start-Process -FilePath 'dotnet' -WorkingDirectory 'D:\Resideo\titan-ufc-pronexusservice\NexusServices' -ArgumentList 'run --debug'

#start-porcess and get id to run the dotnet 
$pd1 = Start-Process -FilePath 'dotnet' -WorkingDirectory '.\' -ArgumentList 'run --debug' -PassThru
$pd1.id

#start-porcess and redirect to
$pd1 = Start-Process -FilePath 'dotnet' -WorkingDirectory '.\' -ArgumentList 'run -debug' -PassThru -Wait -RedirectStan
dardOutput d:\temp\stdout.txt -RedirectStandardError d:\temp\stderr.txt

#Start a background job
# start background process
Start-Job -ScriptBlock {Get-Process}


#Start a job by using Invoke-Command
$jobWRM = Invoke-Command -ComputerName (Get-Content servers.txt) -ScriptBlock {Get-Service winrm} -JobName "WinRM" -ThrottleLimit 16 -AsJob

#Run a script as a background job
Start-Job -FilePath "c:\scripts\sample.ps1"

#Get a process by name by using a background job
Start-Job -Name "WinRm" -ScriptBlock {Get-Process winrm}
