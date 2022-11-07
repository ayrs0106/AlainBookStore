Class exercise 2
10/24/2022 12:30
Port commented due to college restrictions at Launch settings
startup.cs modified to clean the options, delete an error page and add the endpoint
Repo created and app testedproject with webapp esp core 3.1 individual accounts enabled for blazor
Continued at 28 oct 2022 12:08
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
CSS:
<link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />
JS:
<script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script src="https://kit.fontawesome.com/e19c476714.js"></script>
In Views/Shared/_Layout.cshtml, add a dropdown to the NavBar
Save, refresh and review the UI
Change ‘Dropdown’ to ‘Content Management
strugled with the dropdown control
Continued 31 oct 2022 at 12:07
In Layout the bootstrap property data-bs-toggle has to be replaced by data-bs-toggle to have the dropdown bhaviour.
Restarted 7 Nov 2022 at 12:40 
Project restarted due to 3 projects addes with incorrect type of project
project addes .NET Core Class Library (AlainBookStore DataAcces/Models/Utility)
README copied from previous project (AlainRiveraBookStore)
Port commented due to college restrictions at Launch settings
startup.cs modified to clean the options, delete an error page and add the endpoint
Project builded by 1st time succesfully
Layout modification to consider jQuery and bootstrap libraries
Project builded by 2nd time succesfully
Debugging brakpoints stablished and tested succesfully at index and privacy links
BootTheme Darkly added with Content Management Link into the Navbar
Project builded by 3rd time succesfully
Part 1.4 started
Repository Created and pushed
Projects Created AlainBookStore DataAccess/Models/Utility
Data folder copied and pasted from AlainBookStore to AlainBookStore.DataAccess
Data folder deleted from AlinBookStore
Installation of Microsoft.EntityFrameworkCore.Relational version5.0.11 and Microsoft.EntityFrameworkCore.SqlServer Version5.0.11 in the four projects
