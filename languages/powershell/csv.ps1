
# import csv converts the csv to dictionory
$groups = Import-Csv -Delimiter "," -Path ".\resources\group.csv"

$groups | Select-Object {_$.Name}

#exports the array of object to csv

class CsvRow {
    [object] ${SourcePath}
    [object] ${TargetPath}
  }
  
  $array = @()
  foreach ($ndx in 1..10) {
 
    $rowObj = [CsvRow]::new()
     $rowObj.SourcePath = $sfiles[$ndx] 
     $rowObj.TargetPath = $sfiles[$ndx] 
     $array += $rowObj
  }
  
$array |  Export-Csv $work\new.csv -NoTypeInformation