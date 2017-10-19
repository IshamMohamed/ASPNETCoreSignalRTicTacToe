# ASPNETCoreSignalRTicTacToe
A basic Tic Tac Toe game developed using Signal R on ASP.NET Core

## How to 
#### Server
Source code for SignalR hub is inside Server directory. 
#### Client
A client written in ASP.NET is available in Client directory - this is basically a Tic Tac Toe game.
### Build and Run
1. Clone the repository.
2. Open Server directory.
3. `dotnet build`.
4. `dotnet run` - _SignalR hub will be served in http://localhost:5000_.
5. Open Client directory.
6. `dotnet build`.
7. `dotnet run` - _TicTacToe client will be served in http://localhost:3254/Player_.
### Use the app
1. Open two browser tabs and go to `http://localhost:3254/Player`
2. In the first tab's page's input field type "x".
3. Do the same in the second tab but type "o".
4. Play and Enjoy.
##
##Contributions
I will surely appriciate to make this more stylish. 
