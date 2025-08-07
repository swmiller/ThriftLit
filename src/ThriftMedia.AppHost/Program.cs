using Aspire.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = DistributedApplication.CreateBuilder(args);

// Add database connection string
var thriftMediaDbConnectionString = builder.AddConnectionString("ThriftMediaDb");

// Register API project and reference the database
builder.AddProject<Projects.ThriftMedia_Api>("thriftmediaapi")
    .WithReference(thriftMediaDbConnectionString);

// Register Web project
builder.AddProject<Projects.ThriftMedia_Web>("thriftmediaweb");

builder.Build().Run();

