
## _vimrc  is the config files for gvim and vim on windows 


|command | description |
|---|---|
|set number | line number|
|set rnu | relative number |
|set shiftwidth=4 | 
| "  | comment |
|set shiftwidth=4 |  Set shift width to 4 spaces.|
|set tabstop=4" | Set tab width to 4 columns.|
|set autoindent  |" set auto indent |
|set cursorline | " Highlight cursor line underneath the cursor horizontally.|
|set ignorecase | " Ignore capital letters during search.|
|colorscheme evening| " set the color schemeI

## plug in
Url: [PlugInstall](https://github.com/junegunn/vim-plug)


call plug#begin(has('nvim') ? stdpath('data') . '/plugged' : '~/.vim/plugged')

" Declare the list of plugins.
Plug 'tpope/vim-sensible'
Plug 'junegunn/seoul256.vim'
Plug 'autozimu/LanguageClient-neovim', {
    \ 'branch': 'next',
    \ 'do': 'powershell -executionpolicy bypass -File install.ps1',
    \ }

" List ends here. Plugins become visible to Vim after this call.
call plug#end()

after the configuring the above lines, run 
 
 ``` :PlugInstall ``` 


config the nvim
---
 - init.vim is configuration file for neovim
 - :echo stdpath('config') gives the path in which config should added.
 - vim-plug is plugin manager for nvim
 - :PlugInstall  will install the plugings 
 - gui nvim is Nvim-qt/fvim
 -  
~~~
call plug#begin('~/AppData/Local/nvim/plugged')
" below are some vim plugins for demonstration purpose.
" add the plugin you want to use here.
Plug 'joshdick/onedark.vim'
Plug 'iCyMind/NeoSolarized'

Plug 'vim-airline/vim-airline'
Plug 'vim-airline/vim-airline-themes'
call plug#end()
~~~ 
ref   
https://jdhao.github.io/2018/11/15/neovim_configuration_windows/




