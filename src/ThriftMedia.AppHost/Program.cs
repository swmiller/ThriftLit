using Microsoft.Extensions.Configuration;

var builder = DistributedApplication.CreateBuilder(args);

// Build configuration to read appsettings.json
var config = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

// Retrieve the ThriftMediaDb connection string
var thriftMediaDbConnectionString = config.GetConnectionString("ThriftMediaDb");

// Add the connection string to the distributed application builder
builder.AddConnectionString("ThriftMediaDb", thriftMediaDbConnectionString);

builder.AddProject<Projects.ThriftMedia_Web>("thriftmediaweb");

builder.AddProject<Projects.ThriftMedia_Api>("thriftmediaapi");

builder.Build().Run();

