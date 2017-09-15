# dotnet-core-postgresql-boilerplate

PLEASE NOTE THIS PROJECT IS DEPRECATED AND IS RUNNING AN OLD VERSION OF DOTNET CORE. IT IS VERY LIKELY THE PROJECT WILL NOT RUN AND SHOULD NOW ONLY SERVE AS A REFERENCE FOR PROJECT ARCHITECTURE AND ORGANIZATION.

The aim of this project is to make setting up a new .NET Core MVC project as painless as possible.

## Requirements
* [Dotnet Core](https://www.microsoft.com/net/core)
* [PostgreSQL](https://www.postgresql.org/download/linux/ubuntu/)

## Technologies included:
* .NET Core
* Entity Framework Core
* PostgreSQL
* NUnit Test Framework

## Usage
To get all dependencies in the project built...
~~~~
git clone
./startup.sh
~~~~
You still have to do some leg work getting the database set up, but I've detailed how to do that in the first documentation link.  

## Documentation
Here you'll find posts I've made that walk through how this project has arrived at its current state.  

* [Setting up the server and database](https://medium.com/@mikezrimsek/setting-up-a-net-core-server-with-entity-framework-core-using-a-postgresql-database-242438f7d9c3)
* [Improving project design with layering](https://medium.com/@mikezrimsek/using-layering-to-improve-your-projects-underlying-design-b3c596f8f349)
* Adding NUnit tests (coming soon...)
