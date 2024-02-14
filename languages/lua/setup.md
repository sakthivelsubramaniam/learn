
# Lau Langauge

## Overview 

- Used as vim language instead of vim script. It is embeded in nvim. 

- to run external script scriptfile.lau from nvim  from vim cmd prompt
```` lau
 :source fileName.lau


-  to run the lua statement from vim cmd
`:lau <space>`  prompt will change to lua: then execute lau cmds

- :lau = is equal to :lau vim.print()
- to check the variable use 
`:lau = varname`


### comments

>> --[[comments ]]--

### local variables

local i,j
local k,m = 5,10
k=20

### varies ways to print variable
--appends the value of the variable to the statement

print ("this is valirabe a:",a)

### type function 
- enables to know the type of the variable
print(type(3))

### arthimatic operation

- +,-,*,/, %, ^ 
- -variable  // uniary operator act as negation, will give oppsite sign

### relation operation

- ==,~=, >, < , >=, <= 

### string operation

-- string concatenation
local a = "hello"
local b = "world"
a..b  

-- string #length
#a

