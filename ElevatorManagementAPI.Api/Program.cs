using ElevatorManagementAPI.Api.Datas;
using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// builder.Services.AddSqlite<AppDbContext>("Data Source=ElevatorManagementAPI.db");
builder.Services.AddDbContext<AppDbContextS>(options =>
  options.UseSqlite("Data Source=ElevatorManagementAPI.db")
);

var app = builder.Build();

app.UseRouting();

app.MapControllers();

/* var meuUser = new Users(
    name: "Ikaro",
    documentType: DocumentType.CPF,
    documentNumber: "12345678900",
    email: "john.doe@example.com",
    password: "password123",
    role: UserRole.Master,
    tel: "123456789",
    isActive: true,
    createdAt: DateTime.UtcNow,
    updatedAt: DateTime.UtcNow,
    tenantId: Guid.NewGuid()
); */

app.MapGet("/", () => "FUNFOU");

app.Run();
