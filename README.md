# MessageBoard

Message Board API

Software built in .Net 5
App is currently using a singleton repository that simulates database, once the app is restarted all messages will disappear.

## How to run the App

#### In Visual Studio

- set the project MessageBoard.Web as startup and run pressing f5
- app will be available on https://localhost:5001

#### In the command line

- go to MessageBoard.Web folder
- run the command "dotnet build --configuration Release"
- go to MessageBoard.Web bin/release/net5.0 folder
- run command "dotnet MessageBoard.Web.dll"
- app will be available on https://localhost:5001

## Api documentation
Retrieves all messages from the memory
- GET /message return 200 OK

Saves a message in the memory
- POST /message?messageDescription={value} return 200 OK
