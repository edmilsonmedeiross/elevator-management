using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ElevatorManagementAPI.Api.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }

  public DbSet<AddressModel> Address { get; set; }
  public DbSet<AssigneeModel> Assignees { get; set; }
  public DbSet<BuildingModel> Buildings { get; set; }
  public DbSet<ElevatorModel> Elevators { get; set; }
  public DbSet<PendencyModel> Pendencies { get; set; }
  public DbSet<SubscriptionModel> Subscriptions { get; set; }
  public DbSet<TenantModel> Tenants { get; set; }
  public DbSet<UserModel> Users { get; set; }
  public DbSet<VisitElevatorModel> VisitsElevators { get; set; }
  public DbSet<VisitModel> Visits { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfiguration();
  }
}
