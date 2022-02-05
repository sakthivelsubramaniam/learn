#hash type
$hash = @{ ID = 1; Shape = "Square"; Color = "Blue"}

#array type
$array = @("item1", "item2", "item3")


#--------------------------------------------------

#string in single quotes, expression are not evaluated not event the special char
$mystring = "test1"   
$mystring1 = 'test $mystring `n test2'  # output is test $mystring test2
$mystring1 
 

#string in double quotes
 
 $mystring = "test1"
 $mystring1 = "test $mystring test2"  # output is test test1 test2
 $mystring1
 
 $mystring1 = "test `ntest2"  # output is test  and test2 in second line
 $mystring1
 
#string in double quotes, when objects are used 
 $MyPSObject = [PSCustomObject]@{    
  Key1 = 'Value1'
  Key2 = 'Value2'
}
 $mystring2 = "test $($MyPSObject.Key1)" # test value1
 $mystring2 


 #string with double cotes
 #$mystring = @' teat "test" '@

 #formfeed
  Write-Host "First Line `nSecond line"
 
"Every ""cake"" should cost `$5"
"Every 'cake' should cost `$5"
$var = 45 
"The value of " + '$var' + "is '$var'" 
"The value of `$var is '$var'"
"SELECT * FROM Customers WHERE Name LIKE '%JONES%'"

#string span multiple line
$myHereString = @'
some text with "quotes" and variable names $printthis 
some more text 
'@ 

#--------------------------------------------------
 #array type
 $array = @()  # empty array
 $array = @("item1", "item2", "item3","Apple")
 $array.Add("Kiwi")
 $array.Remove("Apple")
 $array.IsFixedSize


#--------------------------------------------------
# Lists
$A = 1, 2, 3, 4
$A = 1..4  
[int32[]]$myList = 1500,2230,3350,4000
$myList.Length
$myList[1] # accessing particular element
$subList = $myList[1..3]

#List comprehension
# yeilds 1 to 3
$Express = 1..3 

#------------------------
#hash type

$hash = @{ ID = 1; Shape = "Square"; Color = "Blue"}

# ordered dictionary
$hash = [ordered]@{ ID = 1; Shape = "Square"; Color = "Blue"}
# list the keys
$hash.keys
# list the values
$hash.values
# accessing particular element
$hash["ID"]
# size
$hash.Count
#updation
$hash["Updated"] = "Now"
#add new element
$hash.Add("Created","Now")
#remove the element
$hash.Remove("Updated")
$hash.GetEnumerator() | Sort-Object -Property key
#------------------------------------------------------
# PSObject - Creates a key value pair 
#          - output are not in the same order as we have created

$DirPermissions = New-Object -TypeName PSObject -Property @{

    'Key1' = "value1" 
    'Key2' = "value2"
    }
    

#------------------------------------------------------
# PSCustomObject - Creates a key value pair
#                 - outputs are in order as we have created 

$MyPSObject = [PSCustomObject]@{    
  Key1 = 'Value1'
  Key2 = 'Value2'
}

#------------------------

#get the value of single variable
$DocConnecct = get-item env:DocConnectString
$DocConnecct.Value

