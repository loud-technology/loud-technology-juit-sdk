
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JurisprudenceSearchResponse
    {
        /// <summary>
        /// O próximo token que deverá ser informado para realizar a paginação para a próxima página
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total de documentos retornados pela consulta.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Quantidade de documentos solicitados nessa requisição.
        /// </summary>
        [global::System.ComponentModel.DataAnnotations.Range(typeof(int), "0", "50")]
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Informações da busca.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_info")]
        public global::Loud.Technology.Juit.Jurisprudence.Sdk.SearchInfo? SearchInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceRecord>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JurisprudenceSearchResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// O próximo token que deverá ser informado para realizar a paginação para a próxima página
        /// </param>
        /// <param name="total">
        /// Total de documentos retornados pela consulta.
        /// </param>
        /// <param name="size">
        /// Quantidade de documentos solicitados nessa requisição.
        /// </param>
        /// <param name="searchInfo">
        /// Informações da busca.
        /// </param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JurisprudenceSearchResponse(
            string? nextPageToken,
            int? total,
            int? size,
            global::Loud.Technology.Juit.Jurisprudence.Sdk.SearchInfo? searchInfo,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceRecord>? items)
        {
            this.NextPageToken = nextPageToken;
            this.Total = total;
            this.Size = size;
            this.SearchInfo = searchInfo;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JurisprudenceSearchResponse" /> class.
        /// </summary>
        public JurisprudenceSearchResponse()
        {
        }

    }
}