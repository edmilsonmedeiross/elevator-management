using ElevatorManagementAPI.Domain.Models;
using ElevatorManagementAPI.Domain.Requests.Tenants;
using ElevatorManagementAPI.Domain.Responses;
using ElevatorManagementAPI.Domain.Responses.Tenants;

namespace ElevatorManagementAPI.Domain.Handlers
{
    public interface ITenantHandler
    {
        Task<Response<CreateTenantResponse>> CreateAsync(CreateTenantRequest request);
        Task<Response<List<TenantModel>>> GetAllAsync();
        Task<Response<TenantModel>> GetByIdAsync(Guid id);

        Task<Response<TenantModel>> UpdateAsync(Guid id, UpdateTenantRequest request);
        Task<Response<TenantModel>> DeleteAsync(Guid id);
    }
}
