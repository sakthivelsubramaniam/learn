" _vimrc  is the config files for gvim and vim on windows 


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
 



