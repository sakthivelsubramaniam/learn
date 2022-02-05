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
| o | insert a new line |
| O | insert a new line above the current line |


## Paragraph navigation
|cmd | description |
|---|---|
| { | go to begining of the para |
| } | go to end of the para |

## screen navigation
|cmd | description |
|--- | --- |
|ctrl + f | move to next screen |
|ctrl + b | move to prev screen |
|ctrl + d | move forward half screen |
|ctrl + u | move back half screen |
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
|/i | search the pattern that will take next occurence of it |
| ?i | search the pattern that will take the prev occurance of it |
| * | go to next occurance of the current word |
| # | go to previous occurrance the current work under cursor |
| n | go to next match |
| N | go the previous match |



## Visual mode 
|cmd | description |
|---|---|
| v | go to visual mode  |
| shift+ V | line selection |
| ctrl + v | block selection |

## copy and delete

|cmd | description |
|---|---|
| y | copy the selection  |
| yy | copy the line  |
| p | Normal mode- paste from the clip board  |
| d | delete |
| dd | delete the line |

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

## repeat the operation
| . | repeat the last operation|

## editor
| cmd | description |
|--- | ---|
| ctrl + shift + e | come out of editor |
| <C +W + q > | will quite the editor if nothing to save |


## tab
| cmd | description |
|--- | ---|
| :tabf | search the file in the current path and open the file |
| :tabn or gt | move to next tab |
| :tabp | move to previous |
| :tabfir | move to first tab|
| :tablast | move to last tab |
| :tabdo command | to execute the cmd in all the tabs |
| :tabm n | moves the current to  nth position |
| n gt | move to the nth tab |


## clipboard
| cmd | description |
|--- | ---|
| "<register name><command> |  syntax for the comments|
| "ayy | copies the current line to a register |
| "<register name>p | past from register |
| % | name of the current file |
| : | name of the last command |
| " | last used register |
| . | contains the last inserted text | 