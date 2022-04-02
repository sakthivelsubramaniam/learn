
* setup the execution policy
```powershell

Set-ExecutionPolicy -Scope LocalMachine -ExecutionPolicy RemoteSigned -Force

 # import Posh 
 Install-Module Posh-Git 
 Add-PoshGitToProfile -AllHosts
 Add-PoshGitToProfile -AllUsers
 
  

```
