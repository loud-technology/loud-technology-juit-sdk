
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    public partial class JuitJurisprudenceClient
    {


        private static readonly global::Loud.Technology.Juit.Jurisprudence.Sdk.EndPointSecurityRequirement s_GetJurisprudencesSecurityRequirement0 =
            new global::Loud.Technology.Juit.Jurisprudence.Sdk.EndPointSecurityRequirement
            {
                Authorizations = new global::Loud.Technology.Juit.Jurisprudence.Sdk.EndPointAuthorizationRequirement[]
                {                    new global::Loud.Technology.Juit.Jurisprudence.Sdk.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BasicAuth",
                        Location = "Header",
                        Name = "Basic",
                        FriendlyName = "Basic",
                    },
                },
            };
        private static readonly global::Loud.Technology.Juit.Jurisprudence.Sdk.EndPointSecurityRequirement[] s_GetJurisprudencesSecurityRequirements =
            new global::Loud.Technology.Juit.Jurisprudence.Sdk.EndPointSecurityRequirement[]
            {                s_GetJurisprudencesSecurityRequirement0,
            };
        partial void PrepareGetJurisprudencesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string query,
            ref string owner,
            ref string? searchId,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSearchOnItem> searchOn,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDisableSynonymOnItem>? disableSynonymOn,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByFieldItem>? sortByField,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByDirectionItem>? sortByDirection,
            ref string? nextPageToken,
            global::System.Collections.Generic.IList<string>? orderDate,
            global::System.Collections.Generic.IList<string>? judgmentDate,
            global::System.Collections.Generic.IList<string>? publicationDate,
            global::System.Collections.Generic.IList<string>? releaseDate,
            global::System.Collections.Generic.IList<string>? signatureDate,
            global::System.Collections.Generic.IList<string>? courtCode,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDegreeItem>? degree,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesProcessOriginStateItem>? processOriginState,
            global::System.Collections.Generic.IList<string>? district,
            global::System.Collections.Generic.IList<string>? documentMatterList,
            global::System.Collections.Generic.IList<string>? processClassNameList,
            global::System.Collections.Generic.IList<string>? judgmentBody,
            global::System.Collections.Generic.IList<string>? trier,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDocumentTypeItem>? documentType,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem>? justiceType);
        partial void PrepareGetJurisprudencesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string query,
            string owner,
            string? searchId,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSearchOnItem> searchOn,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDisableSynonymOnItem>? disableSynonymOn,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByFieldItem>? sortByField,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByDirectionItem>? sortByDirection,
            string? nextPageToken,
            global::System.Collections.Generic.IList<string>? orderDate,
            global::System.Collections.Generic.IList<string>? judgmentDate,
            global::System.Collections.Generic.IList<string>? publicationDate,
            global::System.Collections.Generic.IList<string>? releaseDate,
            global::System.Collections.Generic.IList<string>? signatureDate,
            global::System.Collections.Generic.IList<string>? courtCode,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDegreeItem>? degree,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesProcessOriginStateItem>? processOriginState,
            global::System.Collections.Generic.IList<string>? district,
            global::System.Collections.Generic.IList<string>? documentMatterList,
            global::System.Collections.Generic.IList<string>? processClassNameList,
            global::System.Collections.Generic.IList<string>? judgmentBody,
            global::System.Collections.Generic.IList<string>? trier,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDocumentTypeItem>? documentType,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem>? justiceType);
        partial void ProcessGetJurisprudencesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetJurisprudencesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Buscar jurisprudências<br/>
        /// Esse endpoint realiza a busca na base da JUIT e retorna 10 jurisprudências.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="owner"></param>
        /// <param name="searchId"></param>
        /// <param name="searchOn"></param>
        /// <param name="disableSynonymOn"></param>
        /// <param name="sortByField">
        /// Default Value: [score, juit_id]
        /// </param>
        /// <param name="sortByDirection">
        /// Default Value: [desc, desc]
        /// </param>
        /// <param name="nextPageToken"></param>
        /// <param name="orderDate"></param>
        /// <param name="judgmentDate"></param>
        /// <param name="publicationDate"></param>
        /// <param name="releaseDate"></param>
        /// <param name="signatureDate"></param>
        /// <param name="courtCode"></param>
        /// <param name="degree"></param>
        /// <param name="processOriginState"></param>
        /// <param name="district"></param>
        /// <param name="documentMatterList"></param>
        /// <param name="processClassNameList"></param>
        /// <param name="judgmentBody"></param>
        /// <param name="trier"></param>
        /// <param name="documentType"></param>
        /// <param name="justiceType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceSearchResponse> GetJurisprudencesAsync(
            string query,
            string owner,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSearchOnItem> searchOn,
            string? searchId = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDisableSynonymOnItem>? disableSynonymOn = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByFieldItem>? sortByField = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByDirectionItem>? sortByDirection = default,
            string? nextPageToken = default,
            global::System.Collections.Generic.IList<string>? orderDate = default,
            global::System.Collections.Generic.IList<string>? judgmentDate = default,
            global::System.Collections.Generic.IList<string>? publicationDate = default,
            global::System.Collections.Generic.IList<string>? releaseDate = default,
            global::System.Collections.Generic.IList<string>? signatureDate = default,
            global::System.Collections.Generic.IList<string>? courtCode = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDegreeItem>? degree = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesProcessOriginStateItem>? processOriginState = default,
            global::System.Collections.Generic.IList<string>? district = default,
            global::System.Collections.Generic.IList<string>? documentMatterList = default,
            global::System.Collections.Generic.IList<string>? processClassNameList = default,
            global::System.Collections.Generic.IList<string>? judgmentBody = default,
            global::System.Collections.Generic.IList<string>? trier = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDocumentTypeItem>? documentType = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem>? justiceType = default,
            global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetJurisprudencesAsResponseAsync(
                query: query,
                owner: owner,
                searchOn: searchOn,
                searchId: searchId,
                disableSynonymOn: disableSynonymOn,
                sortByField: sortByField,
                sortByDirection: sortByDirection,
                nextPageToken: nextPageToken,
                orderDate: orderDate,
                judgmentDate: judgmentDate,
                publicationDate: publicationDate,
                releaseDate: releaseDate,
                signatureDate: signatureDate,
                courtCode: courtCode,
                degree: degree,
                processOriginState: processOriginState,
                district: district,
                documentMatterList: documentMatterList,
                processClassNameList: processClassNameList,
                judgmentBody: judgmentBody,
                trier: trier,
                documentType: documentType,
                justiceType: justiceType,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Buscar jurisprudências<br/>
        /// Esse endpoint realiza a busca na base da JUIT e retorna 10 jurisprudências.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="owner"></param>
        /// <param name="searchId"></param>
        /// <param name="searchOn"></param>
        /// <param name="disableSynonymOn"></param>
        /// <param name="sortByField">
        /// Default Value: [score, juit_id]
        /// </param>
        /// <param name="sortByDirection">
        /// Default Value: [desc, desc]
        /// </param>
        /// <param name="nextPageToken"></param>
        /// <param name="orderDate"></param>
        /// <param name="judgmentDate"></param>
        /// <param name="publicationDate"></param>
        /// <param name="releaseDate"></param>
        /// <param name="signatureDate"></param>
        /// <param name="courtCode"></param>
        /// <param name="degree"></param>
        /// <param name="processOriginState"></param>
        /// <param name="district"></param>
        /// <param name="documentMatterList"></param>
        /// <param name="processClassNameList"></param>
        /// <param name="judgmentBody"></param>
        /// <param name="trier"></param>
        /// <param name="documentType"></param>
        /// <param name="justiceType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceSearchResponse>> GetJurisprudencesAsResponseAsync(
            string query,
            string owner,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSearchOnItem> searchOn,
            string? searchId = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDisableSynonymOnItem>? disableSynonymOn = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByFieldItem>? sortByField = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByDirectionItem>? sortByDirection = default,
            string? nextPageToken = default,
            global::System.Collections.Generic.IList<string>? orderDate = default,
            global::System.Collections.Generic.IList<string>? judgmentDate = default,
            global::System.Collections.Generic.IList<string>? publicationDate = default,
            global::System.Collections.Generic.IList<string>? releaseDate = default,
            global::System.Collections.Generic.IList<string>? signatureDate = default,
            global::System.Collections.Generic.IList<string>? courtCode = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDegreeItem>? degree = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesProcessOriginStateItem>? processOriginState = default,
            global::System.Collections.Generic.IList<string>? district = default,
            global::System.Collections.Generic.IList<string>? documentMatterList = default,
            global::System.Collections.Generic.IList<string>? processClassNameList = default,
            global::System.Collections.Generic.IList<string>? judgmentBody = default,
            global::System.Collections.Generic.IList<string>? trier = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDocumentTypeItem>? documentType = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem>? justiceType = default,
            global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetJurisprudencesArguments(
                httpClient: HttpClient,
                query: ref query,
                owner: ref owner,
                searchId: ref searchId,
                searchOn: searchOn,
                disableSynonymOn: disableSynonymOn,
                sortByField: sortByField,
                sortByDirection: sortByDirection,
                nextPageToken: ref nextPageToken,
                orderDate: orderDate,
                judgmentDate: judgmentDate,
                publicationDate: publicationDate,
                releaseDate: releaseDate,
                signatureDate: signatureDate,
                courtCode: courtCode,
                degree: degree,
                processOriginState: processOriginState,
                district: district,
                documentMatterList: documentMatterList,
                processClassNameList: processClassNameList,
                judgmentBody: judgmentBody,
                trier: trier,
                documentType: documentType,
                justiceType: justiceType);


            var __authorizations = global::Loud.Technology.Juit.Jurisprudence.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetJurisprudencesSecurityRequirements,
                operationName: "GetJurisprudencesAsync");

            using var __timeoutCancellationTokenSource = global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Loud.Technology.Juit.Jurisprudence.Sdk.PathBuilder(
                                path: "/jurisprudence",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("query", query)
                                .AddRequiredParameter("owner", owner)
                                .AddOptionalParameter("search_id", searchId)
                                .AddRequiredParameter("search_on", searchOn, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("disable_synonym_on", disableSynonymOn, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("sort_by_field", sortByField, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("sort_by_direction", sortByDirection, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("next_page_token", nextPageToken)
                                .AddOptionalParameter("order_date", orderDate, delimiter: ",", explode: true)
                                .AddOptionalParameter("judgment_date", judgmentDate, delimiter: ",", explode: true)
                                .AddOptionalParameter("publication_date", publicationDate, delimiter: ",", explode: true)
                                .AddOptionalParameter("release_date", releaseDate, delimiter: ",", explode: true)
                                .AddOptionalParameter("signature_date", signatureDate, delimiter: ",", explode: true)
                                .AddOptionalParameter("court_code", courtCode, delimiter: ",", explode: true)
                                .AddOptionalParameter("degree", degree, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("process_origin_state", processOriginState, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("district", district, delimiter: ",", explode: true)
                                .AddOptionalParameter("document_matter_list", documentMatterList, delimiter: ",", explode: true)
                                .AddOptionalParameter("process_class_name_list", processClassNameList, delimiter: ",", explode: true)
                                .AddOptionalParameter("judgment_body", judgmentBody, delimiter: ",", explode: true)
                                .AddOptionalParameter("trier", trier, delimiter: ",", explode: true)
                                .AddOptionalParameter("document_type", documentType, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("justice_type", justiceType, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetJurisprudencesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    query: query!,
                    owner: owner!,
                    searchId: searchId,
                    searchOn: searchOn!,
                    disableSynonymOn: disableSynonymOn,
                    sortByField: sortByField,
                    sortByDirection: sortByDirection,
                    nextPageToken: nextPageToken,
                    orderDate: orderDate,
                    judgmentDate: judgmentDate,
                    publicationDate: publicationDate,
                    releaseDate: releaseDate,
                    signatureDate: signatureDate,
                    courtCode: courtCode,
                    degree: degree,
                    processOriginState: processOriginState,
                    district: district,
                    documentMatterList: documentMatterList,
                    processClassNameList: processClassNameList,
                    judgmentBody: judgmentBody,
                    trier: trier,
                    documentType: documentType,
                    justiceType: justiceType);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetJurisprudences",
                                methodName: "GetJurisprudencesAsync",
                                pathTemplate: "\"/jurisprudence\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetJurisprudences",
                                methodName: "GetJurisprudencesAsync",
                                pathTemplate: "\"/jurisprudence\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetJurisprudences",
                                methodName: "GetJurisprudencesAsync",
                                pathTemplate: "\"/jurisprudence\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetJurisprudencesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetJurisprudences",
                                methodName: "GetJurisprudencesAsync",
                                pathTemplate: "\"/jurisprudence\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetJurisprudences",
                                methodName: "GetJurisprudencesAsync",
                                pathTemplate: "\"/jurisprudence\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad Request response
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Loud.Technology.Juit.Jurisprudence.Sdk.Error? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Loud.Technology.Juit.Jurisprudence.Sdk.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Loud.Technology.Juit.Jurisprudence.Sdk.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException<global::Loud.Technology.Juit.Jurisprudence.Sdk.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Forbidden response
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Loud.Technology.Juit.Jurisprudence.Sdk.Error? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Loud.Technology.Juit.Jurisprudence.Sdk.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Loud.Technology.Juit.Jurisprudence.Sdk.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException<global::Loud.Technology.Juit.Jurisprudence.Sdk.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unprocessably content error response
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Loud.Technology.Juit.Jurisprudence.Sdk.Error? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Loud.Technology.Juit.Jurisprudence.Sdk.Error.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Loud.Technology.Juit.Jurisprudence.Sdk.Error.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException<global::Loud.Technology.Juit.Jurisprudence.Sdk.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Server internal error response
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Loud.Technology.Juit.Jurisprudence.Sdk.Error? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Loud.Technology.Juit.Jurisprudence.Sdk.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Loud.Technology.Juit.Jurisprudence.Sdk.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException<global::Loud.Technology.Juit.Jurisprudence.Sdk.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetJurisprudencesResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceSearchResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceSearchResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceSearchResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceSearchResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}