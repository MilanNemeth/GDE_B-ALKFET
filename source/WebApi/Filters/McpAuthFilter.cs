namespace WebApi.Filters;

public class McpAuthFilter : IEndpointFilter
{
    private readonly string headerName;
    private readonly string[] headerKeys;

    public McpAuthFilter(IConfiguration config)
    {
        ArgumentNullException.ThrowIfNull(config, nameof(config));

        // Load the expected header name and key from configuration
        headerName = config.GetValue("Mcp:AuthN:Header", string.Empty);
        headerKeys = config.GetSection("Mcp:AuthN:Keys").Get<string[]>() ?? [];

        // Validate that the values are valid
        if (string.IsNullOrWhiteSpace(headerName))
            throw new InvalidOperationException("A valid header name must be provided in configuration.");
        if (headerKeys.Length < 1)
            throw new InvalidOperationException("At least one valid API key must be provided in configuration.");
    }

    public ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var headerPresent = context.HttpContext.Request.Headers.TryGetValue(headerName, out var receivedKey);

        if (!headerPresent || !headerKeys.Contains(receivedKey.ToString()))
        {
            return ValueTask.FromResult<object?>(Results.Unauthorized());
        }

        return next(context);
    }
}
