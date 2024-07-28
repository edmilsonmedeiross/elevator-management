using System.Reflection;
using ElevatorManagementAPI.Api.Models;
using ElevatorManagementAPI.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ElevatorManagementAPI.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : IdentityDbContext<User, IdentityRole<long>, long>(options)
{
    public DbSet<AddressModel> Address { get; set; }
    public DbSet<AssigneeModel> Assignees { get; set; }
    public DbSet<BuildingModel> Buildings { get; set; }
    public DbSet<ElevatorModel> Elevators { get; set; }
    public DbSet<PendencyModel> Pendencies { get; set; }
    public DbSet<SubscriptionModel> Subscriptions { get; set; }
    public DbSet<TenantModel> Tenants { get; set; }
    public new DbSet<UserModel> Users { get; set; }
    public DbSet<VisitModel> Visits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
