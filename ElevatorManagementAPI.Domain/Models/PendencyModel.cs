using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models
{
  public class PendencyModel
  {
    public Guid Id { get; set; }
    public required PendencyStatus Status { get; set; }
    public required string Description { get; set; }
    public string? Picture { get; set; }
    public DateTime? ClosedAt { get; set; }
    public DateTime CreatedAt { get; set; } =
      DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public required Guid UserId { get; set; }
    public required Guid ElevatorId { get; set; }
    public required Guid TenantId { get; set; }

    [JsonIgnore]
    public virtual required UserModel User { get; set; }

    [JsonIgnore]
    public virtual required ElevatorModel Elevator { get; set; }

    [JsonIgnore]
    public virtual required TenantModel Tenant { get; set; }
  }
}
