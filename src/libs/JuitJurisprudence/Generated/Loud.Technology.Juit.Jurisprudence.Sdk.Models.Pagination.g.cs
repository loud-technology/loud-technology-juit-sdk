
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    /// Informações da paginação.
    /// </summary>
    public sealed partial class Pagination
    {
        /// <summary>
        /// O próximo token que deverá ser informado para relizar a paginação para a próxima página
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// O próximo token que deverá ser informado para relizar a paginação para a próxima página
        /// </param>
        /// <param name="total">
        /// Total de documentos retornados pela consulta.
        /// </param>
        /// <param name="size">
        /// Quantidade de documentos solicitados nessa requisição.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pagination(
            string? nextPageToken,
            int? total,
            int? size)
        {
            this.NextPageToken = nextPageToken;
            this.Total = total;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        public Pagination()
        {
        }

    }
}