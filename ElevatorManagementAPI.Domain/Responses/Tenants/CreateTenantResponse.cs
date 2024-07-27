namespace ElevatorManagementAPI.Domain.Responses.Tenants
{
    public class CreateTenantResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }
}
