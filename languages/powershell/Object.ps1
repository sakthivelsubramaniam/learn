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

# other ways to add property
$MyPSObject | Add-Member -MemberType NoteProperty -Name "key3" -Value "value3"

# remove property
$myObject.psobject.properties.remove('ID')

# psobject is the hidden properties that give access to the metadata of the object

#enumerating the property
$myObject | Get-Member -MemberType NoteProperty | Select -ExpandProperty Name
$myobject.psobject.properties.name


#accessing the property
$property = 'Name'
$myObject.$property

#check for existence of the property , returns true or false
$myobject.psobject.properties.match('Key1') 

#clone of the object, It creates shallow copy of the objects
$third = [PSCustomObject]@{Key=3}
$fourth = $third.psobject.copy()
$fourth.Key = 4


