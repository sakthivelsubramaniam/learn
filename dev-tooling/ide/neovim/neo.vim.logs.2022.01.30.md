
config the nvim
---
 - init.vim is configuration file for neovim
 - eecho stdpath('config') gives the path in which config should added.
 - vim-plug is plugin manager for nvim
 - :PlugInstall  will install the plugings 
 - gui nvim is Nvim-qt/fvim
 -  

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

new vim commands
-----
:Sex to browse the current directory

- use <C+q> to enter the block mode.


