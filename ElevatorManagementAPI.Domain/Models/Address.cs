namespace ElevatorManagementAPI.Domain.Models;

public class Address
{
  public long Id { get; set; }
  public required string Street { get; set; }
  public required int Number { get; set; }
  public required string District { get; set; }
  public required string City { get; set; }
  public required string State { get; set; }
  public required string ZipCode { get; set; }
  public long TenantId { get; set; }
  public Tenants? Tenant { get; set; }
}
