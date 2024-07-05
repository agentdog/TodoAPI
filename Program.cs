using MySql.Data;
using MySql.Data.MySqlClient;

using TodoAPI;
using DotEnv.Core;
using System.Data.Common;

// Connect to SQL server
new EnvLoader().AddEnvFile(".env").Load();
var envReader = new EnvReader();

string connectionString;
// Build app
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run();
