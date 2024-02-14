# NeoVim

* Preconfigured distribution of Neovim for C# and other langauge is **Lunar neovim**

## Install Neovim

Installed using winget

``` batch

winget install neovim

rem will open the nvim
nvim 

```

## installing Lunar Vim

### Dependencies for Lunar Vim

#### Lazy git

`winget install lazygit`

#### Powershell 7.0

`winget install --id Microsoft.Powershell --source `
### install make

install the make  
https://gnuwin32.sourceforge.net/packages/make.htm

set the path environmental variable to point to make

### Python

install pyhton using msi and installed in.  
D:\Program Files\Python312

Url for downloads: https://www.python.org/getit/  

### Lunar NeoVim 

Url: https://www.lunarvim.org/docs/installation

``` powershell
pwsh -c "`$LV_BRANCH='release-1.3/neovim-0.9'; iwr https://raw.githubusercontent.com/LunarVim/LunarVim/release-1.3/neovim-0.9/utils/installer/install.ps1 -UseBasicParsing | iex"
```

Start the lunar vim using  
`lvim`
