namespace ElevatorManagementAPI.Domain.Requests
{
  public abstract class Request
  {
    public string TenantId { get; set; } = string.Empty;

  }
}
