namespace ElevatorManagementAPI.Domain.Models
{
  public class Pendencies
  {
    public long Id { get; set; }
    public required PendencyStatus Status { get; set; }
    public required string Description { get; set; } = null!;
    public string? Picture { get; set; }
    public DateTime? ClosedAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public required long UserId { get; set; }
    public required long ElevatorId { get; set; }
    public required long TenantId { get; set; }
  }
}
