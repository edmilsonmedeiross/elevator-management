using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models;

public class BuildingModel

{
  public long Id { get; set; }
  public required string Name { get; set; }
  public required bool IsActive { get; set; }
  public required string Tel { get; set; }
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; }
  public long AssigneeId { get; set; }
  public long AddressId { get; set; }
  public long TenantId { get; set; }
  public required virtual AddressModel Address { get; set; }
  public required virtual AssigneeModel Assignee { get; set; }
  public required virtual TenantModel Tenant { get; set; }

  [JsonIgnore]
  public required virtual ICollection<ElevatorModel> Elevators { get; set; }

}
