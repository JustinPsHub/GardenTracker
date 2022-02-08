

// See https://aka.ms/new-console-template for more information
using Npgsql;

Console.WriteLine("Hello, World!");



var connString = "Host=myserver;Username=mylogin;Password=mypass;Database=mydatabase";

await using var conn = new NpgsqlConnection(connString);
await conn.OpenAsync();

