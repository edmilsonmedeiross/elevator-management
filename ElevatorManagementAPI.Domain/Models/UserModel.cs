namespace ElevatorManagementAPI.Domain.Models;

public class UserModel
{
  public Guid Id { get; set; }
  public required string Name { get; set; }
  public required DocumentType DocumentType { get; set; }
  public required string DocumentNumber { get; set; }
  public required string Email { get; set; }
  public required string Password { get; set; }
  public required UserRole Role { get; set; }
  public required string Tel { get; set; }
  public required bool IsActive { get; set; } =
    true;
  public DateTime? PasswordChangedAt { get; set; }
  public DateTime CreatedAt { get; set; } =
    DateTime.Now;
  public DateTime UpdatedAt { get; set; }
  public required Guid TenantId { get; set; }
  public virtual required TenantModel Tenant { get; set; }
  public virtual ICollection<BuildingModel>? Buildings { get; set; }
  public virtual ICollection<ElevatorModel>? Elevators { get; set; }
  public virtual ICollection<PendencyModel>? Pendencies { get; set; }
}
