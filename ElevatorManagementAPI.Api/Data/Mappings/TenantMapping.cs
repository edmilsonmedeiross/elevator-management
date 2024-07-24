using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevatorManagementAPI.Api.Data.Mappings
{
  public class TenantMapping
    : IEntityTypeConfiguration<TenantModel>
  {
    public void Configure(
      EntityTypeBuilder<TenantModel> builder
    )
    {
      builder.ToTable("Tenants");

      builder.HasKey(t => t.Id);

      builder
        .Property(t => t.Name)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .Property(t => t.Email)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .Property(t => t.DocumentNumber)
        .IsRequired()
        .HasColumnType("varchar(20)");

      builder
        .Property(t => t.IsSubActive)
        .IsRequired()
        .HasColumnType("boolean")
        .HasDefaultValueSql("false");

      builder
        .Property(t => t.CreatedAt)
        .IsRequired()
        .HasDefaultValueSql(
          "CURRENT_TIMESTAMP"
        );

      builder
        .Property(t => t.UpdatedAt)
        .HasColumnType("datetime");

      builder
        .Property(t => t.CustomerId)
        .HasColumnType("varchar(100)");

      builder
        .Property(t => t.TenantColor)
        .HasColumnType("varchar(20)");

      builder
        .Property(t => t.TenantLogo)
        .HasColumnType("varchar(100)");

      builder
        .Property(t => t.AddressId)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .HasOne(t => t.Address)
        .WithOne(a => a.Tenant)
        .HasForeignKey<TenantModel>(t =>
          t.AddressId
        );

      builder
        .HasMany(t => t.Users)
        .WithOne(u => u.Tenant)
        .HasForeignKey(u => u.TenantId);

      builder
        .HasMany(t => t.Buildings)
        .WithOne(b => b.Tenant)
        .HasForeignKey(b => b.TenantId);

      builder
        .HasMany(t => t.Assignees)
        .WithOne(a => a.Tenant)
        .HasForeignKey(a => a.TenantId);

      builder
        .HasMany(t => t.Subscriptions)
        .WithOne(s => s.Tenant)
        .HasForeignKey(s => s.TenantId);

      builder
        .HasMany(t => t.Elevators)
        .WithOne(e => e.Tenant)
        .HasForeignKey(e => e.TenantId);

      builder
        .HasMany(t => t.Pendencies)
        .WithOne(p => p.Tenant)
        .HasForeignKey(p => p.TenantId);
    }
  }
}
