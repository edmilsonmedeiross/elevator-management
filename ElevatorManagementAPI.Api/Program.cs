using ElevatorManagementAPI.Api.Common.Api;
using ElevatorManagementAPI.Api.Data;
using ElevatorManagementAPI.Api.Handlers;
using ElevatorManagementAPI.Api.Models;
using ElevatorManagementAPI.Domain.Handlers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ITenantHandler, TenantHandler>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.CustomSchemaIds(n => n.FullName);
});

builder.Services.AddAuthentication(IdentityConstants.ApplicationScheme).AddIdentityCookies();
builder.Services.AddAuthorization();

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=ElevatorManagementAPI.db")
);

builder
    .Services.AddIdentityCore<User>()
    .AddRoles<IdentityRole<long>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddApiEndpoints();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

app.MapControllers();

app.MapGet("/", () => new { message = "OK" });
app.MapEndpoints();

app.Run();
