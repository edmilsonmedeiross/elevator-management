using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevatorManagementAPI.Api.Data.Mappings
{
  public class PendencyMapping
    : IEntityTypeConfiguration<PendencyModel>
  {
    public void Configure(
      EntityTypeBuilder<PendencyModel> builder
    )
    {
      builder.ToTable("Pendencies");

      builder.HasKey(p => p.Id);

      builder
        .Property(p => p.Status)
        .IsRequired()
        .HasConversion<string>()
        .HasColumnType("varchar(20)");

      builder
        .Property(p => p.Description)
        .IsRequired()
        .HasColumnType("varchar(200)");

      builder
        .Property(p => p.Picture)
        .HasColumnType("varchar(100)");

      builder
        .Property(p => p.ClosedAt)
        .HasColumnType("datetime");

      builder
        .Property(p => p.CreatedAt)
        .HasColumnType("datetime");

      builder
        .Property(p => p.UpdatedAt)
        .HasColumnType("datetime");

      builder
        .Property(p => p.UserId)
        .IsRequired()
        .HasColumnType("TEXT");

      builder
        .Property(p => p.ElevatorId)
        .IsRequired()
        .HasColumnType("TEXT");

      builder
        .Property(p => p.TenantId)
        .IsRequired()
        .HasColumnType("TEXT");

      builder
        .HasOne(p => p.User)
        .WithMany(u => u.Pendencies)
        .HasForeignKey(p => p.UserId);

      builder
        .HasOne(p => p.Elevator)
        .WithMany(e => e.Pendencies)
        .HasForeignKey(p =>
          p.ElevatorId
        );

      builder
        .HasOne(p => p.Tenant)
        .WithMany(t => t.Pendencies)
        .HasForeignKey(p => p.TenantId);
    }
  }
}
