using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models;

public class SubscriptionModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required Guid StripeSubscriptionId { get; set; }
    public required Guid PlanID { get; set; }
    public required SubscriptionStatus Status { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public required Guid TenantId { get; set; }

    public virtual required TenantModel Tenant { get; set; }

    public void SetTenant(TenantModel tenant) => Tenant = tenant;
}
