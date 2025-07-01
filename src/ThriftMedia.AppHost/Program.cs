var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ThriftMedia_Web>("thriftmediaweb");

builder.AddProject<Projects.ThriftMedia_Api>("thriftmediaapi");

builder.Build().Run();

