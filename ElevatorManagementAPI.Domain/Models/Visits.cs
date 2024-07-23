namespace ElevatorManagementAPI.Domain.Models;

public class Visits
{
  public Guid Id { get; private set; }
  public VisitType Type { get; private set; }
  public string Description { get; private set; } = null!;
  public string Problem { get; private set; } = null!;
  public bool IsPassengerStucked { get; private set; } = false;
  public VisitStatus Status { get; private set; } = VisitStatus.Open;
  public ElevatorStatus ElevatorStatusPre { get; private set; } = ElevatorStatus.Stopped;
  public ElevatorStatus? ElevatorStatusPos { get; private set; }
  public int CurrentFloor { get; private set; }
  public DateTime? ClosedAt { get; private set; }
  public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
  public DateTime UpdatedAt { get; private set; }
  public Guid UserId { get; private set; }
  public Guid ElevatorId { get; private set; }
  public Guid BuildingId { get; private set; }
  public Guid TenantId { get; private set; }

}
