# Uni_Dashboard

Still working on it.
Front end:
https://github.com/Yifan1989/Angular-front-end

Full stack project.
Front end: Angular 8; Back end: ASP.NET

1. sql server

  (1) install Docker, Kitematic and Azure Data Studio
    Docker is running, Kitematic is running and use Azure Data Studio to manage the database.
    Docker is used for MAC only which provides a kind of VM.
    Kitematic is a desktop tool to create sqlserver. //
    Azure Data Studio is a database system management app, which can login the server(with username and password from Kitematic)

  (2) connectionstrings in appsettings.json file, providing database name and password

  (3) ApplicationDbContext.cs file is a class used to communicates with the database
      in the startup.cs file, we added the service, which is used to communicates with the database, and the connection string is "DefaultConnection" in the appsettings.json file

  (4) Use EF Migrations to build a db in Azure

    (a) cd Uni_Dash and """ dotnet ef migrations add InitialCreate """

    (b) then there will be a folder called Migrations and the first cs file is used to build the db, the tables

    (c) execute it. still the same cd, and """dotnet ef database update InitialCreate""", now we can find them in Azure

    (d) If a new table needed, we have to go through from (a) to (c). After that, a new table would be found in Azure

  (5) add a file named EmployeeController.cs. It works for changing the database. see comments in the file

  (6) finally we test it by using the postman

    (a) when put and delete, we need the employee id.

    (b) all the rest is just simple(get, post).

2. Front-end now:

  (1) build a simple front end with two inputs and one button

      Tip: dont forget to import "ReactiveFormsModule" in the app.module.ts file!

  (2) done.

3. simple test: post username and passwd from Angular input to db through asp.net api

4. To do the authentication and authorization service in angular. put localstorage and db together
