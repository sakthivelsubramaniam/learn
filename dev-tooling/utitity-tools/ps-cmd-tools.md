# Utility Tools

## PowerShellGet

- It is the package manager for Powershell.
  
( https://git-scm.com/book/ms/v2/Appendix-A%3A-Git-in-Other-Environments-Git-in-Powershell)[ url here]


## Posh-Git 

 - Git in powershell environement, provides tab completion facilities.
  (https://github.com/dahlbyk/posh-git)[Post Git]


### Install Posh Git

* Setup the execution policy.

```powershell

Set-ExecutionPolicy -Scope LocalMachine -ExecutionPolicy RemoteSigned -Force

 # import Posh 
 Install-Module Posh-Git 
 Add-PoshGitToProfile -AllHosts
 Add-PoshGitToProfile -AllUsers

```

## Clink

(http://mridgers.github.io/clink/)[url]
