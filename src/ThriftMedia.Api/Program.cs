
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Inject ThriftMediaDb connection string into ThriftMediaDbContext
builder.Services.AddDbContext<ThriftMedia.Data.Models.ThriftMediaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ThriftMediaDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Register media endpoints
app.MapMediaEndpoints();

// Register store owner endpoints
app.MapStoreOwnerEndpoints();

app.Run();
