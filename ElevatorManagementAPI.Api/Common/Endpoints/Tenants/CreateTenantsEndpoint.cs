using ElevatorManagementAPI.Api.Common.Api;
using ElevatorManagementAPI.Domain.Handlers;
using ElevatorManagementAPI.Domain.Requests.Tenants;
using ElevatorManagementAPI.Domain.Responses;
using ElevatorManagementAPI.Domain.Responses.Tenants;

namespace ElevatorManagementAPI.Api.Common.Endpoints.Tenants
{
    public class CreateTenantsEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
        {
            app.MapPost("/", HandleAsync)
                .WithName("CreateTenant")
                .WithSummary("Create a new tenant")
                .WithDescription("Create a new tenant in the system.")
                .WithOrder(1)
                .Produces<Response<CreateTenantResponse>>();
        }

        private static async Task<IResult> HandleAsync(
            CreateTenantRequest request,
            ITenantHandler handler
        )
        {
            var result = await handler.CreateAsync(request);
            return result.IsSuccess
                ? Results.Created($"/{result.Data?.Id}", result.Data)
                : Results.BadRequest(result.Data);
        }
    }
}
