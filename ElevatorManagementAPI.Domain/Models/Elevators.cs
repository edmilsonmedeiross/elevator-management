namespace ElevatorManagementAPI.Domain.Models;

public class Elevators
{
  public Guid Id { get; set; }
  public required string Type { get; set; }
  public string? Status { get; set; }
  public string? Technology { get; set; }
  public int? StopsNum { get; set; }
  public int? Capacity { get; set; }
  public int? People { get; set; }
  public int? VelocityNum { get; set; }
  public string? FrequencyInversor { get; set; }
  public string? Machine { get; set; }
  public string? Command { get; set; }
  public int? QttCables { get; set; }
  public int? CableGauge { get; set; }
  public bool? IsHouseMachineLess { get; set; }
  public bool? IsHouseMachineTop { get; set; }
  public string? Ipd { get; set; }
  public string? Buttom { get; set; }
  public string? OilType { get; set; }
  public string? DoorOperator { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public long BuildingId { get; set; }
  public long TenantId { get; set; }
}
