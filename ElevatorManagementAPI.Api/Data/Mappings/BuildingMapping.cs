using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevatorManagementAPI.Api.Data.Mappings
{
  public class BuildingMapping
    : IEntityTypeConfiguration<BuildingModel>
  {
    public void Configure(
      EntityTypeBuilder<BuildingModel> builder
    )
    {
      builder.ToTable("Buildings");

      builder.HasKey(b => b.Id);

      builder
        .Property(b => b.Name)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .Property(b => b.Tel)
        .IsRequired()
        .HasColumnType("varchar(20)");

      builder
        .Property(b => b.IsActive)
        .IsRequired()
        .HasColumnType("boolean");

      builder
        .Property(b => b.CreatedAt)
        .IsRequired()
        .HasColumnType("datetime");

      builder
        .Property(b => b.UpdatedAt)
        .HasColumnType("datetime");

      builder
        .Property(b => b.AssigneeId)
        .IsRequired()
        .HasColumnType("TEXT");

      builder
        .Property(b => b.AddressId)
        .IsRequired()
        .HasColumnType("TEXT");

      builder
        .Property(b => b.TenantId)
        .IsRequired()
        .HasColumnType("TEXT");

      builder
        .HasOne(b => b.Tenant)
        .WithMany(t => t.Buildings)
        .HasForeignKey(b => b.TenantId);

      builder
        .HasOne(b => b.Assignee)
        .WithMany(a => a.Buildings)
        .HasForeignKey(b =>
          b.AssigneeId
        );
    }
  }
}
