# JD Expense Tracker

My personal expense tracker. Here, I have used ASP.Net core MVC with EJS from syncfusion. SSMS is used for the database which is created using Entity Framework.
Download Visual studio, download Entity framework tools, SQL,  and core.
Run it in on your local, Add categories and transactions, I have given the chart for the last 7 days which can be changed to any other dates
Bootstrap is used for frontend with syncfusion.





















First, it is a web app so use MVC web app while creating, go through all the folders, it will have model,controller,view,wwwroot,properties and dependencies folder.
Go to tools-> NuGet manager-> Download Entity framework core,entity framework SQl,entity framework tools(before downloading check ASP.net version, right clicking on dependencies->frameworks and ASPnetcore will get you)
Currently it is 8.0.1 so download all 3 with the same version.
Create Transaction class, category class, add some column names give datatype, pk ,fk etc.
Next step is creating ApplicationDbContext for migration, here in models first create the class , write constructor and call base class with DbContextOptions options.
Go to Program.cs where we have to register the service and it will be loaded through dependency injection.
To do that add connection string in Appsettings.json file and call the devconnection in program.cs(Tell them UseSqlServer and connection string name).
correction connection string "DevConnection": "Server=JD;Database=TransactionDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;"(JD check in ssms,database name any name that you want)
Create 2 tables in appdbcontext give custom names and dbset types as name of the model classes. 
Now build the solution, go to ssms and connect your db(copy the same connection string and give any name for the db in the connection string).
open package manager console and type Add-migration "Create Initial" this creates the db and the tables.
Migration scripts are added to project folder , next run update-Database to see it in the db.
Now time to create controller, go to controller , select controller, controller with Entity, give which model you want it to create then application db context and allow it to load.(sometimes it might give an error for that go to nuget package manager and update all the packages and repeat the above process)
If you go inside the controller you see dbcontext is created and there is api created etc
Now run the application and web page comes up, that is due to home controller index()
By default program.cs last line has what to load home i,e now in url if you put category, category will be loaded.
Next, go to sync fusion which has a lot ui packages, choose asp.net core and see the different ui, code is also available, now go to nuget packages and download syncFusionEJ2.Asp.net core
Next we have to add core tag helper in view imports inside views @addTagHelper *, Syncfusion.EJ2
Then add stylesheet  reference to the layouts in shared folder above site.css becuase it should render in the same order
 <link href="https://cdn.syncfusion.com/ej2/20.1.55/bootstrap5-dark.css" rel="stylesheet" />
 Then add script below all stylesheet   <script src="https://cdn.syncfusion.com/ej2/20.1.55/dist/ej2.min.js"></script>
 then register is added at the last line of the body
, all this can be obtained at the documentation of the syncfusion, MVC generally uses bootsrap by default
Whenever a controller is created, views are generated,ir Create,edit,update,delete and index all have .cshtml

Just google ej2 sync fusion and u will get all the code necessary for grids,rows,list,charts etc, slect ASp.net core and not MVC link https://ej2.syncfusion.com/aspnetcore/documentation/introduction (this has all the details)
Next copy and change in create.cshtml , we have 3 properties model and they get transalted here, give a unqiue id and give a description which will be showin in the UI in the placeholder andthe api in docs will show all the properties

























NuGET is like NPM where it used to donwload all the packages needed for development.For example, if you 
want to use a library like JSON.NET (Newtonsoft.Json) in your project, you can use NuGet to search for 
and install the package. NuGet will download the package files and add references to the necessary 
assemblies in your project, making it easy to start using the library's functionality.

Next check the version of ASP.net and go to tools , nuGET and install Entity framework core the same version of ASP.net, for now it is 8.0.1
Then install entity framework SQl for sql and entity framework tools for tools related


In Entity Framework, DbContext is a class that represents a session with the database and allows you to 
query and save data. It is a core part of the Entity Framework and provides an abstraction over the 
underlying database connection and operations.


This line of code defines a constructor for the ApplicationDbContext class, which inherits from DbContext. The constructor takes an argument of type DbContextOptions and passes it to the base constructor of DbContext.

