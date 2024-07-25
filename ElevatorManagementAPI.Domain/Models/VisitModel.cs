using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models;

public class VisitModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
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
    public Guid UserId { get; set; }
    public Guid BuildingId { get; set; }
    public Guid TenantId { get; set; }

    public virtual required UserModel User { get; set; }

    public virtual required BuildingModel Building { get; set; }

    public virtual required TenantModel Tenant { get; set; }

    public virtual required ICollection<ElevatorModel> Elevators { get; set; } = [];

    public void SetUser(UserModel user) => User = user;

    public void SetBuilding(BuildingModel building) => Building = building;

    public void SetTenant(TenantModel tenant) => Tenant = tenant;

    public void SetElevators(ICollection<ElevatorModel> elevators) => Elevators = elevators;
}
