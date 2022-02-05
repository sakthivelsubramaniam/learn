|command|description|
|---|---|
| varname[0] | defines the array |
| $varname[1] | to access the array variable |
| varname = (12,123,23,3) | initializes the array |
| my_array = ( foo bar) | initializing another way |
| declare -a my_array| initializing the array|
| echo ${my_array[@]} | print all the values of array |
| echo ${my_array[*]} | print all the values of array |
| for i in "${my_array[*]}"; do echo "$i"; done | example for printing the array |
| for index in "${!my_array[@]}"; do echo "$index"; done | printing the key of array |
| echo "the array contains ${#my_array[@]} elements" | size of the arrya |
| my_array+=(baz) | appends the element to the array |
| unset my_array[1] | deletes the element of the array |
| unset my_array | deletes the entire array |

