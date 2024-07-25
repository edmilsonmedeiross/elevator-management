namespace ElevatorManagementAPI.Domain.Models;

public class AssigneeModel
{
  public Guid Id { get; set; }
  public required string Name { get; set; }
  public required string Tel { get; set; }
  public required string Email { get; set; }
  public DateTime CreatedAt { get; set; } =
    DateTime.Now;
  public DateTime UpdatedAt { get; set; }
  public required Guid BuildingId { get; set; }
  public required Guid TenantId { get; set; }
  public virtual required TenantModel Tenant { get; set; }
  public virtual required ICollection<BuildingModel> Buildings { get; set; }
}
