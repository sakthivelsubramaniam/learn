
# HTTP GET 
Invoke-RestMethod -Uri https://blogs.msdn.microsoft.com/powershell/feed/ |
    Format-Table -Property Title, pubDate

# HTTP POST

$Cred = Get-Credential
$Url = "https://server.contoso.com:8089/services/search/jobs/export"
$contentType = 'application/json'

$Body = @{
    search = "search index=_internal | reverse | table index,host,source,sourcetype,_raw"
    output_mode = "csv"
    earliest_time = "-2d@d"
    latest_time = "-1d@d"
}
Invoke-RestMethod -Method 'Post' -Uri $url -Credential $Cred -Body $body -OutFile output.csv



#invoke-webmethod

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

