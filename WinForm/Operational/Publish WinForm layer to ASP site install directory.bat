rem SQL2X Generated code based on a SQL Server Schema
rem SQL2X Version: 1.0
rem http://sql2x.org/
rem Generated Date: 1/23/2021 6:23:51 PM
rem Template: sql2x.AzureBase.ExecuteDOSIncognito
rem From: SQL2XExtension.SQL2XExtensionCreatorCoreV0.PublishWinFormLayerToDisk
"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild.exe" ^
C:\SQL2XProjects\SolutionNorSolutionPort\WinForm\WinForm.csproj ^
 /target:clean ^
 /target:rebuild ^
 /target:publish ^
 /p:GenerateManifests=true ^
 /p:BootstrapperEnabled=true ^
 /p:IsWebBootstrapper=true ^
 /p:configuration=release ^
 /p:WebPublishMethod=Package ^
 /p:PackageAsSingleFile=true ^
 /p:Install=true ^
 /p:InstallFrom=Web ^
 /p:MapFileExtensions=true ^
 /p:PublishUrl=C:\SQL2XProjects\SolutionNorSolutionPort\Web\Install\ ^
 /p:OutputPath=C:\SQL2XProjects\SolutionNorSolutionPort\Web\Install\ ^
 /p:PublishDir=C:\SQL2XProjects\SolutionNorSolutionPort\Web\Install\ ^
 /p:InstallUrl="https://NorSolutionPort.AzureWebSites.net/Install/" 