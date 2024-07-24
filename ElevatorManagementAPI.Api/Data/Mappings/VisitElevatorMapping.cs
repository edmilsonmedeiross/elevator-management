using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElevatorManagementAPI.Api.Data.Mappings
{
  public class VisitElevatorMapping
    : IEntityTypeConfiguration<VisitElevatorModel>
  {
    public void Configure(
      EntityTypeBuilder<VisitElevatorModel> builder
    )
    {
      builder.ToTable("VisitElevators");

      builder.HasKey(ve => new
      {
        ve.ElevatorId,
        ve.VisitId
      });

      builder
        .HasOne(ve => ve.Elevator)
        .WithMany(e => e.VisitElevators)
        .HasForeignKey(ve =>
          ve.ElevatorId
        );

      builder
        .HasOne(ve => ve.Visit)
        .WithMany(v => v.VisitElevators)
        .HasForeignKey(ve =>
          ve.VisitId
        );
    }
  }
}
