# Nor-Port - Open Source

Nor-Port is a Passenger Service System written for enterprise cloud environments with user interfaces tailored for PC, Web and Mobile. It is centered around Microsoft products like SQL Server, Azure, Visual Studio, C# and TypeScript.

A major part of the code is produced by a Code Generator [sql2x](www.sql2x.org). The general idea is to use as few frameworks and dependencies as possible in order to make a product that will stand the test of time without having to be rewritten when technology shifts happens and frameworks and dependencies become incompatible.

The remaining part of code mainly consists of user interface tweaks to support new user interface trends and fads, business layer code to interact with other systems, import/export, etc. 

The example schedule and passenger data is all Latin "Lorem ipsum" Gibberish, this to take focus away from the data but most language specific data can be handled by Nor-Port.

The goal of Open Sourcing Nor-Port is to attract airlines to improve functionality and make user interfaces tailored towards more specialized businesses cases, while keeping the core sturdy enough to handle both small and large passenger bases as effective as possible on the infrastructure it runs on. 

Currently Nor-Port runs on SQL Server using only Tables, Columns and Relations, no Stored Procedures or Functions. This makes Nor-Port easily adaptable to other databases. Same with the business layer where dotNetCore under Linux is in the [pipeline](#pipeline). The business logic in the tailored code of Nor-Port is shared between dot net core's REST interface and dot net framework's SOAP interface. And the tailored user interface code stays the same as SQL2X provides the same client side proxy for REST interfaces as SOAP does.

Live [Nor-Port running under Azure](http://www.NorPort.org). In this configuration all 3 FrontEnds runs under one Azure App, SOAP/WCF & REST/ASP layer in separate instances ( with shared business layer code ) and finally a Azure SQL Database on a whichever Azure SQL server configuration suits the airline's needs.

# Nor-Port
[Nor-Port](http://www.NorPort.org) Passenger Service System - for Windows / Web and Mobile platform.

Nor-Port is a Passenger Service System System written for enterprise cloud environments with user interfaces tailored for PC, Web and Mobile.

Nor-Port is used for managing a fleet and a schedule with inventory which is either maintained manually or automatically through SOAP/REST interfaces to other systems.

Nor-Port provides full access to it's fleet, schedule and inventory with a fixed or customized API through SOAP and REST interfaces.

Nor-Port also acts as a proof of concept for a three tiered cloud based "Line-of-Business" system that features:

 - SQL Server database
 - Business layer through SOAP/WCF / REST/ASP
 - FrontEnd's consuming the SOAP/WCF layer :
   - Windows application ( Full Maintenance Capabilities )
   - Web Site ( Booking, Reporting, Charting & Maintenance )
   - Mobile Hybrid App ( Dashboard )
   - MS Test
 - FrontEnd's consuming the REST/ASP layer :
   - MS Test

Nor-Port uses no special frameworks outside of the dotNetFramework ecosystem in an effort to make it as scalable and maintainable as possible, this is made possible by using a tool to generate boiler plate code for efficient communication between layers ( SQL2X ). Since the code is bare bone C# and TypeScript it is easier to find developers to maintain / enhance the code.

# Instructions for running Nor-Port

## Visual Studio 2019
Nor-Port requires Visual Studio 2019 which can be downloaded [here](https://visualstudio.microsoft.com/vs/older-downloads/)

You will need the following WorkLoad:
 - Azure
 - ManagedDesktop
 - NetWeb

## PowerShell 5.1
Nor-Port uses PowerShell to switch environment between local development and publishing to Azure, download [here](https://docs.microsoft.com/en-us/skypeforbusiness/set-up-your-computer-for-windows-powershell/download-and-install-windows-powershell-5-1)

## Git ( Source control system used by NorPort )
Download Git [here](https://git-scm.com/downloads)

Download GitHub Command Line interface for Windows [here](https://cli.github.com/)

## Code
 - [GitHub](https://github.com/aunebakk/nor-port)
   - **GitHub CLI**: ```gh repo clone aunebakk/nor-port```
   - **Git**: ```git clone https://github.com/aunebakk/nor-port.git```
   - Compressed [zip](https://github.com/aunebakk/nor-port/archive/master.zip) file ( to unblock: ```Get-ChildItem -Path nor-port -Recurse | Unblock-File``` )

## Folder structure ( first level )
| Folder Name                           | Comment                                                                           |
|---------------------------------------|-----------------------------------------------------------------------------------|
| ASP                                   | REST (ASP) Business layer ( C# )
| Business                              | SOAP (WCF) Business layer ( C# )
| Contract                              | Contracts used by the Data, Business, Web and WinForm Layers ( C# )
| Data                                  | Data Access Layer, used by the Business Layer ( C# / Ansi SQL )
| Database                              | Visual Studio testbed to SQL Server ( Ansi SQL ) & ErWin Schema
| DatabaseManager                       | Creates and Updates the database in SQL Server, Local and Azure ( C# / Ansi SQL )
| Documentation                         | Images / license file for this document
| Information                           | General information from the SQL2X creation process
| Operational                           | Scripts to Build and Deploy this product ( PowerShell and DOS )
| Proxy                                 | WCF / SOAP client proxy used in WinForm and Web / ASP ( C# )
| Web                                   | Hybrid / Web FrontEnd's ( C# / ASP & TypeScript / JavaScript / HTML / CSS )
| WinForm                               | Windows WinForm & Installer ( C# )
| Test                                  | Unit, Integration and User Interface tests

## How to run code on local computer
Use PowerShell to rename the sql server connection string for the various projects:

 - De-Sanitize Connection

| Parameter                             | Comment                                           |
|---------------------------------------|---------------------------------------------------|
| connectionStringSQLServer             | ADO connection string to a SQL Server
| **or**                                | 
| toSQLServerLocalTrusted               | Create a trusted ADO connection string to a local SQL Server

**From PowerShell**
```
# this will insert ADO connection strings to a local trusted sql server, typical for a development environment

& '.\Operational\De-Sanitize Connection.ps1' `
   -toSQLServerLocalTrusted:$true

& '.\Operational\Environment Switch.ps1' `
   -toRemote:$false
```
 **From Visual Studio 2019**
 - Clean build
 - Run DatabaseManager to create the Database and populate it's tables
 - Select Business and Web as startup
 - Run

## How to publish to azure

Prerequisites:

| Name                                  | Comment                                               |
|---------------------------------------|-------------------------------------------------------|
| AzureRM                               | PowerShell module needed for fetching publish profile
| Azure SQL Server                      | Minimal configuration
| NorSolutionPortCore                   | Azure Web App
| NorSolutionPortBusiness               | Azure Web App
| NorSolutionPort                       | Azure Web App
| Active Directory User                 | Guest User

Use PowerShell to rename the sql server connection string and login information for the various projects:

| Parameter                             | Comment                                               |
|---------------------------------------|-------------------------------------------------------|
| azureActiveDirectoryLogin             | Azure Active Directory Login eMail
| azureActiveDirectoryPassword          | Azure Active Directory Login password
| connectionStringSQLServer             | ADO connection string to SQL Server
| **or**                                | 
| toAzure                               | Create ADO connection string to a SQL Server
| sqlServerName                         | SQL server name
| sqlServerUserName                     | SQL server user name
| sqlServerPassword                     | SQL server password

**From PowerShell**
```
# this will insert ADO connection strings to an Azure sql server and Azure Web Apps

& '.\Operational\De-Sanitize Connection.ps1' `
  -toAzure:$true `
  -azureActiveDirectoryLogin:'**email**' `
  -azureActiveDirectoryPassword:'**password**' `
  -sqlServerName:'**name**' `
  -sqlServerUserName:'''username' `
  -sqlServerPassword:'**password**'

& '.\Operational\Environment Switch.ps1' `
   -toRemote:$true
```
**The Web and Window FrontEnd's**
```
NuGet.exe restore .\SolutionNorSolutionPort.sln ( Download NuGet here: https://docs.microsoft.com/en-us/nuget/release-notes/nuget-4.9-rtm )
& '.\Operational\Restore packages.bat'
& '.\WinForm\Operational\Publish WinForm layer to ASP site install directory.bat'
& '.\Web\Operational\Get-Web-App-PublishingProfile.ps1' 
& '.\Web\Operational\Build package to disk.bat'
& '.\Web\Operational\Publish To Azure.bat'
```
At this point the FrontEnd can only be used to bring up the start page and the about box.

**The Business Layer**
```
& '.\Business\Operational\Get-Web-App-PublishingProfile.ps1'
& '.\Business\Operational\Build package to disk.bat'
& '.\Business\Operational\Publish To Azure.bat'
```
**The Database**

The web FrontEnd is responsible for creating and updating the database, so the FrontEnd needs to be published before the database can be created. 

 - https://XXX.azurewebsites.net/database
   - Database Management Create Database
   - Database Management Set Version Zero Database
   - Database Management Increase Version To Latest step by step
   - Database Management Version Object ( Should be 0.14.0 )

## Test

*Open URL to the published Hybrid/Web FrontEnd, you will find the starting point for the Windows version under Applications Tile*.

## This ReadMe
Is an top-down view of Nor-Port, starting with all user visible aspects, going through the architecture from client proxies to business layer and the database.

## The Repository
This repository ("`Nor-Port`") is where we ( NorGate ) develop the [Nor-Port](http://www.NorPort.org) product. This source code is available to everyone under the standard [MIT](https://github.com/aunebakk/nor-port/blob/master/Documentation/license.txt) license.

## DashBoard web
This is the starting page for the Web side of Nor-Port. 

<p align="center">
  <img alt="Nor-Port in action" src=".\Documentation\dashboard.web.png">
</p>

## DashBoard mobile
This is the starting page for the Hybrid Mobile side of Nor-Port. It supports portrait and landscape mode, so rotating a mobile device will change layout of tiles.

<p align="center">
  <img alt="Nor-Port in action" src=".\Documentation\dashboard.mobile.png">
</p>

## Hybrid/Web Bookings view
This view is used for navigating bookings. 

<p align="center">
  <img alt="Nor-Port in action" src=".\Documentation\flights.png">
</p>

## Hybrid/Web Product view
This is the product selection view, it allows for "Selecting" a product into a "bucket", get Details about a product or Edit a product.
<p align="center">
  <img alt="Nor-Port in action" src=".\Documentation\bookings.png">
</p>

## Hybrid/Web Detail view
The detail page allows the user to see all essential information about a product in a Web page.
<p align="center">
  <img alt="Nor-Port in action" src=".\Documentation\booking-detail.png">
</p>

## Hybrid/Web Edit page
The edit page allows the user to edit all essential information about a product in a Web page.

The user will have to Login in order to save any changes
<p align="center">
  <img alt="Nor-Port in action" src=".\Documentation\booking-edit.png">
</p>

## Windows Product Preview
The windows version features it's own installation and has access to everything Nor-Port has to offer in terms of functionality. 
<p align="center">
  <img alt="Nor-Port in action" src=".\Documentation\Windows-Flights.png">
</p>

## Windows Whiteboard
For editing all product data, including an all inclusive history of all changes done to the product. Support for Excel Copy and Paste.
<p align="center">
  <img alt="Nor-Port in action" src=".\Documentation\Windows-Booking.png">
</p>

## Languages
 - C#
 - TypeScript / JavaScript ( minimal usage of HTML5 / CSS )
 - Ansi SQL
 - PowerShell for DevOps tasks

## Software architecture
 - [Schematic Overview](https://norsolutionsql2xcore.azurewebsites.net/api/1/dashboard/DashboardArchitectureFramework)
 - sql2x.org [Code Generator](https://norsolutionsql2xcore.azurewebsites.net/sql2xIndex)
 - dotNetFramework
 - WinForm
 - Active Server Pages
 - Windows Communication Foundation

## System architecture
 - [Azure](https://norsolutionsql2xcore.azurewebsites.net/Azure)
 - SQL Server
 - Internet Information Server
 - Windows Server
 
 ## Security
 - On FrontEnd and SQL Server level. SOAP/WCF and REST/ASP services level is in the [pipeline](#pipeline).
 
## Database
Following is parts of Nor-Port's Database schema, there are more tables dealing with import and export, catalog structure, security and users.

Nor-Port uses a database handler that takes care of upgrading the database schema from one version to another, making having multiple databases at different versions manageable.
<p align="center">
  <img alt="Nor-Port DB Schema" src=".\Documentation\schema.png">
</p>

## Pipeline
 - SOAP/WCF Security / Winter 2021
 - REST/ASP Security / Winter 2021
 - Replace jQuery and Bootstrap / Summer 2021

## Feedback

* Follow [@sql2x](https://twitter.com/sql2x) and let us know what you think!
* Follow [reddit](https://www.reddit.com/r/sql2x/) and let us know what you think!
* [File an issue ( GitHub issue tracker )](https://github.com/aunebakk/nor-port/issues)
* [File an issue ( Nor-Port's own issue tracker )](https://NorSolutionPort.azurewebsites.net/DefaultIssueWithFilterLive/DefaultIssueWithFilterLiveIndex)
* Ask a question on [Stack Overflow](https://stackoverflow.com/questions/tagged/Nor-Port)

## SQL2X
Nor-Port is in large part made by an Visual Studio Extension named SQL2X. Metadata and Code from this tool is found around the codebase, indications are:
 - SchemaTemplates folders, these are .json files that directly corresponds to database tables and have no influence on how Nor-Port runs but are used by the SQL2XLite extension for further development.
 - CRUDE ( Create Read Update Delete & Extras ) folders are the direct result of SchemaTemplates .json files, i.e. automatic code generated by SQL2x, feel free to modify this code as you see fit, there are no other dependencies on this code except other layers that interact with it's methods.
 - Durian folders comes from Ansi SQL Select statements in the Data tier.
 - Operational folders contain PowerShell and Batch scripts used to recompile and republish that part of the product, our approach to CI/CD.

## License

Copyright (c) NorGate. All rights reserved.

Licensed under the [MIT](https://github.com/aunebakk/nor-port/blob/master/Documentation/license.txt) license.
