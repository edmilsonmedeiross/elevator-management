using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ElevatorManagementAPI.Api.Data.Mappings

{
  public class ElevatorMapping : IEntityTypeConfiguration<ElevatorModel>
  {
    public void Configure(EntityTypeBuilder<ElevatorModel> builder)
    {
      builder.ToTable("Elevators");

      builder.HasKey(e => e.Id);

      builder.Property(e => e.Type)
          .IsRequired()
          .HasConversion<string>()
          .HasColumnType("varchar(20)");

      builder.Property(e => e.Status)
          .IsRequired()
          .HasConversion<string>()
          .HasColumnType("varchar(50)");

      builder.Property(e => e.Technology)
          .IsRequired()
          .HasColumnType("varchar(100)");

      builder.Property(e => e.StopsNum)
          .IsRequired()
          .HasColumnType("int");

      builder.Property(e => e.Capacity)
          .HasColumnType("int");

      builder.Property(e => e.People)
          .HasColumnType("int");

      builder.Property(e => e.VelocityNum)
          .HasColumnType("int");

      builder.Property(e => e.FrequencyInversor)
          .HasColumnType("varchar(100)");

      builder.Property(e => e.Machine)
          .HasColumnType("varchar(100)");

      builder.Property(e => e.Command)
          .HasColumnType("varchar(100)");

      builder.Property(e => e.QttCables)
          .HasColumnType("int");

      builder.Property(e => e.CableGauge)
          .HasColumnType("int");

      builder.Property(e => e.IsHouseMachineLess)
          .HasColumnType("boolean");

      builder.Property(e => e.IsHouseMachineOnTop)
          .HasColumnType("boolean");

      builder.Property(e => e.Ipd)
          .HasColumnType("varchar(100)");

      builder.Property(e => e.Buttom)
          .HasColumnType("varchar(100)");

      builder.Property(e => e.OilType)
          .HasColumnType("varchar(100)");

      builder.Property(e => e.DoorOperator)
          .HasColumnType("varchar(100)");

      builder.Property(e => e.CreatedAt)
          .IsRequired()
          .HasDefaultValueSql("CURRENT_TIMESTAMP");

      builder.Property(e => e.UpdatedAt);

      builder.Property(e => e.BuildingId)
          .IsRequired()
          .HasColumnType("varchar(100)");

      builder.Property(e => e.TenantId)
          .IsRequired()
          .HasColumnType("varchar(100)");

      builder.HasOne(e => e.Building)
          .WithMany(b => b.Elevators)
          .HasForeignKey(e => e.BuildingId);

      builder.HasOne(e => e.Tenant)
          .WithMany(t => t.Elevators)
          .HasForeignKey(e => e.TenantId);

      builder.HasOne(e => e.User)
          .WithMany(u => u.Elevators)
          .HasForeignKey(e => e.UserId);
    }
  }
}
