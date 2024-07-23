namespace ElevatorManagementAPI.Domain.Models;

public class Assignees
{
  public long Id { get; set; }
  public required string Name { get; set; }
  public required string Tel { get; set; }
  public required string Email { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public long TenantId { get; set; }
  public virtual required Tenants Tenant { get; set; }
}
