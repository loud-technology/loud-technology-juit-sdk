
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    /// Informações da busca.
    /// </summary>
    public sealed partial class SearchInfo
    {
        /// <summary>
        /// O ID da busca. Retorando pela própria API e não precisa ser fornecido na primeira solicitação.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_id")]
        public string? SearchId { get; set; }

        /// <summary>
        /// Tempo da execução da requisição em millisegundos.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_time_in_ms")]
        public int? ElapsedTimeInMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchInfo" /> class.
        /// </summary>
        /// <param name="searchId">
        /// O ID da busca. Retorando pela própria API e não precisa ser fornecido na primeira solicitação.
        /// </param>
        /// <param name="elapsedTimeInMs">
        /// Tempo da execução da requisição em millisegundos.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchInfo(
            string? searchId,
            int? elapsedTimeInMs)
        {
            this.SearchId = searchId;
            this.ElapsedTimeInMs = elapsedTimeInMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchInfo" /> class.
        /// </summary>
        public SearchInfo()
        {
        }

    }
}