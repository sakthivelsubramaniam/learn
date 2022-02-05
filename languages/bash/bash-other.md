|command|description|
|---|---|
| `command` | command substitution |
| ${var}| | variable value is substituted |
| ${var:-word} | if var is not set world is substituted |
| ${var:=word} | if var is not set world is substituted and var is set to new value|
| ${var:?message} | if var is not set or null, message is printed to std error |
| || 
|function ||
```markdown

Hello () {

echo "hello $1 $2"

return 10

}

Hello sakthi sara
ret=$? 


```