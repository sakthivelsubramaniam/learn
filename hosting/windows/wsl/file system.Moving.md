
The Default file configuration is as follows

* In Wsl Distros are stored in VHD 
    %userprofile%\AppData\Local\Packages\CanonicalGroupLimited.UbuntuonWindows_79rhkp1fndgsc
      .\LocalState\rootfs\

* Docker is stored in VHd, in 
    
     %USERPROFILE%\AppData\Local\Docker\wsl\data\ext4.vhdx
     %USERPROFILE%\AppData\Local\Docker\wsl\distro

* In WSL Linux mounts the windows file as  /mnt/c , /mnt/d
 for copying the file,
 
The above file location can be moved as below

 ## Moving ubuntu files
``` cmd
wsl.exe -l -v
wsl --shutdown
wsl.exe --export Ubuntu d:\temp\ubuntu.tar
wsl.exe --unregister Ubuntu
wsl.exe --import Ubuntu d:\ProgramData\ubuntu d:\temp\ubuntu.tar


```

## moving the docker desktops
``` wsl
wsl --shutdown

wsl --export docker-desktop d:\temp\docker-desk-data.tar
wsl --unregister docker-desktop
wsl --import docker-desktop  d:\ProgramData\docker-desktop  d:\temp\docker-desk-data.tar

wsl --export docker-desktop-data d:\temp\docker-desk-data.tar
wsl --unregister docker-desktop-data
wsl --import docker-desktop-data  d:\ProgramData\docker-desktop-data  d:\temp\docker-desk-data.tar

```

## to the distro
``` wsl
wsl -d ubuntu

```

## ERRORS 
``` WSL
wsl -- export docker-desktop-data d:\temp\docker-desk.data.tart

```
The above command result in eror, space should come after -- 

