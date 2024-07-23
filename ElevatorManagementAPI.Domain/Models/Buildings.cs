namespace ElevatorManagementAPI.Domain.Models;

public class Buildings

{
  public long Id { get; set; }
  public required string Name { get; set; }
  public required bool IsActive { get; set; }
  public required string Tel { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public long AssigneeId { get; set; }
  public long AddressId { get; set; }
  public long TenantId { get; set; }
  public required virtual Address Address { get; set; }
  public required virtual Assignees Assignee { get; set; }
  public required virtual Tenants Tenant { get; set; }
  public required virtual ICollection<Elevators> Elevators { get; set; }

}
