# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 1/2/2021 8:02:31 PM
# Template: sql2x.AzureBase.ExecutePowerShell
# From: sql2x.Azure.ExtractPassword
$username = 'emailPersonal@Second.com';
$securePassword = ConvertTo-SecureString -String 'azureActiveDirectoryPassword' -AsPlainText -Force;
$cred = New-Object System.Management.Automation.PSCredential ($username, $securePassword);
Add-AzureRmAccount -Credential $cred;
Select-AzureRmSubscription -SubscriptionName 'Free Trial'
# extract publishing password from existing web app 
# write to password file
$Xml = [xml](Get-AzureRmWebAppPublishingProfile -Format:WebDeploy -ResourceGroupName Default-Web-EastUS2 -Name NorSolutionPortCore )
$PublishProfile = $Xml.FirstChild.ChildNodes[1]   
$PublishProfile.userPWD | Out-File -NoNewline 'C:\SQL2XProjects\SolutionNorSolutionPort\ASP\Operational\WebAppPassword.txt'

