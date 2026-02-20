using System.Text.Json;
using System.Text.Json.Serialization;
using DataAccess;
using WebApi.Repos;

namespace WebApi.Configuration;

public static class AppConfiguration
{
    internal const string AllowAnyOrigin = "AllowAnyOrigin";

    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        // Add services to the container.
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        services.AddOpenApi();

        // Configure JSON options to be more flexible and consistent with common API practices
        services.ConfigureHttpJsonOptions(options =>
        {
            options.SerializerOptions.AllowTrailingCommas = true;
            options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
        });

        // Allow cross-origin requests from the UI running on different ports during development/deployment
        services.AddCors(options =>
        {
            options.AddPolicy(AllowAnyOrigin, policy =>
                policy.AllowAnyOrigin()
                      .AllowAnyHeader()
                      .AllowAnyMethod());
        });


        return services;
    }

    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        services.AddSingleton<IMongoDbConnectionFactory, MongoDbConnectionFactory>();
        services.AddScoped<IHeroRepository, HeroRepository>();

        return services;
    }

    public static IApplicationBuilder ConfigureApp(this IApplicationBuilder app)
    {
        app.UseCors(AllowAnyOrigin);

        return app;
    }
}
