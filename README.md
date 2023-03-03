# MyGameDB
MyGameDB is a simple Game Database Web API built with .NET. It provides a RESTful interface for retrieving information about different video games.
This project was built as a personal project to get familiar with .NET.

# Installation
To use MyGameDB, you'll need to have .NET installed on your machine. You can download .NET from the official Microsoft website: https://dotnet.microsoft.com/download

Once you have .NET installed, you can clone this repository to your local machine using the following command:

bash
Copy code
git clone https://github.com/wongpatrick/MyGameDB.git
Usage
To use MyGameDB, navigate to the root directory of the repository and run the following command:

Copy code
dotnet run
This will start the MyGameDB Web API on your local machine, listening on port 5000.

To retrieve a list of all games in the database, make a GET request to the following URL:

bash
Copy code
http://localhost:5176/game/
This will return a JSON object containing information about all the games in the database.

To retrieve information about a specific game, make a GET request to the following URL:
