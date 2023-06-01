## Visual studio with vs code binding and vs vim enabled

| operation| shortcuts |
|---|---|
|  line duplicate | (vs) Ctrl + d |
|                 | (vs code) Ctrl + Shift + [arrows] |
| ||
|  line move |  Alt +  up/array arrow |
|  Copy and Past | Ctrl + C and Ctrl + V |
| **Fold/ unfold**||
| Fold  | (vs) Ctrl + m |
| | (vs code) Ctl K , Ctrl + 0 (zero) )| 


## Vs Specific
| operation| shortcuts |
|---|---|
|   open the Solution Explorer |  Ctrl + Shift + L |
|   build | Ctrl + b |

## vscode specific 
| operation | shortcuts |
|---|---|
|||             


## horizonatal navigation
|cmd|description|
|---|---|
|h | left arrow|
|l | right arrow|
|j | move downwards|
|k | move upwards|
|w | move to next word being|
|b | move to previous word |
|e | move to end of the word | 
| 0 | move to beging of the line |
| $ | move to end of the line |
|dd | delete the lines|
|x | delete the letter |
|X | similar to backspace |
| o | insert a new line |
| O | insert a new line above the current line |
| > | Indent |
| < | outer |

## Paragraph navigation
|cmd | description |
|---|---|
| { | go to begining of the para |
| } | go to end of the para |

## screen navigation
|cmd | description |
|--- | --- |
|H | first line of the current screen |
|M | middle line of the current screen |
|L | last line of the current screen |
| n cmd | n times the operation, example 10j goes downwards|

## file navigation
|cmd | description |
|--- | --- |
|gg | go to begining of the file |
|G  | go to end of the file |

## Search Navigation
|cmd | description |
|---|---|
| f{char} | find the first occurance of char|
| ; , | repleat forward and backward |
|/<pattern> | search the pattern that will take next occurence of it |
| ?<pattern> | search the pattern that will take the prev occurance of it |
| * | go to next occurance of the current word |
| # | go to previous occurrance the current work under cursor |
|(esc to normal mode) n | go to next match |
| N | go the previous match |
  
 ## Visual mode 
|cmd | description |
|---|---|
| v | go to visual mode  |
| shift+ V | line selection |
| ctrl + v | block, will not work in both vs and vs code |
|(vs)  alt + mouse selection | block selection|
|(vs-code)  alt + shilf + mouse selection | block selection|
| ctrl + alt + up/down arrow | block selection|
|(vscode)  ctrl + d |  add multi curosr to next selected text |
|(vs)  alt + shift + . |  add multi curosr to next selected text |
|(vscode) ctrl + shift + l |  add multi curosr to selected text |
|(vs)  alt + shift + ;|  add multi curosr to selected text |


## operator count motion and operator 
| operators | d, p, y, g~ - toggle the caps , c  |
|---|---|
| [oper][motion] | operation and motion|
|  y$| copy cursor to end of line |
| y^ | copy cursor to begining of line |
| y% | copy to char that matches { |
| dj | delete current and next line |
| yj | copy current and next line |
| d4j | delete 4 line down |
| d4k | delete 4 line top |
| y4j | copy 4 line down |
| yf' | copy from current cursor to ' |
| d/hello | delete every thing till first occurant of hello |
| daw | delete a word |
| diw | delete a word |
| das | delete a sentence |
| dal | delete a letter |
| dap | delete a para |
| dap | delete a block () aw
| daP | delete a block {} |
| dat | delete a tag h|
| yi" | copy inside quotes |
| ya" | copy with quotes |
| ya( | copy inside the () | 
| >[motion]| Indent the range specified my motion|
| <[motion]| outer the range specified my motion |
             


## repeat the operation
| . | repeat the last operation|

## editor
| cmd | description |
|--- | ---|
| ctrl + shift + e | come out of editor |
| <C +W + q > | will quite the editor if nothing to save |
| 
