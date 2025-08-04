
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inject ThriftMediaDb connection string into ThriftMediaDbContext
builder.Services.AddDbContext<ThriftMedia.Data.Models.ThriftMediaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ThriftMediaDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Register media endpoints
app.MapMediaEndpoints();

// Register store owner endpoints
app.MapStoreOwnerEndpoints();

app.Run();
