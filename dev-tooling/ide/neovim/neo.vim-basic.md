# Neo Vim

## Overview
- configuration can written using vimscript or lua script. 
- nvim can be intialized using either by init.vim or init.lua
- vimscript/lua can be written inside both init.vim/init.lua
- configuration are stored   $env:LOCALAPPDATA\nvim\init.vim

- It can point to existing vim configuration by following command in init.vim

``` vimscript
    set runtimepath^=~/.vim runtimepath+=~/.vim/after
    let &packpath = &runtimepath
    source ~/_vimrc
```
``` Powershell




