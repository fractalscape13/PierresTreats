# _Pierre's Sweet & Savory Treats_

#### _Business app for tracking relationship between treats and their flavors_, _March 27, 2020_

#### By _**Joseph Wangemann**_

## Description

This project creates an application for tracking a many-to-many relationship between treats and flavors, using authenication for adding/editing/deleting. 

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
| Allow user to view index pages without being logged in | Example: Click "All Treats"  | Output: See index list of treats  |
| Allow user to register | Example: Click "Register" and fill out form  | Output: See account page with option to log out  |
| Allow user to add, edit or delete treats and flavors | Example: Click "Add a treat"  | Output: See form to input new treat  |
| Prevent non-registered user from adding/editing/deleting | Example: Click "Delete flavor" without being logged in  | Output: See login/register form  |




## Setup/Installation Requirements
_Make sure you have these tools installed on your computer:_
*  [Git version control](https://git-scm.com/downloads)
*  [MySql](https://azure.microsoft.com/en-us/free/mysql/)
*  [Microsoft .Net Core 2.2](https://docs.microsoft.com/en-us/dotnet/framework/install/)
*  [.Net Script](https://dotnet.microsoft.com/download/dotnet-core/2.2)


_In Terminal:_


* Using your terminal navigate to where you want to save this project by typing:
```sh
cd desktop
```

* Clone the file from GitHub by typing:
```sh
git clone  https://github.com/fractalscape13/PierresTreats
```

* Navigate to the project folder by typing:
```sh
cd PierresTreats.Solution/PierresTreats
```
* Restore the project with this terminal command:
```sh
dotnet restore
```

* Create your database with this terminal command:
```sh
dotnet ef database update
```

* Then start the webserver by typing:
```sh
dotnet run
```

* Open your web browser and navigate to localhost:5000
```sh
http://localhost:5000/
```

* If your setup worked you will see a welcome page with a rainbow background. 

**Note: To exit, simply press**
```sh
Ctrl + C
```

## Known Bugs

_No known bugs._

## Support and contact details

If you have any comments or questions, please submit a pull request on my repository. 

## Technologies Used
* [_Git_](https://git-scm.com/downloads)
* [_C#_](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [_.NET Core 2.2_](https://docs.microsoft.com/en-us/dotnet/framework/install/)
* [_dotnet script_](https://github.com/filipw/dotnet-script)
* [_Asp.Net Core 2.2 MVC_](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio)
* [_Visual Studio Code_](https://code.visualstudio.com/)
* [MySQL 8.0.15](https://downloads.mysql.com/archives/community/)
* [MySQL Workbench 8.0.15](https://downloads.mysql.com/archives/workbench/)
* [Entity Core framework](https://docs.microsoft.com/en-us/ef/)
* [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
* [Identity](https://docs.microsoft.com/en-us/azure/active-directory/develop/)

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_JW_**