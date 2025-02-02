using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevatorManagementAPI.Api.Data.Mappings
{
  public class VisitMapping
    : IEntityTypeConfiguration<VisitModel>
  {
    public void Configure(
      EntityTypeBuilder<VisitModel> builder
    )
    {
      builder.ToTable("Visits");

      builder.HasKey(v => v.Id);

      builder
        .Property(v => v.Type)
        .IsRequired()
        .HasConversion<string>()
        .HasColumnType("varchar(20)");

      builder
        .Property(v => v.Description)
        .IsRequired()
        .HasColumnType("varchar(200)");

      builder
        .Property(v => v.Problem)
        .IsRequired()
        .HasColumnType("varchar(100)");

      builder
        .Property(v =>
          v.IsPassengerStucked
        )
        .IsRequired()
        .HasColumnType("boolean");

      builder
        .Property(v => v.Status)
        .IsRequired()
        .HasConversion<string>()
        .HasColumnType("varchar(20)");

      builder
        .Property(v =>
          v.ElevatorStatusPre
        )
        .IsRequired()
        .HasConversion<string>()
        .HasColumnType("varchar(50)");

      builder
        .Property(v =>
          v.ElevatorStatusPos
        )
        .HasConversion<string>()
        .HasColumnType("varchar(50)");

      builder
        .Property(v => v.CurrentFloor)
        .HasColumnType("int");

      builder
        .Property(v => v.ClosedAt)
        .HasColumnType("datetime");

      builder
        .Property(v => v.CreatedAt)
        .IsRequired()
        .HasColumnType("datetime");

      builder
        .Property(v => v.UpdatedAt)
        .HasColumnType("datetime");

      builder
        .Property(v => v.UserId)
        .IsRequired()
        .HasColumnType("TEXT");

      builder
        .Property(v => v.BuildingId)
        .IsRequired()
        .HasColumnType("TEXT");

      builder
        .Property(v => v.TenantId)
        .IsRequired()
        .HasColumnType("TEXT");

      builder
        .HasOne(v => v.User)
        .WithMany()
        .HasForeignKey(v => v.UserId);

      builder
        .HasOne(v => v.Building)
        .WithMany()
        .HasForeignKey(v =>
          v.BuildingId
        );

      builder
        .HasOne(v => v.Tenant)
        .WithMany()
        .HasForeignKey(v => v.TenantId);

      builder
        .HasMany(e => e.Elevators)
        .WithMany(v => v.Visits)
        .UsingEntity<
          Dictionary<string, object>
        >(
          "VisitsElevators",
          j =>
            j.HasOne<ElevatorModel>()
              .WithMany()
              .HasForeignKey(
                "ElevatorId"
              )
              .HasConstraintName(
                "FK_VisitElevators_Elevators_ElevatorModelId"
              )
              .OnDelete(
                DeleteBehavior.Cascade
              ),
          j =>
            j.HasOne<VisitModel>()
              .WithMany()
              .HasForeignKey("VisitId")
              .HasConstraintName(
                "FK_VisitElevators_Visits_VisitModelId"
              )
              .OnDelete(
                DeleteBehavior.Cascade
              )
        );
    }
  }
}
