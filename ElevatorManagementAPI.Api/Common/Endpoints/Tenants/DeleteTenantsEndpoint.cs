using ElevatorManagementAPI.Api.Common.Api;
using ElevatorManagementAPI.Domain.Handlers;
using ElevatorManagementAPI.Domain.Models;
using ElevatorManagementAPI.Domain.Requests.Tenants;
using ElevatorManagementAPI.Domain.Responses;

namespace ElevatorManagementAPI.Api.Common.Endpoints.Tenants
{
    public class DeleteTenantsEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
        {
            app.MapDelete("/{id}", HandleAsync)
                .WithName("DeleteTenant")
                .WithSummary("Delete a tenant")
                .WithDescription("Delete a tenant in the system.")
                .WithOrder(3)
                .Produces<Response<TenantModel>>();
        }

        private static async Task<IResult> HandleAsync(Guid id, ITenantHandler handler)
        {
            var result = await handler.DeleteAsync(id);
            return result.IsSuccess ? Results.Ok(result.Data) : Results.BadRequest(result.Data);
        }
    }
}
