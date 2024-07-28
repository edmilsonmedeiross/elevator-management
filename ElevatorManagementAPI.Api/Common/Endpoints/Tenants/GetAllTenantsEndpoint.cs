using ElevatorManagementAPI.Api.Common.Api;
using ElevatorManagementAPI.Domain.Handlers;
using ElevatorManagementAPI.Domain.Models;
using ElevatorManagementAPI.Domain.Responses;

namespace ElevatorManagementAPI.Api.Common.Endpoints.Tenants
{
    public class GetAllTenantsEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
        {
            app.MapGet("/", HandleAsync)
                .WithName("GetAllTenants")
                .WithSummary("Get all tenants")
                .WithDescription("Get all tenants in the system.")
                .WithOrder(5)
                .Produces<Response<TenantModel>>();
        }

        private static async Task<IResult> HandleAsync(ITenantHandler handler)
        {
            var result = await handler.GetAllAsync();
            return result.IsSuccess ? Results.Ok(result.Data) : Results.BadRequest(result.Data);
        }
    }
}
