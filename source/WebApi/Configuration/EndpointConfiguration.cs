using WebApi.Endpoints;
using WebApi.Filters;

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

        var config = routes.ServiceProvider.GetRequiredService<IConfiguration>();
        routes.MapMcp("/mcp").AddEndpointFilter(new McpAuthFilter(config));
        routes.MapGroup("/hero").MapHeroEndpoints();

        return routes;
    }

}
