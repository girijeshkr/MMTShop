# Solution Structure

The solution itself has main folder for source code (`/src`) which contains below projects

# Source codes

1) -/MMTShop/MMTShop: this contains the main project
2) -/MMTShop/TestConsole: this contains the console testing project
3) -/MMTShop/DBStructureAndDataLoad.sql: This is the SQL file which can be executed as is to create all the required db schema and initial data load.
                                     (This step is not required if you use the Migrations avaialble in the MMTShop Projects) 

# How to Run:

1) Please Open the Soultion in Visual Studio
2) Please run the command "Update-Database" in Package Manager Console.
   It creates a new database named as MMTShop and all required components of it. It also inserts initial data.
   ##### Or
   Run the -/MMTShop/DBStructureAndDataLoad.sql in an existing empty MMTShop database.
3) Please set both the projects as startup projects.
4) Run the soltution.

# MMTShop/MMTShop:

It is a .NET core API project which uses EntityFramework for db integration using "Code First Approach".

"Migrations" are provided to create complete DB schema from scratch.

"ModelBuilder Extension" class is added to feed intial data for avoiding the manual insertion of data.

Please run the command "Update-Database" in Package Manager Console to build the complete database with initial data.

# /MMTShop/TestConsole:

It provides a console window to test the required 3 funtionalities.


