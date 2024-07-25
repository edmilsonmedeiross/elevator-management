using ElevatorManagementAPI.Domain.Models;
using ElevatorManagementAPI.Domain.Requests.Tenants;
using ElevatorManagementAPI.Domain.Responses;

namespace ElevatorManagementAPI.Domain.Handlers
{
    public interface ITenantHandler
    {
        Task<Response<TenantModel>> CreateAsync(CreateTenantRequest request);
        Task<Response<List<TenantModel>>> GetAllAsync(Guid id);
        Task<Response<TenantModel>> GetByIdAsync();
        Task<Response<TenantModel>> DeleteAsync(Guid id);
    }
}
