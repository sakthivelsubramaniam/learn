
param([ Object[]] $tableFormat)
begin {
   
  $psObject1 =  $tableFormat | ConvertFrom-String
  $header =  $psObject1 | select-object -first 1 
  $headerProperties = $header.psobject.Properties 
}
process {
    
    function CreateNewObject($row) {
        $n = New-Object -TypeName PSObject
        $headerProperties | 
        ForEach-Object {
             Add-Member -InputObject $n `
                -MemberType NoteProperty `
                -Name $_.Value `
                -Value $row.PSObject.Properties[$_.Name].Value
        }
        $n
    }

    $psObject1 | 
    Select-object -skip 1 | 
    ForEach-Object { CreateNewObject $_  }
}
end{}





