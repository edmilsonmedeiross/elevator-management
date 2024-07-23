public class Tenants
{
  public long Id { get; set; }
  public required string Email { get; set; }
  public required string DocumentNumber { get; set; }
  public bool? IsSubActive { get; set; }
  public required string Name { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public string? CustomerId { get; set; }
  public string? TenantColor { get; set; }
  public string? TenantLogo { get; set; }

}
