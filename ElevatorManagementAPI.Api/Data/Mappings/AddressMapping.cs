using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevatorManagementAPI.Api.Data.Mappings
{
  public class AddressMapping : IEntityTypeConfiguration<AddressModel>
  {
    public void Configure(EntityTypeBuilder<AddressModel> builder)
    {
      builder.ToTable("Address");
      builder.HasKey(a => a.Id);
      builder.Property(a => a.Street)
        .IsRequired()
        .HasColumnType("NVARCHAR")
        .HasMaxLength(100);
      builder.Property(a => a.Number)
        .IsRequired()
        .HasColumnType("INT");
      builder.Property(a => a.City)
        .IsRequired()
        .HasColumnType("NVARCHAR")
        .HasMaxLength(100);
      builder.Property(a => a.State)
        .IsRequired()
        .HasColumnType("NVARCHAR")
        .HasMaxLength(100);
      builder.Property(a => a.ZipCode)
        .IsRequired()
        .HasColumnType("NVARCHAR")
        .HasMaxLength(100);
      builder.Property(a => a.District)
        .IsRequired()
        .HasColumnType("NVARCHAR")
        .HasMaxLength(100);
      builder.Property(a => a.BuildingId)
        .IsRequired()
        .HasColumnType("varchar(100)");
      builder.Property(a => a.TenantId)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder.HasOne(a => a.Tenant)
        .WithOne(t => t.Address)
        .HasForeignKey<AddressModel>(a => a.TenantId);

      builder.HasOne(a => a.Building)
        .WithOne(b => b.Address)
        .HasForeignKey<AddressModel>(a => a.BuildingId);
    }
  }
}
