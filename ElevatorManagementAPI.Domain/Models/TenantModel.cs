namespace ElevatorManagementAPI.Domain.Models;

public class TenantModel
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string DocumentNumber { get; set; }
    public bool IsSubActive { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public Guid? CustomerId { get; set; }
    public string? TenantColor { get; set; }
    public string? TenantLogo { get; set; }
    public Guid? AddressId { get; set; }
    public virtual ICollection<UserModel>? Users { get; set; } = [];
    public virtual ICollection<BuildingModel>? Buildings { get; set; } = [];
    public virtual ICollection<AssigneeModel>? Assignees { get; set; } = [];
    public virtual ICollection<SubscriptionModel>? Subscriptions { get; set; } = [];
    public virtual AddressModel? Address { get; set; }
    public virtual ICollection<ElevatorModel>? Elevators { get; set; } = [];
    public virtual ICollection<PendencyModel>? Pendencies { get; set; } = [];

    public void SetUsers(ICollection<UserModel>? users) => Users = users;

    public void SetBuildings(ICollection<BuildingModel>? buildings) => Buildings = buildings;

    public void SetAssignees(ICollection<AssigneeModel>? assignees) => Assignees = assignees;

    public void SetSubscriptions(ICollection<SubscriptionModel>? subscriptions) =>
        Subscriptions = subscriptions;

    public void SetAddress(AddressModel? address) => Address = address;

    public void SetElevators(ICollection<ElevatorModel>? elevators) => Elevators = elevators;

    public void SetPendencies(ICollection<PendencyModel>? pendencies) => Pendencies = pendencies;
}
