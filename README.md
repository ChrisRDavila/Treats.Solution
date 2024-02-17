# Pierre's Sweet and Savory Treats

#### This application will allow a business create a specifed user account and set up menu items (treats) and flavors to categorize these items and view lists of both

#### By Christopher Davila

## Technologies Used

* _Microsoft.EntityFrameworkCore.Design -v 6.0.0_
* _Razor Syntax_
* _C#_
* _ASP.Net Core_
* _VS Code_
* _Git Hub_
* _dotnet -entity framework_
* _MySQL_
* _CSS_
* _dot net Identity Framework_


## Description
## Pierre's Sweet and Savory Treats Application is a client based application specified for the owner of a bakery.  Using Microsoft Identity Framework, the user will be prompted to register an account if an account has yet to be created an then log into their account.  Users can view a list of treats and flavors from the home page if some have been created but until logged in the user cannot add, edit, delete or view lists that accociate the items in the database. This application uses C# and MVC structure to showcase and utilise Microsofts Identity framework to specify and authorize user mobility and navigation of its features.  Once client is finished using they can log off and another user can create an account or log in to veiw their personalized data.

## Setup/Installation Requirements


* _1. Clone this to local directory using`\$ git clone https://github.com/ChrisRDavila/Treats.Solution.git`._
* _2. Open your terminal (e.g., Terminal or GitBash) and navigate to the correct directory using `\$ cd Treats.Solution` and use command `\$ code .` to open project in vs code_
* _3. _Navigate into the Pierres Treats development directory using `\$ cd PTreats` and Create appsettings.json file in this direcorty using `\$ touch appsettings.json` to store database name, user name and password for connecting to MySQL database using this structure:_
```json
 "ConnectionStrings": 
{
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
}
```
* _3. cont'd: where [YOUR-DB-NAME] is going to be the database you create and connect (i.e. data_base), [YOUR-USER-NAME] will be your MySQL log in name and [YOUR-PASSWORD-HERE] will be your MySQL password_
* _5. Please make sure you have access to MySQL and MySQLWorkbench, download and open instance if have not already_
* _6. Navigate to project directory with `\$ cd PierresTreats` if not currently in it.
* _7. In the command line, run the command `\$ dotnet tool install --global dotnet-ef --version 6.0.0` if have not added dotnet -ef globally yet._
* _7. In the command line, run the command `\$ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0` to add Entity EFCore._
* _8. In the command line, run the command `\$ dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0` to add Identity Entity EFCore._
* _9. In the command line, run the command `\$ dotnet restore` to restore project files._
* _10. In the command line, run the command `\$ dotnet ef database update` to create data base for project to store data input._
* _11. Run `\$ dotnet build` to compile this console app without running it._
* _12. use `\$ dotnet watch run` to cycle the server and navigate to your browser for UI interface_
* _13. From Log in page follow instructions to Register an account to use this application if not registered yet, using email and password with necessary characters for proper security_
* _14. Once registered navigate to login page and login to account with registered credentials_
* _15.  Once logged user is free to navigate the website with full functianality, enter follow the prompted instructions to add a treat or flavor and continue to follow instructions to make desired relationships between flavor and treat_
* _16. As needed, continue to Add, Edit or delete entries according to desired specificatons, or view a list of associated items all accessible via hyper links and foot of page_
* _17. Once finished or if desire to create another accoount for distinct and different set up, or if another client needs to utilize the application, use create and manage link to return to log in page and log off of application_


## Known Bugs

* _no designation for admin user_
* _could use more properties for actual functionality once focus is beyond mvp with user log in_

## License
[MIT](https://github.com/ChrisRDavila/Treats.Solution/blob/main/License.txt)