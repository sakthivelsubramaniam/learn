
$path = ".\resources\sample.xml"
$fullPath = Resolve-Path -path '.\resources\sample.xml'
[xml] $docxml = Get-Content  -Path $path 

# List all the machines under machines
$docxml.Machines.Machine | Out-string

# List all the machines under machines in table format
$docxml.Machines.Machine | Format-Table 
$docxml.Machines.Machine | select-object -Property Name,IP,GUID 

#picking particular instance
$Xml.Machines.Machine |
Where-Object { $_.Name -eq 'Server0001' } |
Select-Object -Property IP

#picking particular instance using xpath
#xpath is case sensitive
$item = Select-XML -Xml $docxml -XPath '//Machine[Name="Server0002"]'
$item.Node | Select-Object -Property IP, {$_.Information.Info1}

#Write XML files
$item = Select-XML -Xml $docxml -XPath '//Machine[Name="Server0006"]'
$item.Node | Select-Object -Property IP, {$_.Information.Info1}
$item.node.Name = "NewServer0006"
$item.node.IP = "10.10.10.12"
$item.node.Information.Info1 = 'xml new attribute info'

$docxml.Save($fullPath)

#Write new  node
$item = Select-XML -Xml $docxml -XPath '//Machine[Name="Server0002"]'
$item.Node | Select-Object -Property IP, {$_.Information.Info1}

$newNode=$item.Node.CloneNode($true)

$newNode.Name = "NewServer0007"
$newNode.IP = "10.10.10.13"
$newNode.Information.Info1 = 'xml new info'

$machines = Select-XML -Xml $docxml -XPath '//Machines'
$machines.Node.AppendChild($newnode)
$docxml.Save($fullPath)

#Write removing the node
$item = Select-XML -Xml $docxml -XPath '//Machine[Name="Server0007"]'
$null = $item.Node.ParentNode.RemoveChild($item.node)
$docxml.Save($fullPath)

#convert to xml - converts any object to xml
$host | ConvertTo-XML -Depth 5 | Select-Object -ExpandProperty outerXML