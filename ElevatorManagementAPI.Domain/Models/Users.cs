namespace ElevatorManagementAPI.Domain.Models;

public class Users
{
  public long Id { get; set; }
  public required string Name { get; set; }
  public required DocumentType DocumentType { get; set; }
  public required string DocumentNumber { get; set; }
  public required string Email { get; set; }
  public required string Password { get; set; }
  public required UserRole Role { get; set; }
  public required string Tel { get; set; }
  public required bool IsActive { get; set; }
  public DateTime? PasswordChangedAt { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public long TenantId { get; set; }
  public Users? InvitedBy { get; set; }
  public long? InvitedById { get; set; }
}
