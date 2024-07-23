namespace ElevatorManagementAPI.Domain.Models;

public class Subscriptions
{
  public int Id { get; set; }
  public required string StripeSubscriptionId { get; set; }
  public required string PlanID { get; set; }
  public required string Status { get; set; }
  public bool IsActive { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public required long TenantId { get; set; }
}
