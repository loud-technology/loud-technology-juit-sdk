
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    /// Artefato associado a uma jurisprudência.
    /// </summary>
    public sealed partial class Artifact
    {
        /// <summary>
        /// Checksum do arquivo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksum")]
        public string? Checksum { get; set; }

        /// <summary>
        /// Data de coleta do artefato.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collected_date")]
        public global::System.DateTime? CollectedDate { get; set; }

        /// <summary>
        /// Tipo de documento do artefato.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_type")]
        public string? DocumentType { get; set; }

        /// <summary>
        /// Indica se o artefato é original, ou seja, não foi modicado.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_original")]
        public bool? IsOriginal { get; set; }

        /// <summary>
        /// Tipo MIME do arquivo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Nome do arquivo do artefato.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        /// <param name="checksum">
        /// Checksum do arquivo.
        /// </param>
        /// <param name="collectedDate">
        /// Data de coleta do artefato.
        /// </param>
        /// <param name="documentType">
        /// Tipo de documento do artefato.
        /// </param>
        /// <param name="isOriginal">
        /// Indica se o artefato é original, ou seja, não foi modicado.
        /// </param>
        /// <param name="mimeType">
        /// Tipo MIME do arquivo.
        /// </param>
        /// <param name="filename">
        /// Nome do arquivo do artefato.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Artifact(
            string? checksum,
            global::System.DateTime? collectedDate,
            string? documentType,
            bool? isOriginal,
            string? mimeType,
            string? filename)
        {
            this.Checksum = checksum;
            this.CollectedDate = collectedDate;
            this.DocumentType = documentType;
            this.IsOriginal = isOriginal;
            this.MimeType = mimeType;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        public Artifact()
        {
        }

    }
}