using Aspire.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = DistributedApplication.CreateBuilder(args);

// Register API project and reference the database
builder.AddProject<Projects.ThriftMedia_Api>("thriftmediaapi");

// Register Web project
builder.AddProject<Projects.ThriftMedia_Web>("thriftmediaweb");

builder.Build().Run();

