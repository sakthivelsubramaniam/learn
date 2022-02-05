$json = Get-Content ./resources/sample.json | Out-String | ConvertFrom-Json
$json.Storage = "value2"
$json | ConvertTo-Json | Set-Content ./resources/sample.json
