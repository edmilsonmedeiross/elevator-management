namespace ElevatorManagementAPI.Domain.Entities;

public class Elevators
{
  public Elevators(string type, string? status, string? technology, int? stopsNum, int? capacity, int? people, int? velocityNum, string? frequencyInversor, string? machine, string? command, int? qttCables, int? cableGauge, bool? isHouseMachineLess, bool? isHouseMachineTop, string? ipd, string? buttom, string? oilType, string? doorOperator, DateTime createdAt, DateTime updatedAt, Guid buildingId, Guid tenantId)
  {
    Id = Guid.NewGuid();
    if (string.IsNullOrEmpty(type))
      throw new ArgumentNullException("Type is required");
    Type = type;
    Status = status;
    Technology = technology;
    StopsNum = stopsNum;
    Capacity = capacity;
    People = people;
    VelocityNum = velocityNum;
    FrequencyInversor = frequencyInversor;
    Machine = machine;
    Command = command;
    QttCables = qttCables;
    CableGauge = cableGauge;
    IsHouseMachineLess = isHouseMachineLess;
    IsHouseMachineTop = isHouseMachineTop;
    Ipd = ipd;
    Buttom = buttom;
    OilType = oilType;
    DoorOperator = doorOperator;
    CreatedAt = createdAt;
    UpdatedAt = updatedAt;
    BuildingId = buildingId;
    TenantId = tenantId;
  }
  public Guid Id { get; private set; }
  public string Type { get; private set; }
  public string? Status { get; private set; }
  public string? Technology { get; private set; }
  public int? StopsNum { get; private set; }
  public int? Capacity { get; private set; }
  public int? People { get; private set; }
  public int? VelocityNum { get; private set; }
  public string? FrequencyInversor { get; private set; }
  public string? Machine { get; private set; }
  public string? Command { get; private set; }
  public int? QttCables { get; private set; }
  public int? CableGauge { get; private set; }
  public bool? IsHouseMachineLess { get; private set; }
  public bool? IsHouseMachineTop { get; private set; }
  public string? Ipd { get; private set; }
  public string? Buttom { get; private set; }
  public string? OilType { get; private set; }
  public string? DoorOperator { get; private set; }
  public DateTime CreatedAt { get; private set; }
  public DateTime UpdatedAt { get; private set; }
  public Guid BuildingId { get; private set; }
  public Guid TenantId { get; private set; }
}
