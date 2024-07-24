namespace ElevatorManagementAPI.Domain.Models;
public class TenantModel
{
  public long Id { get; set; }
  public required string Name { get; set; }
  public required string Email { get; set; }
  public required string DocumentNumber { get; set; }
  public bool IsSubActive { get; set; } = false;
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; }
  public string? CustomerId { get; set; }
  public string? TenantColor { get; set; }
  public string? TenantLogo { get; set; }

}
