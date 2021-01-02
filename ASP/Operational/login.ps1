# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 1/2/2021 7:13:44 PM
# From Machine: DESKTOP-BP3OHLH
# Template: sql2x.PrototypeDotNetCoreTwoOoneV3.Content_loginDOTps1
if (Test-Path ('{0}/azure-credentials.json' -f (Get-Location)))
{
    $Null = Import-AzureRmContext -Path ('{0}/azure-credentials.json' -f (Get-Location))
    Try
    {
        Get-AzureSubscription
    } Catch {
        Login-AzureRmAccount
        Save-AzureRmContext -Path ('{0}/azure-credentials.json' -f (Get-Location))
    }
} else {
    Login-AzureRmAccount
    Save-AzureRmContext -Path ('{0}/azure-credentials.json' -f (Get-Location))
}
