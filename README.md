# PWSched (dotnet MVC)

PWSched is a web app designed to help schedule volunteers participating in public witnessing activities.  The app is based on three simple steps:

1. Admin creates available shifts
1. Volunteers request shifts
1. Admin approves volunteers for each shift

This version of PWSched is built using only C# (.NET CORE MVC). I am working on this project and [the original PWSched](github.com/dvfleet413/PWSched), which has a React.js front end, to learn C# and javascript.

## Getting Started

### Prerequisites

* Visual Studio
* .NET Core 3.0.0 or higher
* .NET EF Core 3.0.0 or higher

### Installing

* [Install Visual Studio]()
* [Install .NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core/3.0), if not done during Visual Studio installation.
* Install necessary EF Core tools from command line  
`dotnet add package Microsoft.EntityFrameworkCore.SqlServer`  
`dotnet add package Microsoft.EntityFrameworkCore.Design`
* Fork and clone the repository
* Open in Visual Studio and build/run the app, or  
`.dot run`


## Built With

* APP.NET Core
* SQLite (will migrate to SQL Server)

## ToDo List

This app is still in development.  The following tasks still need to be completed...
* Add authentication for admins and volunteers
* Add a more efficient UI (calendar) for volunteers to find available shifts


## Author

David Van Fleet [github.com/dvfleet413](github.com/dvfleet413) - Initial Work
