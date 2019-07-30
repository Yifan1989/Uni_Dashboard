# Uni_Dashboard

Full stack project.
Front end: Angular 8; Back end: ASP.NET

1. sql server
  (1) install Docker, Kitematic and Azure Data Studio
    Docker is running, Kitematic is running and use Azure Data Studio to manage the database.
    Docker is used for MAC only which provides a kind of VM.
    Kitematic is a desktop tool to create sqlserver.
    Azure Data Studio is a database system management app, which can login the server(with username and password from Kitematic)
  (2) connectionstrings in appsettings.json file, providing database name and password
  (3) ApplicationDbContext.cs file is a class used to communicates with the database
      in the startup.cs file, we added the service, which is used to communicates with the database, and the connection string is "DefaultConnection" in the appsettings.json file
  (4) Use EF Migrations to build a db in Azure
    (a) cd Uni_Dash and """ dotnet ef migrations add InitialCreate """
    (b) then there will be a folder called Migrations and the first cs file is used to build the db, the tables
    (c) execute it. still the same cd, and """dotnet ef database update InitialCreate""", now we can find them in Azure
