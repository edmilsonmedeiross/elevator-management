using ElevatorManagementAPI.Api.Data;
using ElevatorManagementAPI.Api.Handlers;
using ElevatorManagementAPI.Domain.Handlers;
using ElevatorManagementAPI.Domain.Models;
using ElevatorManagementAPI.Domain.Requests;
using ElevatorManagementAPI.Domain.Requests.Tenants;
using ElevatorManagementAPI.Domain.Responses;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

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

app.MapGet("/user", () => "Hello World!");

app.MapPost(
        "/tenants",
        (CreateTenantRequest request, ITenantHandler handler) => handler.CreateAsync(request)
    )
    .WithName("CreateTenant")
    .WithSummary("Create a new tenant")
    .Produces<Response<TenantModel>>();

app.Run();
