# Solution Structure

The solution itself has main folder for source code (`/src`) which contains below projects

# Source codes

-/MMTShop/MMTShop: this contains the main project
-/MMTShop/TestConsole: this contains the console testing project

How to Run:

1) Please Open the Soultion in Visual Studio
2) Please run the command "Update-Database" in Package Manager Console.
   It creates a new database named as MMTShop and required components of it. It also inserts initial data.
3) Please set both the projects as startup projects.
4) Run the soltution.

# MMTShop/MMTShop:

It is a .NET core API project which uses EntityFramework for db integration using "Code First Approach".

"Migrations" are provided to create complete DB schema from scratch.

"ModelBuilder Extension" class is added to feed intial data for avoiding the manual insertion of data.

Please run the command "Update-Database" in Package Manager Console to build the complete database with initial data.

# /MMTShop/TestConsole:

It provides a console window to test the required 3 funtionalities.


