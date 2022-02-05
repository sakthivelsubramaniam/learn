
## to remove the resource Group
Remove-AzureRmResourceGroup -Name learn01

 ## To Use RM deployment
New-AzureRmResourceGroupDeployment `
-ResourceGroupName learn01  `
-TemplateFile .\template.json `
-TemplateParameterFile .\parameters.json


# to remove the record in the azure about the deployment 
Remove-AzureRmResourceGroupDeployment

#