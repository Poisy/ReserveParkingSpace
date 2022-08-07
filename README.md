# ParkingApp

ParkingApp is a Web application where you can reserve parking spaces for a period of time and specific shifts for different users.
<br /><br /><br /><br />
![alt web-sample](https://i.ibb.co/bmr2bBZ/Screenshot-from-2022-08-07-16-44-43.png)

## Requirements:
- .NET Core 3.1 SDK;
- Microsoft SQL Server;

## How to run:
1. Create Databases in your SQL Workbench.
2. Put your connection strings in `appsettings.json`.
3. Try to build and update the databases*.
```
> dotnet build
> dotnet ef database update --project Infrastructure/ --startup-project WebUI/ --context AuthDbContext
> dotnet ef database update --project Infrastructure/ --startup-project WebUI/ --context ParkingDbContext
```
*<sub> by default, 50 users and 50 reservations will be created to show example of how a working app will look like</sub>
<br /><br /><br /><br /><br /><br />
