using ElevatorManagementAPI.Api.Data;
using ElevatorManagementAPI.Domain.Handlers;
using ElevatorManagementAPI.Domain.Models;
using ElevatorManagementAPI.Domain.Requests.Tenants;
using ElevatorManagementAPI.Domain.Responses;
using ElevatorManagementAPI.Domain.Responses.Tenants;
using Microsoft.EntityFrameworkCore;

namespace ElevatorManagementAPI.Api.Handlers
{
    public class TenantHandler(AppDbContext context) : ITenantHandler
    {
        public async Task<Response<CreateTenantResponse>> CreateAsync(CreateTenantRequest request)
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

                var response = new CreateTenantResponse { Id = tenant.Id, Name = tenant.Name, };

                return new Response<CreateTenantResponse>(
                    response,
                    message: "Inquilino criado com sucesso"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Erro ao criar o inquilino");
            }
        }

        async Task<Response<TenantModel>> ITenantHandler.DeleteAsync(Guid id)
        {
            try
            {
                var tenant = await context.Tenants.FirstOrDefaultAsync(x => x.Id == id);

                if (tenant == null)
                {
                    return new Response<TenantModel>(null, 0, message: "Inquilino não encontrado");
                }

                context.Tenants.Remove(tenant);
                await context.SaveChangesAsync();

                return new Response<TenantModel>(tenant, message: "Inquilino deletado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Erro ao deletar o inquilino");
            }
        }

        public async Task<Response<List<TenantModel>>> GetAllAsync()
        {
            try
            {
                var tenants = await context.Tenants.ToListAsync();

                return new Response<List<TenantModel>>(
                    tenants,
                    message: "Inquilinos retornados com sucesso"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Erro ao retornar os inquilinos");
            }
        }

        async Task<Response<TenantModel>> ITenantHandler.GetByIdAsync(Guid id)
        {
            try
            {
                var tenant = await context.Tenants.FirstOrDefaultAsync(x => x.Id == id);

                if (tenant == null)
                {
                    return new Response<TenantModel>(null, 0, message: "Inquilino não encontrado");
                }

                return new Response<TenantModel>(
                    tenant,
                    message: "Inquilino retornado com sucesso"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Erro ao retornar o inquilino");
            }
        }

        async Task<Response<TenantModel>> ITenantHandler.UpdateAsync(
            Guid id,
            UpdateTenantRequest request
        )
        {
            try
            {
                var tenant = await context.Tenants.FirstOrDefaultAsync(x => x.Id == id);

                if (tenant == null)
                {
                    return new Response<TenantModel>(null, 0, message: "Inquilino não encontrado");
                }

                tenant.Name = request.Name ?? tenant.Name;
                tenant.Email = request.Email ?? tenant.Email;
                tenant.DocumentNumber = request.DocumentNumber ?? tenant.DocumentNumber;
                tenant.IsSubActive = request.IsSubActive ?? tenant.IsSubActive;
                tenant.UpdatedAt = DateTime.Now;
                tenant.TenantColor = request.TenantColor ?? tenant.TenantColor;
                tenant.TenantLogo = request.TenantLogo ?? tenant.TenantLogo;

                context.Tenants.Update(tenant);
                await context.SaveChangesAsync();

                return new Response<TenantModel>(
                    tenant,
                    message: "Inquilino atualizado com sucesso"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Erro ao atualizar o inquilino");
            }
        }
    }
}
