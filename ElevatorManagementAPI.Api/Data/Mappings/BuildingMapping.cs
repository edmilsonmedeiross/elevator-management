using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ElevatorManagementAPI.Api.Data.Mappings
{

  public class BuildingMapping : IEntityTypeConfiguration<BuildingModel>
  {
    public void Configure(EntityTypeBuilder<BuildingModel> builder)
    {
      builder.ToTable("Building");

      builder.HasKey(b => b.Id);

      builder.Property(b => b.Name)
          .IsRequired()
          .HasColumnType("varchar(100)");

      builder.Property(b => b.Tel)
          .IsRequired()
          .HasColumnType("varchar(20)");

      builder.Property(b => b.IsActive)
          .IsRequired()
          .HasColumnType("boolean")
          .HasDefaultValueSql("true");

      builder.Property(b => b.CreatedAt)
          .IsRequired();

      builder.Property(b => b.UpdatedAt);

      builder.Property(b => b.AssigneeId)
          .IsRequired()
          .HasColumnType("varchar(100)");

      builder.Property(b => b.AddressId)
          .IsRequired()
          .HasColumnType("varchar(100)");

      builder.Property(b => b.TenantId)
          .IsRequired();

      builder.HasOne(b => b.Tenant)
          .WithMany(t => t.Buildings)
          .HasForeignKey(b => b.TenantId);

      builder.HasOne(b => b.Address)
          .WithOne()
          .HasForeignKey<BuildingModel>(b => b.AddressId);

      builder.HasOne(b => b.Assignee)
          .WithOne()
          .HasForeignKey<BuildingModel>(b => b.AssigneeId);
    }
  }
}
