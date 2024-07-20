using ElevatorManagementAPI.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();

app.MapControllers();

var meuUser = new Users(
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
);

app.MapGet("/", () => meuUser);

app.Run();
