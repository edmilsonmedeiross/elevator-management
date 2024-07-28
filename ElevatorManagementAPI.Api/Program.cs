using ElevatorManagementAPI.Api.Common.Api;
using ElevatorManagementAPI.Api.Data;
using ElevatorManagementAPI.Api.Handlers;
using ElevatorManagementAPI.Domain.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.CustomSchemaIds(n => n.FullName);
});
builder.Services.AddTransient<ITenantHandler, TenantHandler>();

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=ElevatorManagementAPI.db")
);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

app.MapControllers();

app.MapGet("/", () => new { message = "OK" });
app.MapEndpoints();

app.Run();
