using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevatorManagementAPI.Api.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Street).IsRequired().HasColumnType("varchar(100)");
            builder.Property(a => a.Number).IsRequired().HasColumnType("int");
            builder.Property(a => a.City).IsRequired().HasColumnType("varchar(100)");
            builder.Property(a => a.State).IsRequired().HasColumnType("varchar(100)");
            builder.Property(a => a.ZipCode).IsRequired().HasColumnType("varchar(100)");
            builder.Property(a => a.District).IsRequired().HasColumnType("varchar(100)");

            builder.Property(a => a.CreatedAt).IsRequired().HasColumnType("datetime");

            builder.Property(a => a.UpdatedAt).IsRequired().HasColumnType("datetime");

            builder.Property(a => a.BuildingId).HasColumnType("TEXT");

            builder.Property(a => a.TenantId).IsRequired().HasColumnType("TEXT");

            builder
                .HasOne(a => a.Tenant)
                .WithOne(t => t.Address)
                .HasForeignKey<AddressModel>(a => a.TenantId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(a => a.Building)
                .WithOne(b => b.Address)
                .HasForeignKey<AddressModel>(a => a.BuildingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
