# Lazy Vim

- Provides easy way to configure the neo vim
- It also have a pluging manager.


## Installationl

- Bootstrap the lazy.nvim by have the following config in init.lua

`````
``` lua
local lazypath = vim.fn.stdpath("data") .. "/lazy/lazy.nvim"
if not vim.loop.fs_stat(lazypath) then
  vim.fn.system({
    "git",
    "clone",
    "--filter=blob:none",
    "https://github.com/folke/lazy.nvim.git",
    "--branch=stable", -- latest stable release
    lazypath,
  })
end
vim.opt.rtp:prepend(lazypath)

````


## lazyvim installation requirement

    winget install choco 
    choco install  mingw 
    choco install llvm
  

## Installing Lazyvim

1. clone the LazyVim Repo, Which provide starter configuration
2. remove .git directory 
3. Start NeoVim with nvim command, 

``` Powershell
  Move-Item $env:LOCALAPPDATA\nvim $env:LOCALAPPDATA\nvim.bak
  Move-Item $env:LOCALAPPDATA\nvim-data $env:LOCALAPPDATA\nvim-data.bak

  git clone https://github.com/LazyVim/starter $env:LOCALAPPDATA\nvim
  Remove-Item $env:LOCALAPPDATA\nvim\.git -Recurse -Force
``` 

## Plug manager with lazy vim 

1. Create a .lua file under lua/plugins/
2. Write the plugin spec using LazyVim declarion approach.
3. Resart NeoVim.
 
- Plugints are added declaratively to one of the files in lau/plugins/*.lua.
- You can structure the plugins by having one plugins per file or put all plugin in one file or can have multiple *.lua files. 
 
### Disable the plugin
 
``` 

return {
  -- disable trouble
  { "folke/trouble.nvim", enabled = false },
}
```









