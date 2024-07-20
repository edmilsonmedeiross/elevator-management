namespace ElevatorManagementAPI.Domain.Entities;

public class Buildings

{
  public Buildings(string name, bool isActive, string tel, DateTime createdAt, DateTime updatedAt, Guid assigneeId, Guid addressId, Guid tenantId)
  {
    Id = Guid.NewGuid();
    Name = name ?? throw new ArgumentNullException(nameof(name));
    IsActive = isActive;
    Tel = tel;
    CreatedAt = createdAt;
    UpdatedAt = updatedAt;
    AssigneeId = assigneeId;
    AddressId = addressId;
    TenantId = tenantId;
  }


  public Guid Id { get; private set; }
  public string Name { get; private set; }
  public bool IsActive { get; private set; }
  public string Tel { get; private set; }
  public DateTime CreatedAt { get; private set; }
  public DateTime UpdatedAt { get; private set; }
  public Guid AssigneeId { get; private set; }
  public Guid AddressId { get; private set; }
  public Guid TenantId { get; private set; }
  public required virtual Address Address { get; set; }
  public required virtual Assignees Assignee { get; set; }
  public required virtual Tenants Tenant { get; set; }
  public required virtual ICollection<Elevators> Elevators { get; set; }

}
