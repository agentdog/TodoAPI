using MySqlConnector;
using TodoAPI;
using DotEnv;


// Connect to SQL server
var root = Directory.GetCurrentDirectory();
var dotenv = Path.Combine(root, ".env");
DotEnv.DotEnv.Load(dotenv);

var SQLbuilder = new MySqlConnectionStringBuilder {
	Server = ""
};

// Build app
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run();
