# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 1/4/2021 9:17:12 PM
# Template: sql2x.AzureBase.ExecutePowerShell
# From: sql2x.AzureBase.WebAppPublishingProfileGet
$username = 'emailPersonal@Second.com';
$securePassword = ConvertTo-SecureString -String 'azureActiveDirectoryPassword' -AsPlainText -Force;
$cred = New-Object System.Management.Automation.PSCredential ($username, $securePassword);
Add-AzureRmAccount -Credential $cred;
Select-AzureRmSubscription -SubscriptionName 'Free Trial'
Get-AzureRmWebAppPublishingProfile  `
 -Name NorSolutionPortBusiness `
 -OutputFile C:\SQL2XProjects\SolutionNorSolutionPort\Business\Operational\NorSolutionPortBusiness.publishSettings `
 -Format WebDeploy `
 -ResourceGroupName Default-Web-EastUS2
