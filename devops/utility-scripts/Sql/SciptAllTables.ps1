﻿<# SYNOPSIS 
      Generates create scripts for all tables. 
   DESCRIPTION 
      PowerShell script using SMO to script out all tables and optional all related objects like indexes etc.  
   NOTES 
      Author  : Olaf Helper 
      Requires: PowerShell Version 2.0, SMO assembly 
   LINKS 
      SMO: http://msdn.microsoft.com/en-us/library/ms162169.aspx 
      ScriptingOptions: http://msdn.microsoft.com/en-us/library/microsoft.sqlserver.management.smo.scriptingoptions.aspx 
#> 



 
# Configuration data 
[string] $server   = ".\SQLEXPRESS";          # SQL Server Instance 
[string] $database = "Northwind";      # Database with the tables to script out. 
[string] $folder   = "D:\Temp\";          # Path to export to 
 
# Reference to SMO 
[void][System.Reflection.Assembly]::LoadWithPartialName('Microsoft.SqlServer.SMO'); 
 
Write-Output ((Get-Date -format yyyy-MM-dd_HH-mm-ss) + ": Started ..."); 
 
$srv = New-Object Microsoft.SqlServer.Management.Smo.Server $server; 
$db = $srv.Databases[$database]; 

 
# Configuration for scripting options: Which related objects should also be scripted? 
$so = New-Object Microsoft.SqlServer.Management.Smo.ScriptingOptions; 
$so.DriAllConstraints = $true; 
$so.DriAllKeys        = $true; 
$so.DriClustered      = $true; 
$so.DriDefaults       = $true; 
$so.DriIndexes        = $true; 
$so.DriNonClustered   = $true; 
$so.DriPrimaryKey     = $true; 
$so.DriUniqueKeys     = $true; 
 
$so.AnsiFile          = $true; 
$so.ClusteredIndexes  = $true; 
$so.IncludeHeaders    = $true; 
$so.Indexes           = $true; 
$so.SchemaQualify     = $true; 
$so.Triggers          = $true; 
$so.XmlIndexes        = $true; 
 

$outfile = New-Object System.IO.StreamWriter($folder + "Create_" + (Get-Date -format yyyy-MM-dd_HH-mm-ss) + ".sql"); 

# Loop over all tables. 
foreach ($tbl in $db.Tables) 
{ 
    $sb = New-Object System.Text.StringBuilder; 
    # Loop through all generated partial scripts and add them. 
    foreach ($script in $tbl.Script($so)) 
    { 
        $void = $sb.AppendLine($script); 
    } 
 
    try 
    { 
        $outfile.Write($sb.ToString()); 
        Write-Output ((Get-Date -format yyyy-MM-dd_HH-mm-ss) + ": Table $tbl.Name"); 
    } 
    catch 
    { 
        Write-Output ($_.Exception.Message) 
    } 
} 

  $outfile.Close(); 
  $outfile.Dispose(); 
 
Write-Output ((Get-Date -format yyyy-MM-dd_HH-mm-ss) + ": Finished");