#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    public partial interface IJuitJurisprudenceClient
    {
        /// <summary>
        /// Baixar artefato de jurisprudência<br/>
        /// Download de um artefato específico associado a uma jurisprudência.
        /// </summary>
        /// <param name="juitId"></param>
        /// <param name="owner"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadJurisprudenceArtifactAsync(
            string juitId,
            string owner,
            string filename,
            global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Baixar artefato de jurisprudência<br/>
        /// Download de um artefato específico associado a uma jurisprudência.
        /// </summary>
        /// <param name="juitId"></param>
        /// <param name="owner"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> DownloadJurisprudenceArtifactAsStreamAsync(
            string juitId,
            string owner,
            string filename,
            global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Baixar artefato de jurisprudência<br/>
        /// Download de um artefato específico associado a uma jurisprudência.
        /// </summary>
        /// <param name="juitId"></param>
        /// <param name="owner"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Juit.Jurisprudence.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKHttpResponse<byte[]>> DownloadJurisprudenceArtifactAsResponseAsync(
            string juitId,
            string owner,
            string filename,
            global::Loud.Technology.Juit.Jurisprudence.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}