|command|description|
|---|---|
| **operators** ||
| logical | == ,  !=, && and || |
| relational | -eq -ne -gt -lt -le -ge |
| boolean | -o, -a, ! |
|
## Pipe line

[time [-p]] [ ! ] command [ | command2 ... ]

* Each command in a pipeline is executed as a separate process (i.e., in a subshell).
* time reserved word precedes a pipeline, the elapsed time is displayed 

## **List** 
A list is a sequence of one or more pipelines separated by one of the operators 
* ;, &, &&, or || ,
* optionally terminated by one of ;, &, or <newline>

| control operator | description |
|---|---|
| & | if the command is terminated by &, command is executed in back ground
| ; | command seperated by ;, are executed sequencially |
| command1 && command2 | command2 is executed if, and only if, command1 returns an exit status of zero. |
| command1 || command2 | command2 is executed if and only if command1 returns a non-zero exit status. |
| (list) | list is executed in sub shell |
| {list;} | list is executed in current shell |
| ((expression))| arthimatic expression |
| [[ expression ]] | conditional expression |
| **coditional expression** |
| string | = equal example [$a = $b] |
|   | !=  not equal |
| | -z checks if string size is zero |
| | -n checks if string size is non zero |
| **file test** ||
| -b | checks if file is block special fiel [-b file1]
| -c | check if file is charector special file |
| -d | check if file is directory |
| -f | check if the file is ordinary file |
| -g | check if the file group Id is set |
| -f | check if the file exists |


