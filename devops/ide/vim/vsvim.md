
<leader>  --> '/'

vsvimi
-----

vsvim configuration
1. for reloading the configuration in vs:  in command mode :source ~\.vsvimrc
2. nnoremap is normal mode non recursive map

To map vs command
```
map gr :vsc Edit.FindAllReferences<CR>

```
* :vsc is VsVim’s Visual Studio Command runner
<CR> is carriage return.

------
visual mode:
----
* to expand in both direction change direction by clicking 'o' or 'O'
* select the text - s/search pattern / replace pattern
* . is used repeat the visual mode operation.
