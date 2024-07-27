using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevatorManagementAPI.Api.Data.Mappings
{
  public class UserMapping
    : IEntityTypeConfiguration<UserModel>
  {
    public void Configure(
      EntityTypeBuilder<UserModel> builder
    )
    {
      builder.ToTable("Users");

      builder.HasKey(u => u.Id);

      builder
        .Property(u => u.Name)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .Property(u => u.DocumentType)
        .IsRequired()
        .HasConversion<string>()
        .HasColumnType("varchar(20)");

      builder
        .Property(u => u.DocumentNumber)
        .IsRequired()
        .HasColumnType("varchar(20)");

      builder
        .Property(u => u.Email)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .Property(u => u.Password)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .Property(u => u.Role)
        .IsRequired()
        .HasConversion<string>()
        .HasColumnType("varchar(20)");

      builder
        .Property(u => u.Tel)
        .IsRequired()
        .HasColumnType("varchar(20)");

      builder
        .Property(u => u.IsActive)
        .IsRequired()
        .HasColumnType("boolean");

      builder
        .Property(u =>
          u.PasswordChangedAt
        )
        .HasColumnType("datetime");

      builder
        .Property(u => u.CreatedAt)
        .IsRequired()
        .HasColumnType("datetime");

      builder
        .Property(u => u.UpdatedAt)
        .HasColumnType("datetime");

      builder
        .Property(u => u.TenantId)
        .IsRequired()
        .HasColumnType("TEXT");

      builder
        .HasOne(u => u.Tenant)
        .WithMany()
        .HasForeignKey(u => u.TenantId);

      builder
        .HasMany(u => u.Buildings)
        .WithOne(b => b.User)
        .HasForeignKey(b => b.UserId);

      builder
        .HasMany(u => u.Elevators)
        .WithOne(e => e.User)
        .HasForeignKey(e => e.UserId);

      builder
        .HasMany(u => u.Pendencies)
        .WithOne(p => p.User)
        .HasForeignKey(p => p.UserId);
    }
  }
}
