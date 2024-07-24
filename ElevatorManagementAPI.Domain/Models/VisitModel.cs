using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models;

public class VisitModel
{
  public long Id { get; set; }
  public VisitType Type { get; set; }
  public required string Description { get; set; }
  public required string Problem { get; set; }
  public bool IsPassengerStucked { get; set; } = false;
  public required VisitStatus Status { get; set; } = VisitStatus.Open;
  public ElevatorStatus ElevatorStatusPre { get; set; } = ElevatorStatus.Stopped;
  public ElevatorStatus? ElevatorStatusPos { get; set; }
  public int? CurrentFloor { get; set; }
  public DateTime? ClosedAt { get; set; }
  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  public DateTime UpdatedAt { get; set; }
  public long UserId { get; set; }
  public long ElevatorId { get; set; }
  public long BuildingId { get; set; }
  public long TenantId { get; set; }
  [JsonIgnore]
  public virtual required UserModel User { get; set; }
  [JsonIgnore]
  public virtual required ICollection<ElevatorModel> Elevator { get; set; }
  [JsonIgnore]
  public virtual required BuildingModel Building { get; set; }
  [JsonIgnore]
  public virtual required TenantModel Tenant { get; set; }

}
