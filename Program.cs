using Microsoft.Extensions.Configuration;

using MySql.Data;
using MySql.Data.MySqlClient;

using TodoAPI;

// Connect to SQL server
IConfiguration config = new ConfigurationBuilder()
	.AddEnvironmentVariables()
	.Build();

string server = config["SERVER"];
string port = config["PORT"];
string userID = config["USERID"];
string password = config["PASSWORD"];
string database = "ToDo";

string connectionString = $"server={server}:{port};uid={userID};pwd={password};database={database}";
// Build app
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run();
