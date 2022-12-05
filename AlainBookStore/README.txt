Class exercise 2
2022-10-10 12:30
Port commented due to college restrictions at Launch settings
startup.cs modified to clean the options, delete an error page and add the endpoint
Repo created and app testedproject with webapp esp core 3.1 individual accounts enabled for blazor

2022-10-28 12:08
found the identity context in Data/Migrations
Maybe I Need to create a new controller in startUp replacing the Home Controller but not changed at this step
downloaded the Darkly theme from bootstrap
replaced at wwwroot/lb/bootstrap/dist/css the file bootstrap previous by the new boostrap.css downloaded
Go to wwwroot > replace the existing site.css file found in the main css folder of blackboard
replaced the link at _Layout bootstrap.min.css with bootstrap.css to read the new theme
Changes the nav class from navbar-light to navbar-dark and bg-white to bg-primary
Line 23 - remove text-dark
_LoginPartial.cshtml remove references to ‘text-dark’
Application testes succesfully and commit done with those adjustments
Add to the _Layout.cshtml page the additional stylesheets and scripts from the CSS_JS.txt file
In Views/Shared/_Layout.cshtml, add a dropdown to the NavBar
Save, refresh and review the UI
Change ‘Dropdown’ to ‘Content Management
strugled with the dropdown control

2022-10-31 12:07
Style Adjustments in Layout the bootstrap property data-bs-toggle has to be replaced by data-bs-toggle to have the dropdown behaviour.

2022-11-7 12:40 
Project restarted due to 3 projects complemented with problems in context with incorrect type of project
project added .NET Core Class Library (AlainBookStore DataAcces/Models/Utility)
README copied from previous project (AlainRiveraBookStore)
Port commented due to college restrictions at Launch settings
startup.cs modified to clean the options, delete an error page and add the endpoint
New Project builded by 1st time succesfully
Layout modification to consider jQuery and bootstrap libraries
Project builded by 2nd time succesfully
Debugging brakpoints stablished and tested succesfully at index and privacy links
BootTheme Darkly added with Content Management Link into the Navbar
Project builded by 3rd time succesfully
Part 1.4 started
Repository Created and pushed
Projects Created AlainBookStore DataAccess/Models/Utility
Data folder moved from AlainBookStore to AlainBookStore.DataAccess
Installation of Microsoft.EntityFrameworkCore.Relational version5.0.11
Installation of Microsoft.EntityFrameworkCore.SqlServer Version5.0.11 in the four projects
Installed in all projects Identity.EntityFrameworkCore version 5.0.11
Models folder moved from AlainBookStore to AlainBookStore.Models
Project References into AlainBookStore to DataAccess and Models Projects
ErrorView in Models modified into the namespace to Models.ViewModels
usying directive for AlainBookStore.DataAccess.Data added to startup file in main project
removed original directive from startup.
Existing problems with ErrorViewModel references
Nugets for Relational, Identity and SqlServer downgraded but the problem still remain

2022-11-10 12:25
Second check trying to find the errorviewmodel reference and adjusting small issues like text-dark references not deleted from _Layout.cshtml in view\shared\layout
Problem solved adjusting the right reference of usying statement for ErrorViewModel
SD class created at Utility after models and dataaccess projects referenced.
The reference was incomplete in main project views/shared/Error.cshtml and it was fxed adding the right reference after moving the models folter to Models project from ErrorViewModel => AlainBookStore.Models.ViewModels.ErrorViewModel
Customer admin area created

2022-11-11 16:12
Database name modified
Change to .Database default project to add the migration
database updated
Adding Category field and migrating to Db succesfully
Created Repository and IRepository folders together with IRepository and Repository Interfaces
Updated with Repository file from blackboard
Problem with UnitOfWork due to privacy scope

2022-11-14 11:48
Public interface of IUnitOfWork
public class UnitOfWork: IUnitOfWork to connect both
Adjustment in DefaultConnection connecting the defaukt localhost reference to project database
Adding migration with problem due to project selected by defaut
Solved choosing .DataAccess project
Succesfully migration

2022-11-18 12:30
Sql syntax statements verified and database updated once checked in SQL server object explorer
Creation of Category table in .DataAccess project
Migration added to ApplicationDbContext
Usying .Models statement added in ApplicationDbContext and re-running the migration
Migration made via PM Console
New category table verified

2022-11-22 16:54
Creation of Repository and Interfaces repositories folders
Creation of classes and interfaces for: Repository, UnitOfWork, SP_Call and Category.
Typing the CRUD methods and scafolding the project.
Creation of views, index and upsert files with respective methods for CRUD operations.

2022-11-23 11:13
Implementation of methods, index, upsert files , clases and interfaces in Repository and IRepository folder
Implementation in UnitOfWork with new migrations.
Views and partial views made and link added in Navigation bar
Migration done succesfully
Project run succesfully.

2022-11-23 20:06
Delete method typed for category.js including the onclick event
Creation of CoverType Table with same method of Category Table in Models
Adding the Covertype to class, interface, unitofwork previous to migration
CRUD operations typed
Link co CoverType in Navbar
Methods, Views, Links, adjustments in index and upsert to create and update migration and database

2022-11-24 12:30
Product table created
Implementation of methods, views, link in navbar, product.js similar to CoverType.
Adjustment of table fields with respective fields for Product.
Creation of Index and Upsert _Layout
Account created at Tiny.Cloud to the right creation of products but not finished
ApiKey invalid, I need to create it at tiny.cloud
Problem expected
Running the application succesfully with expected problem
Commit done at 2022-11-25 12:47

2022-12-05 12:12
Code Validation with github base repository
ApiKey created and functional
