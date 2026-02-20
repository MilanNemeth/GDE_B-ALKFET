using WebApi.Endpoints;

namespace WebApi.Configuration;

public static class EndpointConfiguration
{
    public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder routes, IWebHostEnvironment env)
    {
        // Configure the HTTP request pipeline for OpenAPI only in development to avoid exposing it in production
        if (env.IsDevelopment())
        {
            routes.MapOpenApi();
        }

        routes.MapGroup("/hero").MapHeroEndpoints();

        return routes;
    }

}
