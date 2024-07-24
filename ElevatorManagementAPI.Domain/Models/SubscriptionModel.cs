using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models;

public class SubscriptionModel
{
  public long Id { get; set; }
  public required long StripeSubscriptionId { get; set; }
  public required long PlanID { get; set; }
  public required SubscriptionStatus Status { get; set; }
  public bool IsActive { get; set; } = true;
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; }
  public required long TenantId { get; set; }
  [JsonIgnore]
  public virtual required TenantModel Tenant { get; set; }
}
