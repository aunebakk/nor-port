# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 12/28/2020 12:12:13 AM
# From Machine: DESKTOP-BP3OHLH
# Template: sql2x.PrototypeDotNetCoreTwoOoneV3.Content_allDOTps1
# Create new .net core 2.1 project
Set-Location ..
# Fix packages
dotnet new razor# Fix packages
dotnet restore  ASP.csproj
# Build
dotnet build  ASP.csproj
# Run
dotnet publish  ASP.csproj
# Publish
# .\publish.bat
Read-Host 'Thats it'
