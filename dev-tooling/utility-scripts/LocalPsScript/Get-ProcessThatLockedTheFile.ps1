
$lockedFile="C:\Windows\Microsoft.NET\Framework\v4.0.30319\Microsoft.CSharp.targets"
Get-Process | foreach{$processVar = $_;$_.Modules | foreach{if($_.FileName -eq $lockedFile){ $processVar.Name + " PID:" + $processVar.id}}}