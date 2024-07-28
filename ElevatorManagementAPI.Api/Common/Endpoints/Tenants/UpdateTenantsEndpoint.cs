using ElevatorManagementAPI.Api.Common.Api;
using ElevatorManagementAPI.Domain.Handlers;
using ElevatorManagementAPI.Domain.Models;
using ElevatorManagementAPI.Domain.Requests.Tenants;
using ElevatorManagementAPI.Domain.Responses;
using ElevatorManagementAPI.Domain.Responses.Tenants;

namespace ElevatorManagementAPI.Api.Common.Endpoints.Tenants
{
    public class UpdateTenantsEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
        {
            app.MapPut("/{id}", HandleAsync)
                .WithName("UpdateTenant")
                .WithSummary("Update a tenant")
                .WithDescription("Update a tenant in the system.")
                .WithOrder(2)
                .Produces<Response<TenantModel>>();
        }

        private static async Task<IResult> HandleAsync(
            Guid id,
            UpdateTenantRequest request,
            ITenantHandler handler
        )
        {
            var result = await handler.UpdateAsync(id, request);
            return result.IsSuccess ? Results.Ok(result.Data) : Results.BadRequest(result.Data);
        }
    }
}
