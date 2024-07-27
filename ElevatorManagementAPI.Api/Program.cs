using ElevatorManagementAPI.Api.Data;
using ElevatorManagementAPI.Api.Handlers;
using ElevatorManagementAPI.Domain.Handlers;
using ElevatorManagementAPI.Domain.Models;
using ElevatorManagementAPI.Domain.Requests.Tenants;
using ElevatorManagementAPI.Domain.Responses;
using ElevatorManagementAPI.Domain.Responses.Tenants;
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

app.MapGet("/tenants", (ITenantHandler handler) => handler.GetAllAsync())
    .WithName("GetAllTenants")
    .WithSummary("Get all tenants")
    .Produces<Response<List<TenantModel>>>();

app.MapPost(
        "/tenants",
        (CreateTenantRequest request, ITenantHandler handler) => handler.CreateAsync(request)
    )
    .WithName("CreateTenant")
    .WithSummary("Create a new tenant")
    .Produces<Response<CreateTenantResponse>>();

app.MapPut(
        "/tenants/{id}",
        (Guid id, UpdateTenantRequest request, ITenantHandler handler) =>
            handler.UpdateAsync(id, request)
    )
    .WithName("UpdateTenant")
    .WithSummary("Update a tenant")
    .Produces<Response<TenantModel>>();

app.MapGet("/tenants/{id}", (Guid id, ITenantHandler handler) => handler.GetByIdAsync(id))
    .WithName("GetTenantById")
    .WithSummary("Get a tenant by id")
    .Produces<Response<TenantModel>>();

app.MapDelete("/tenants/{id}", (Guid id, ITenantHandler handler) => handler.DeleteAsync(id));

app.Run();
