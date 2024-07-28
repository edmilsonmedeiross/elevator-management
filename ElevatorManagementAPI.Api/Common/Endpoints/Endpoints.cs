using ElevatorManagementAPI.Api.Common.Endpoints.Tenants;

namespace ElevatorManagementAPI.Api.Common.Api
{
    public static class Endpoints
    {
        public static void MapEndpoints(this WebApplication app)
        {
            var endpoints = app.MapGroup("");

            endpoints
                .MapGroup("v1/tenants")
                .WithTags("Tenants")
                .MapEndpoint<CreateTenantsEndpoint>()
                .MapEndpoint<GetAllTenantsEndpoint>()
                .MapEndpoint<GetTenantByIdEndpoint>()
                .MapEndpoint<UpdateTenantsEndpoint>()
                .MapEndpoint<DeleteTenantsEndpoint>();
        }

        private static IEndpointRouteBuilder MapEndpoint<T>(this IEndpointRouteBuilder app)
            where T : IEndpoint
        {
            T.Map(app);
            return app;
        }
    }
}
