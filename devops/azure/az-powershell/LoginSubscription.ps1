 
 ##loging to the azure account
 login-AzureRmAccount
 ##login and select the environment
 login-AzureRmAccount -Environment <env>

 ##Subscription
 Get-AzureRmSubscription


 ##Context 
 ## set the subscription in the local context
 Set-AzueRmContext -SubscriptionID <sub id>


 ##location
 Get-AzureRmLocation