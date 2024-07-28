using ElevatorManagementAPI.Api.Common.Api;
using ElevatorManagementAPI.Domain.Handlers;
using ElevatorManagementAPI.Domain.Models;
using ElevatorManagementAPI.Domain.Responses;

namespace ElevatorManagementAPI.Api.Common.Endpoints.Tenants
{
    public class GetTenantByIdEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
        {
            app.MapGet("/{id}", HandleAsync)
                .WithName("GetTenantById")
                .WithSummary("Get a tenant by id")
                .WithDescription("Get a tenant by id in the system.")
                .WithOrder(4)
                .Produces<Response<TenantModel>>();
        }

        private static async Task<IResult> HandleAsync(Guid id, ITenantHandler handler)
        {
            var result = await handler.GetByIdAsync(id);
            return result.IsSuccess ? Results.Ok(result.Data) : Results.BadRequest(result.Data);
        }
    }
}
