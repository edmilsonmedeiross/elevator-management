namespace ElevatorManagementAPI.Domain.Entities;

public class Visit
{
  public Visit(VisitType type, string description, string problem, bool isPassengerStucked, VisitStatus status, ElevatorStatus elevatorStatusPre, int currentFloor, DateTime createdAt, DateTime updatedAt, Guid userId, Guid elevatorId, Guid buildingId, Guid tenantId)
  {
    Id = Guid.NewGuid();
    Type = type;
    SetDescription(description);
    SetProblem(problem);
    IsPassengerStucked = isPassengerStucked;
    Status = status;
    ElevatorStatusPre = elevatorStatusPre;
    ElevatorStatusPos = null;
    CurrentFloor = currentFloor;
    ClosedAt = null;
    CreatedAt = createdAt;
    UpdatedAt = updatedAt;
    UserId = userId;
    ElevatorId = elevatorId;
    BuildingId = buildingId;
    TenantId = tenantId;
  }

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

  private void SetDescription(string description)
  {
    if (string.IsNullOrEmpty(description))
      throw new ArgumentNullException(nameof(description), "Description is required");
    Description = description;
  }

  private void SetProblem(string problem)
  {
    if (string.IsNullOrEmpty(problem))
      throw new ArgumentNullException(nameof(problem), "Problem is required");
    Problem = problem;
  }

  public void CloseVisit(ElevatorStatus elevatorStatusPos, DateTime closedAt)
  {
    ElevatorStatusPos = elevatorStatusPos;
    Status = VisitStatus.Closed;
    ClosedAt = closedAt;
    UpdatedAt = DateTime.UtcNow;
  }
}
