


$Url = "http://localhost:5001/api/values"
#$Cred = Get-Credential
$contentType = 'application/json'


$headers = @{

}

$Body = @{ }


try { 

  $status = Invoke-WebRequest -Method 'Get' -Uri $url -Headers $headers -Body $body -ContentType $contentType -UseBasicParsing
    $status

}
catch [System.Net.WebException] {


    $respStream = $_.Exception.Response.GetResponseStream()
    $reader = New-Object System.IO.StreamReader($respStream)
    $respBody = $reader.ReadToEnd() | ConvertFrom-Json
    $respBody;

}
