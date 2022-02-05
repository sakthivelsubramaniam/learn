#string assignment
$mystring = "test"

#back trick word wrap operator `
Get-Service * | Sort-Object ServiceType `
| Format-Table Name, ServiceType, Status -AutoSize




#the Comparison Operators
# -eq, -ne , -gt, -ge , -lt , -le

#-is /-isnot checks the datatype

#-match a match using regular expression

#-contain/-notcontain  checks collections and group of items contains given item.

#-like  string comparision used with wild card * 

#logical  Operators
# -AND, -OR  and -NOT 


#boolean value
$true, $false

#for loop
for($i = 0; $i -lt $array.length; $i++){ $array[$i] }
#for each
foreach ($element in $array) { $element }

#while loop
$counter = 0;
while($counter -lt $array.length){
   $array[$counter]
   $counter += 1
}

#do while 
$counter = 0;

do {
   $array[$counter]
   $counter += 1
} while($counter -lt $array.length)

# condition
if(Boolean_expression) {
    # Executes when the Boolean expression is true
 }else {
    /# Executes when the Boolean expression is false
 }


 if (condition 1) {command}
elseif (condition 2) {command}
elseif (condition 3) {command}
else {command}


switch(Read-Host "Select a menu item"){
   1 {"File will be deleted"}
   2 {"File will be displayed"}
   3 {"File is write protected"}
   default {"Invalid entry"}
}
