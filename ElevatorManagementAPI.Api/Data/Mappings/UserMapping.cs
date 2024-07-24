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
    /*
    public long Id { get; set; }
    public required string Name { get; set; }
    public required DocumentType DocumentType { get; set; }
    public required string DocumentNumber { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required UserRole Role { get; set; }
    public required string Tel { get; set; }
    public required bool IsActive { get; set; }
    public DateTime? PasswordChangedAt { get; set; }
    public DateTime CreatedAt { get; set; } =
      DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public required long TenantId { get; set; }
    public long? InvitedById { get; set; }
    public UserModel? InvitedBy { get; set; }

    public virtual required TenantModel Tenant { get; set; }

    public virtual ICollection<BuildingModel>? Buildings { get; set; }

    public virtual ICollection<ElevatorModel>? Elevators { get; set; }

    public virtual UserModel? InvitedUser { get; set; }

    public virtual ICollection<PendencyModel>? Pendencies { get; set; }
    */
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
        .HasColumnType("boolean")
        .HasDefaultValueSql("true");

      builder
        .Property(u =>
          u.PasswordChangedAt
        )
        .HasColumnType("datetime");

      builder
        .Property(u => u.CreatedAt)
        .IsRequired()
        .HasDefaultValueSql(
          "CURRENT_TIMESTAMP"
        );

      builder
        .Property(u => u.UpdatedAt)
        .HasColumnType("datetime");

      builder
        .Property(u => u.TenantId)
        .IsRequired()
        .HasColumnType("varchar(100)");

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
