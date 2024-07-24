using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models;

public class AddressModel
{
  public long Id { get; set; }
  public required string Street { get; set; }
  public required int Number { get; set; }
  public required string District { get; set; }
  public required string City { get; set; }
  public required string State { get; set; }
  public required string ZipCode { get; set; }
  [JsonIgnore]
  public long? BuildingId { get; set; }
  [JsonIgnore]
  public long TenantId { get; set; }
  [JsonIgnore]
  public virtual required TenantModel Tenant { get; set; }
  [JsonIgnore]
  public virtual required BuildingModel Building { get; set; }
}
