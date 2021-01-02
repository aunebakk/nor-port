rem SQL2X Generated code based on a SQL Server Schema
rem SQL2X Version: 1.0
rem http://sql2x.org/
rem Generated Date: 1/2/2021 3:01:27 PM
rem Template: sql2x.AzureBase.ExecuteDOSIncognito
rem From: SQL2XExtension.SQL2XExtensionCreatorCoreV0.PublishDotNetCoreLayerToAzure
"C:\Program Files (x86)\IIS\Microsoft Web Deploy V3\msdeploy.exe" ^
 -source:manifest='C:\SQL2XProjects\SolutionNorSolutionPort\ASP\Operational\SourceManifest.xml'  -dest:manifest='C:\SQL2XProjects\SolutionNorSolutionPort\ASP\Operational\DestinationManifest.xml',ComputerName='https://NorSolutionPortCore.scm.azurewebsites.net/msdeploy.axd?site=NorSolutionPortCore',UserName='$NorSolutionPortCore',Password='xxx',IncludeAcls='False',AuthType='Basic'  -verb:sync  -enablerule:AppOffline  -retryAttempts:20
