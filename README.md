# BlazingShop

Hello and thank you for visiting my repository!

This repository is a E-Commerce Website created with Blazor.

This is how you can run the application.

## 1. Install SQL Server & Entity Framework

Since I have used the SQL Server Express and Entity Framework Core in this application, you have to install these first.
To download SQL Server Express, click [here] (https://www.microsoft.com/en-us/sql-server/sql-server-downloads).
To install Entity Framework, type the following command in Package Manager Console:

`dotnet tool install --global dotnet-ef`

## 2. Update the ConnectionString

In the `appsettings.json` file of the Server project, you will find the connection string to connect to your database.

## 3. Update the Database

To create the database with all the seeded data, make sure to change to the Server directory of this solution.

`cd .\BlazingShop\Server`

Then you can update the database with the following command.

`dotnet ef database update`

## 4. Run the Application

Finally, run the app with the following command.

`dotnet watch run`
