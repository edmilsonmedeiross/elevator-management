using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Models
{
    public class AddressModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Street { get; set; }
        public required int Number { get; set; }
        public required string District { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string ZipCode { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public required Guid BuildingId { get; set; }

        public required Guid TenantId { get; set; }

        public virtual required TenantModel Tenant { get; set; }

        public virtual required BuildingModel Building { get; set; }

        // Setters públicos
        public void SetBuildingId(Guid buildingId) => BuildingId = buildingId;

        public void SetTenantId(Guid tenantId) => TenantId = tenantId;

        public void SetTenant(TenantModel tenant) => Tenant = tenant;

        public void SetBuilding(BuildingModel building) => Building = building;
    }
}
