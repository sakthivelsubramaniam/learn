
$path = ".\resources\sample.xml"
$fullPath = Resolve-Path -path '.\resources\sample.xml'
[xml] $docxml = Get-Content  -Path $path 

# Expression: nodename -select all node matches e
Select-Xml -Xml $docxml -XPath  "Machine" 


# Expression: /rootnode/nodename -select all node matches nodename
Select-Xml -Xml $docxml -XPath  "/Machines/Machine" 

# Expression: //nodename -select all node matches nodename from the current node
Select-Xml -Xml $docxml -XPath  "//Machine" | 
    Select-Object {$_.Node} | 
    Format-Table

# Expression: . -selects the current node
# Expression: .. -selects the parent of current node
# Expression: @ -selects the attribute
Select-Xml -Xml $docxml -XPath  "/Machines/Machine/@test" | Select-Object {$_.Node.Value}

 #Expression: expression based on predicate
Select-Xml -Xml $docxml -XPath  '//Machine[Name="NewServer0006"]' 
 # selects the last node 
Select-Xml -Xml $docxml -XPath  '//Machine[last()]' 

 # selects based on position 
 Select-Xml -Xml $docxml -XPath  '//Machine[position()> 1]' 

# selects element that has attribute  
Select-Xml -Xml $docxml -XPath  '//Machine[@test]' 

# selects element that has attribute with specific value  
Select-Xml -Xml $docxml -XPath  '//Machine[@test="124214011"]' 

# selects wildcard match
# * matches any node
# * @* matches any attribute node
# node() matches any node any kind

# selecting several paths
Select-Xml -Xml $docxml -XPath  '//Machine|//Name' 






