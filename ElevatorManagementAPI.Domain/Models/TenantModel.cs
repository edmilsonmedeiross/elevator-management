namespace ElevatorManagementAPI.Domain.Models;
public class TenantModel
{
  public long Id { get; set; }
  public required string Name { get; set; }
  public required string Email { get; set; }
  public required string DocumentNumber { get; set; }
  public bool IsSubActive { get; set; } = false;
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; }
  public string? CustomerId { get; set; }
  public string? TenantColor { get; set; }
  public string? TenantLogo { get; set; }
  public required long AddressId { get; set; }
  public virtual ICollection<UserModel>? Users { get; set; }
  public virtual ICollection<BuildingModel>? Buildings { get; set; }
  public virtual ICollection<AssigneeModel>? Assignees { get; set; }
  public virtual ICollection<SubscriptionModel>? Subscriptions { get; set; }
  public required virtual AddressModel Address { get; set; }
  public virtual ICollection<ElevatorModel>? Elevators { get; set; }
  public virtual ICollection<PendencyModel>? Pendencies { get; set; }
}
