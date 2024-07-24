using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models;

public class BuildingModel
{
  public long Id { get; set; }
  public required string Name { get; set; }
  public required bool IsActive { get; set; }
  public required string Tel { get; set; }
  public DateTime CreatedAt { get; set; } =
    DateTime.Now;
  public DateTime UpdatedAt { get; set; }
  public long AssigneeId { get; set; }
  public long AddressId { get; set; }
  public long TenantId { get; set; }
  public long? UserId { get; set; }
  public virtual required AddressModel Address { get; set; }
  public virtual required AssigneeModel Assignee { get; set; }
  public virtual required TenantModel Tenant { get; set; }

  [JsonIgnore]
  public virtual required ICollection<ElevatorModel> Elevators { get; set; }

  [JsonIgnore]
  public virtual required UserModel? User { get; set; }
}
