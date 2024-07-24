using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevatorManagementAPI.Api.Data.Mappings
{
  public class SubscriptionMapping
    : IEntityTypeConfiguration<SubscriptionModel>
  {
    public void Configure(
      EntityTypeBuilder<SubscriptionModel> builder
    )
    {
      builder.ToTable("Subscriptions");

      builder.HasKey(s => s.Id);

      builder
        .Property(s =>
          s.StripeSubscriptionId
        )
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .Property(s => s.PlanID)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .Property(s => s.Status)
        .IsRequired()
        .HasConversion<string>()
        .HasColumnType("varchar(20)");

      builder
        .Property(s => s.IsActive)
        .IsRequired()
        .HasColumnType("boolean")
        .HasDefaultValueSql("false");

      builder
        .Property(s => s.CreatedAt)
        .IsRequired()
        .HasDefaultValueSql(
          "CURRENT_TIMESTAMP"
        );

      builder
        .Property(s => s.UpdatedAt)
        .HasColumnType("datetime");

      builder
        .Property(s => s.TenantId)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .HasOne(s => s.Tenant)
        .WithMany(t => t.Subscriptions)
        .HasForeignKey(s => s.TenantId);
    }
  }
}
