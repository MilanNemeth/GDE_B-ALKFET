using System;
using Domain;

namespace WebApi.Filters;

public class RequestValidationFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        // REQUEST INTERCEPTION
        // Validate request before calling any handlers
        Hero hero = context.Arguments.OfType<Hero>().Single();
        if (hero.Id < 1 ||
            string.IsNullOrWhiteSpace(hero.Name)) return Results.BadRequest("Incorrect hero data.");

        // If validation passes, call the next handler(s)
        object? result = await next(context);
        // RESPONSE INTERCEPTION
        // After the next handler(s) returned, we could even modify the response before it goes back to the client
        return result;
    }
}
