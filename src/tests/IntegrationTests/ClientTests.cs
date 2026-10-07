using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace Loud.Technology.Juit.Jurisprudence.Sdk.IntegrationTests;

[TestClass]
[DoNotParallelize]
public sealed class ClientTests
{
    [TestMethod]
    public void Constructor_ConfiguresDefaultBaseUrlAndBasicAuthentication()
    {
        using var client = new JuitJurisprudenceClient("client-id", "client-secret");

        client.BaseUri.Should().Be(new Uri(JuitJurisprudenceClient.DefaultBaseUrl));
        var authorization = client.Authorizations.Should().ContainSingle().Which;
        authorization.Type.Should().Be("Http");
        authorization.Location.Should().Be("Header");
        authorization.Name.Should().Be("Basic");
        authorization.Value.Should().Be(
            Convert.ToBase64String(Encoding.UTF8.GetBytes("client-id:client-secret")));
    }

    [TestMethod]
    public async Task GetJurisprudences_SendsBasicAuthenticationAndTypedFilters()
    {
        const string responseJson =
            """
            {
              "next_page_token": "next-token",
              "total": 1,
              "size": 1,
              "search_info": {
                "search_id": "18fa6ff2-7ce0-4000-8f1d-7444bafc2c00",
                "elapsed_time_in_ms": 42
              },
              "items": [
                {
                  "id": "decision-id",
                  "juit_id": "juit-id",
                  "court_code": "TJSP",
                  "title": "TJSP / Acórdão / 123",
                  "judgment_date": "2024-05-07T00:00:00Z",
                  "rimor_url": "https://rimor2.juit.io/busca_jurisprudencia/juit-id",
                  "artifacts": []
                }
              ]
            }
            """;
        using var handler = new RecordingHandler(JsonResponse(responseJson));
        using var httpClient = new HttpClient(handler);
        using var client = CreateClient(httpClient);

        var response = await client.GetJurisprudencesAsync(
            query: "dano moral",
            owner: "developer@example.com",
            searchOn: [GetJurisprudencesSearchOnItem.Title, GetJurisprudencesSearchOnItem.Headnote],
            nextPageToken: "previous-token",
            courtCode: ["TJSP"],
            degree: [GetJurisprudencesDegreeItem.x2ªInstância],
            processOriginState: [GetJurisprudencesProcessOriginStateItem.Sp]);

        handler.Method.Should().Be(HttpMethod.Get);
        handler.Authorization.Should().Be(
            new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(Encoding.UTF8.GetBytes("client-id:client-secret"))));
        handler.RequestUri.Should().NotBeNull();
        handler.RequestUri!.AbsolutePath.Should().Be("/v1/data-products/search/jurisprudence");
        handler.RequestUri.Query.Should().Contain("query=dano%20moral");
        handler.RequestUri.Query.Should().Contain("owner=developer%40example.com");
        handler.RequestUri.Query.Should().Contain("search_on=title");
        handler.RequestUri.Query.Should().Contain("search_on=headnote");
        handler.RequestUri.Query.Should().Contain("next_page_token=previous-token");
        handler.RequestUri.Query.Should().Contain("court_code=TJSP");
        handler.RequestUri.Query.Should().Contain("degree=2%C2%AA%20Inst%C3%A2ncia");
        handler.RequestUri.Query.Should().Contain("process_origin_state=SP");

        response.Total.Should().Be(1);
        response.SearchInfo!.ElapsedTimeInMs.Should().Be(42);
        var record = response.Items.Should().ContainSingle().Which;
        record.JuitId.Should().Be("juit-id");
        record.CourtCode.Should().Be("TJSP");
        record.JudgmentDate.Should().Be(new DateTime(2024, 5, 7, 0, 0, 0, DateTimeKind.Utc));
    }

    [TestMethod]
    public async Task DownloadJurisprudenceArtifact_ReturnsBytesAndEncodesQueryParameters()
    {
        var artifact = new byte[] { 0x25, 0x50, 0x44, 0x46 };
        using var handler = new RecordingHandler(
            new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(artifact),
            });
        using var httpClient = new HttpClient(handler);
        using var client = CreateClient(httpClient);

        var result = await client.DownloadJurisprudenceArtifactAsync(
            juitId: "juit-id",
            owner: "developer@example.com",
            filename: "acórdão 123.pdf");

        result.Should().Equal(artifact);
        handler.RequestUri!.AbsolutePath.Should().Be(
            "/v1/data-products/search/jurisprudence/juit-id/artifact");
        handler.RequestUri.Query.Should().Contain("owner=developer%40example.com");
        handler.RequestUri.Query.Should().Contain("filename=ac%C3%B3rd%C3%A3o%20123.pdf");
    }

    [TestMethod]
    public void CreateFromEnvironment_UsesCredentialsAndCustomBaseUrl()
    {
        var originalUsername = Environment.GetEnvironmentVariable("JUIT_USERNAME");
        var originalPassword = Environment.GetEnvironmentVariable("JUIT_PASSWORD");
        var originalBaseUrl = Environment.GetEnvironmentVariable("JUIT_BASE_URL");

        try
        {
            Environment.SetEnvironmentVariable("JUIT_USERNAME", "environment-client");
            Environment.SetEnvironmentVariable("JUIT_PASSWORD", "environment-secret");
            Environment.SetEnvironmentVariable("JUIT_BASE_URL", "https://juit.environment.example/api");

            using var client = JuitJurisprudenceClient.CreateFromEnvironment();

            client.BaseUri.Should().Be(new Uri("https://juit.environment.example/api"));
            client.Authorizations.Should().ContainSingle().Which.Value.Should().Be(
                Convert.ToBase64String(Encoding.UTF8.GetBytes("environment-client:environment-secret")));
        }
        finally
        {
            Environment.SetEnvironmentVariable("JUIT_USERNAME", originalUsername);
            Environment.SetEnvironmentVariable("JUIT_PASSWORD", originalPassword);
            Environment.SetEnvironmentVariable("JUIT_BASE_URL", originalBaseUrl);
        }
    }

    [TestMethod]
    public void GeneratedModels_ValidateDocumentIdAndPageSizeConstraints()
    {
        var recordResults = Validate(new JurisprudenceRecord { Id = string.Empty });
        var responseResults = Validate(new JurisprudenceSearchResponse { Size = 51 });

        recordResults.Should().Contain(result =>
            result.MemberNames.Contains(nameof(JurisprudenceRecord.Id)));
        responseResults.Should().Contain(result =>
            result.MemberNames.Contains(nameof(JurisprudenceSearchResponse.Size)));
    }

    private static List<ValidationResult> Validate(object value)
    {
        var results = new List<ValidationResult>();
        Validator.TryValidateObject(value, new ValidationContext(value), results, validateAllProperties: true);
        return results;
    }

    private static JuitJurisprudenceClient CreateClient(HttpClient httpClient) =>
        new(
            username: "client-id",
            password: "client-secret",
            httpClient: httpClient,
            baseUri: new Uri("https://juit.example/v1/data-products/search"),
            disposeHttpClient: false);

    private static HttpResponseMessage JsonResponse(string json) =>
        new(HttpStatusCode.OK)
        {
            Content = new StringContent(json, Encoding.UTF8, "application/json"),
        };

    private sealed class RecordingHandler(HttpResponseMessage response) : HttpMessageHandler, IDisposable
    {
        public HttpMethod? Method { get; private set; }
        public Uri? RequestUri { get; private set; }
        public AuthenticationHeaderValue? Authorization { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            Authorization = request.Headers.Authorization;
            response.RequestMessage = request;
            return Task.FromResult(response);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                response.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
