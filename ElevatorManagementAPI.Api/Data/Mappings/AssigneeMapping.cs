using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevatorManagementAPI.Api.Data.Mappings
{
  public class AssigneeMapping : IEntityTypeConfiguration<AssigneeModel>
  {
    public void Configure(EntityTypeBuilder<AssigneeModel> builder)
    {
      builder.ToTable("assignees");

      builder.HasKey(a => a.Id);

      builder.Property(a => a.Name)
          .IsRequired()
          .HasColumnType("varchar(100)")
          .HasMaxLength(100);

      builder.Property(a => a.Tel)
          .IsRequired()
          .HasColumnType("varchar(20)")
          .HasMaxLength(20);

      builder.Property(a => a.Email)
          .IsRequired()
          .HasColumnType("varchar(100)")
          .HasMaxLength(100);

      builder.Property(a => a.CreatedAt)
          .IsRequired()
          .HasDefaultValueSql("CURRENT_TIMESTAMP");

      builder.Property(a => a.UpdatedAt);

      builder.Property(a => a.TenantId)
          .IsRequired()
          .HasColumnType("varchar(100)");

      builder.Property(a => a.BuildingId)
          .IsRequired()
          .HasColumnType("varchar(100)");

      builder.HasOne(a => a.Tenant)
          .WithMany(t => t.Assignees)
          .HasForeignKey(a => a.TenantId);

      builder.HasMany(a => a.Buildings)
          .WithOne(b => b.Assignee)
          .HasForeignKey(b => b.AssigneeId);
    }
  }
}
