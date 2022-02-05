1. Enable wls 1  if not already enabled 
 
2. Enable  virtaul machine platform if not already enable
>Enable-WindowsOptionalFeature -Online -FeatureName VirtualMachinePlatform

3. download wls 2 kernal from the net [wsl msi](https://wslstorestorage.blob.core.windows.net/wslblob/wsl_update_x64.msi) , install it and restart windows

4. Powershell in Admin mode and execute 
> wsl --set-default-version 2

5. convert the distro from WSL 1 to WSL 2 
> wsl --set-version Ubuntu 2

6. observered virtaul box version 6. does not start 

7. disables the virtual platform and restarted the machine
>disable-WindowsOptionalFeature -Online -FeatureName VirtualMachinePlatform


8. now virtual box is working. 