Explanation of the constructor:

DbContextOptions: This parameter is used to configure the context. It contains information such as the 
database provider to use, connection string, and other options related to database access.
base(options): This calls the base constructor of DbContext with the DbContextOptions parameter,
allowing DbContext to be configured with the provided options.

Explanation of how dependency injection is used:

In this context, DbContextOptions is typically configured in the Startup class of an ASP.NET Core application,
where you specify the database provider and connection string.
When an instance of ApplicationDbContext is required (e.g., in a controller), ASP.NET Core's built-in 
dependency injection container will automatically provide an instance of DbContextOptions to the constructor, based on the configuration in Startup.
This allows ApplicationDbContext to be created with the necessary configuration without the need to 
manually instantiate DbContextOptions, promoting loose coupling and easier testing.

The connection string part Server=(localdb)\\mssqllocaldb is used to specify the server and instance of the SQL Server LocalDB that you want to connect to.

Here's a breakdown of each part:

Server: Specifies the server and instance of the SQL Server database. In this case, (localdb) is a keyword that represents the local SQL Server instance. You can also specify a named instance if you have one, such as Server=.\SQLEXPRESS for a SQL Server Express instance.

\\: The double backslash is used to escape the backslash character in C# string literals. So, \\ is interpreted as a single backslash in the actual connection string.

mssqllocaldb: This is the name of the LocalDB instance. LocalDB is a lightweight version of SQL Server that is designed for development and testing purposes. mssqllocaldb is the default instance name for LocalDB.

CategoryID Type: Since CategoryID is used as a foreign key to the Category table, its type should match the primary key type of the Category table. Assuming CategoryID in the Category table is an int, you should change the type of CategoryID in the Transactions table to int as well

The name 'Initial Create' is used by an existing migration. what does this mean
his error message indicates that you are trying to create a new migration with the name 'Initial Create', but there is already an existing migration in your project with the same name. Entity Framework Core does not allow duplicate migration names because each migration represents a unique set of changes to your database schema.

To resolve this issue, you can either choose a different name for your new migration or delete the existing 'Initial Create' migration if it's safe to do so.

To delete the existing migration, you can use the following command in the Package Manager Console:

Remove-Migration

What is windows authentication vs ssl certificate
ChatGPT
Windows Authentication and SSL (Secure Sockets Layer) certificates are both mechanisms used to secure connections, but they serve different purposes and operate at different levels of the network stack.

Windows Authentication:

Windows Authentication is a mechanism used to authenticate users or computers in a Windows domain environment.
It relies on the Windows operating system's security features to authenticate users based on their Windows credentials (e.g., username and password).
Windows Authentication is often used in applications and services that run on Windows servers and need to authenticate users against Active Directory.
SSL Certificates:

SSL Certificates are used to secure communication over the internet by encrypting data transmitted between a client and a server.
SSL Certificates are issued by Certificate Authorities (CAs) and are used to verify the identity of the server and establish a secure connection.
SSL Certificates are commonly used in web applications to secure HTTPS connections, ensuring that data exchanged between the client and server is encrypted and cannot be intercepted by attackers.
public async Task<IActionResult> Index(): This is a method declaration. It's a public method called Index that returns a Task representing an IActionResult. The async keyword indicates that this method contains asynchronous code.

{: The opening curly brace marks the beginning of the method body.

return View(await _context.Categories.ToListAsync());: This is the code inside the method body. Let's break it down further:

_context: This is a reference to an instance of a database context class. It's used to interact with the database.

_context.Categories: This represents the Categories property of the database context, which likely represents a table or collection of categories in the database.

ToListAsync(): This is an asynchronous method that retrieves all the categories from the database and returns them as a List.

await: This keyword is used to asynchronously wait for the ToListAsync() method to complete. It allows the method to pause execution until the ToListAsync() method finishes executing.

View(): This method creates a view result that renders a view to the response. In this case, it likely renders a view named "Index" and passes the list of categories retrieved from the database to the view.

return: This keyword is used to return the view result from the method.
