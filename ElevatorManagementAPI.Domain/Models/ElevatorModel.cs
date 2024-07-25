using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models;

public class ElevatorModel
{
  public Guid Id { get; set; }
  public required ElevatorType Type { get; set; }
  public ElevatorStatus? Status { get; set; }
  public string? Technology { get; set; }
  public int? StopsNum { get; set; }
  public int? Capacity { get; set; }
  public int? People { get; set; }
  public int? VelocityNum { get; set; }
  public string? FrequencyInversor { get; set; }
  public string? Machine { get; set; }
  public string? Command { get; set; }
  public int? QttCables { get; set; }
  public int? CableGauge { get; set; }
  public bool? IsHouseMachineLess { get; set; } =
    false;
  public bool? IsHouseMachineOnTop { get; set; } =
    true;
  public string? Ipd { get; set; }
  public string? Buttom { get; set; }
  public string? OilType { get; set; }
  public string? DoorOperator { get; set; }
  public DateTime CreatedAt { get; set; } =
    DateTime.Now;
  public DateTime UpdatedAt { get; set; }
  public DateTime? MaintenedAt { get; set; }
  public required Guid BuildingId { get; set; }
  public required Guid TenantId { get; set; }
  public Guid? UserId { get; set; }

  [JsonIgnore]
  public virtual required BuildingModel Building { get; set; }

  [JsonIgnore]
  public virtual required TenantModel Tenant { get; set; }

  [JsonIgnore]
  public virtual UserModel? User { get; set; }

  [JsonIgnore]
  public virtual ICollection<PendencyModel>? Pendencies { get; set; }

  [JsonIgnore]
  public virtual ICollection<VisitModel>? Visits { get; set; }
}
