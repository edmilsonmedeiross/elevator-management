namespace ElevatorManagementAPI.Domain.Requests.Tenants
{
    public class UpdateTenantRequest
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? DocumentNumber { get; set; }
        public bool? IsSubActive { get; set; } = false;
        public string? TenantColor { get; set; }
        public string? TenantLogo { get; set; }
    }
}
