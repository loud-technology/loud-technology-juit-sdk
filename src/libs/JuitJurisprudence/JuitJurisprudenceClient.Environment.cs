namespace Loud.Technology.Juit.Jurisprudence.Sdk;

public sealed partial class JuitJurisprudenceClient
{
    /// <summary>
    /// Creates an authenticated client from <c>JUIT_USERNAME</c>, <c>JUIT_PASSWORD</c>,
    /// and the optional <c>JUIT_BASE_URL</c> environment variable.
    /// </summary>
    public static JuitJurisprudenceClient CreateFromEnvironment(
        HttpClient? httpClient = null,
        bool disposeHttpClient = true)
    {
        var username = GetRequiredEnvironmentVariable("JUIT_USERNAME");
        var password = GetRequiredEnvironmentVariable("JUIT_PASSWORD");
        var baseUrl = Environment.GetEnvironmentVariable("JUIT_BASE_URL") ?? DefaultBaseUrl;

        if (!Uri.TryCreate(baseUrl, UriKind.Absolute, out var baseUri))
        {
            throw new InvalidOperationException("JUIT_BASE_URL must be a valid absolute URL.");
        }

        return new JuitJurisprudenceClient(
            username: username,
            password: password,
            httpClient: httpClient,
            baseUri: baseUri,
            disposeHttpClient: disposeHttpClient);
    }

    private static string GetRequiredEnvironmentVariable(string name) =>
        Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
            ? value
            : throw new InvalidOperationException($"The {name} environment variable is required.");
}
