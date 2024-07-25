using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models;

public class BuildingModel
{
  public Guid Id { get; set; }
  public required string Name { get; set; }
  public required bool IsActive { get; set; } =
    true;
  public required string Tel { get; set; }
  public DateTime CreatedAt { get; set; } =
    DateTime.Now;
  public DateTime UpdatedAt { get; set; }
  public Guid AssigneeId { get; set; }
  public Guid AddressId { get; set; }
  public Guid TenantId { get; set; }
  public Guid? UserId { get; set; }
  public virtual required AddressModel Address { get; set; }
  public virtual required AssigneeModel Assignee { get; set; }
  public virtual required TenantModel Tenant { get; set; }

  [JsonIgnore]
  public virtual required ICollection<ElevatorModel> Elevators { get; set; }

  [JsonIgnore]
  public virtual required UserModel? User { get; set; }
}
