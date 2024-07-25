using ElevatorManagementAPI.Api.Data;
using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

var builder =
  WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
  x.CustomSchemaIds(n => n.FullName);
});

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(
  options =>
    options.UseSqlite(
      "Data Source=ElevatorManagementAPI.db"
    )
);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

app.MapControllers();

app.MapGet("/", () => "TESTEEEE");

app.Run();
