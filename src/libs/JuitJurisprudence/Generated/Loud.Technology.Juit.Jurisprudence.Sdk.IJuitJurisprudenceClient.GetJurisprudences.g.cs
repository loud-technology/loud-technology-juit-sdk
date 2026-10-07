#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    public partial interface IJuitJurisprudenceClient
    {
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceSearchResponse> GetJurisprudencesAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceSearchResponse>> GetJurisprudencesAsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}