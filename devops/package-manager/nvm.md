### nvm basic cmd

```bat
nvm install [versionno]
nvm use [vesionno]
nmv list  rem list the node version available in the system
nmv  rem show if the node is running in 32 or 64 version.
```

### Issues   


Just found a workaround, looking at the comments related to antivirus protection.

I am on Windows 10, 64 bit, version 1909 (build 18363.1139)

From Start menu open Windows Security app.
Click on Virus & Threat protection tile.
In the displayed interface, choose Manage settings that is under "Virus & threat protection settings"
Turn off Real-time protection

From start menu, find Command Prompt, right click and "Run as Administrator"
run nvm install with the version you want to install. npm will properly install now. Verify with nvm use with the version, then node -v and npm -v
Go back to Windows Security app and turn real-time protection back on

-----------
