namespace Loud.Technology.Juit.Jurisprudence.Sdk.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static JuitJurisprudenceClient GetAuthenticatedClient()
    {
        if (Environment.GetEnvironmentVariable("JUIT_USERNAME") is not { Length: > 0 } ||
            Environment.GetEnvironmentVariable("JUIT_PASSWORD") is not { Length: > 0 })
        {
            throw new AssertInconclusiveException(
                "JUIT_USERNAME and JUIT_PASSWORD environment variables are not set.");
        }

        return JuitJurisprudenceClient.CreateFromEnvironment();
    }
}
