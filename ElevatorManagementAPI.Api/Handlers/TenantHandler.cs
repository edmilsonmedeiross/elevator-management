using ElevatorManagementAPI.Api.Data;
using ElevatorManagementAPI.Domain.Handlers;
using ElevatorManagementAPI.Domain.Models;
using ElevatorManagementAPI.Domain.Requests.Tenants;
using ElevatorManagementAPI.Domain.Responses;

namespace ElevatorManagementAPI.Api.Handlers
{
    public class TenantHandler(AppDbContext context) : ITenantHandler
    {
        public async Task<Response<TenantModel>> CreateAsync(CreateTenantRequest request)
        {
            try
            {
                var tenant = new TenantModel
                {
                    Name = request.Name,
                    Email = request.Email,
                    DocumentNumber = request.DocumentNumber,
                };

                await context.Tenants.AddAsync(tenant);
                await context.SaveChangesAsync();

                return new Response<TenantModel>(tenant);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Erro ao criar o inquilino");
            }
        }

        Task<Response<TenantModel>> ITenantHandler.DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<Response<List<TenantModel>>> ITenantHandler.GetAllAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<Response<TenantModel>> ITenantHandler.GetByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
