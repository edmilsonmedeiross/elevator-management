namespace ElevatorManagementAPI.Api.Datas;

using ElevatorManagementAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContextS : DbContext
{
  public AppDbContextS(DbContextOptions<AppDbContextS> options)
    : base(options) { }

  public DbSet<TenantModel> Tenants => Set<TenantModel>();
}
