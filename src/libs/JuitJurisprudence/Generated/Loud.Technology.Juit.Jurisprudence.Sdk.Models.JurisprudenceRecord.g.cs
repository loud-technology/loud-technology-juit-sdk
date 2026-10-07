
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    /// Jurisprudência.
    /// </summary>
    public sealed partial class JurisprudenceRecord
    {
        /// <summary>
        /// ID da decisão.
        /// </summary>
        [global::System.ComponentModel.DataAnnotations.MinLength(1)]
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// ID da decisão gerado pela JUIT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("juit_id")]
        public string? JuitId { get; set; }

        /// <summary>
        /// Número do processo no padrão CNJ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnj_unique_number")]
        public string? CnjUniqueNumber { get; set; }

        /// <summary>
        /// Código do tribunal no qual foi julgado.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("court_code")]
        public string? CourtCode { get; set; }

        /// <summary>
        /// Grau no qual foi julgado.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("degree")]
        public string? Degree { get; set; }

        /// <summary>
        /// Comarca de origem do recurso.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("district")]
        public string? District { get; set; }

        /// <summary>
        /// Lista com assuntos baseado na TPU do CNJ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_matter_list")]
        public global::System.Collections.Generic.IList<string>? DocumentMatterList { get; set; }

        /// <summary>
        /// Tipo de documento do julgado.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_type")]
        public string? DocumentType { get; set; }

        /// <summary>
        /// Texto do inteiro teor do julgado.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_text")]
        public string? FullText { get; set; }

        /// <summary>
        /// Ementa do julgado.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headnote")]
        public string? Headnote { get; set; }

        /// <summary>
        /// Órgão responsável pelo julgamento.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judgment_body")]
        public string? JudgmentBody { get; set; }

        /// <summary>
        /// Classes da ação definidas pelo tribunal ou recurso.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("process_class_name_list")]
        public global::System.Collections.Generic.IList<string>? ProcessClassNameList { get; set; }

        /// <summary>
        /// Estado de origem do julgado.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("process_origin_state")]
        public string? ProcessOriginState { get; set; }

        /// <summary>
        /// Data de julgamento do processo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judgment_date")]
        public global::System.DateTime? JudgmentDate { get; set; }

        /// <summary>
        /// Data de publicação do julgado.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publication_date")]
        public global::System.DateTime? PublicationDate { get; set; }

        /// <summary>
        /// Data de disponibilização do documento.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        public global::System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Data de assinatura do documento.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature_date")]
        public global::System.DateTime? SignatureDate { get; set; }

        /// <summary>
        /// Tem o valor de uma das datas para facilitar a visualização de data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_date")]
        public global::System.DateTime? OrderDate { get; set; }

        /// <summary>
        /// O título do documento que é exibido na aplicação.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Julgador responsável pelo caso, pode ser um Juiz, Desembargador ou Ministro.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trier")]
        public string? Trier { get; set; }

        /// <summary>
        /// Indica o tipo de justiça que o processo pertence, podendo ser Juizado Especial e Juízo Comum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("justice_type")]
        public string? JusticeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rimor_url")]
        public string? RimorUrl { get; set; }

        /// <summary>
        /// Lista de artefatos associados ao julgado.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.Artifact>? Artifacts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JurisprudenceRecord" /> class.
        /// </summary>
        /// <param name="id">
        /// ID da decisão.
        /// </param>
        /// <param name="juitId">
        /// ID da decisão gerado pela JUIT.
        /// </param>
        /// <param name="cnjUniqueNumber">
        /// Número do processo no padrão CNJ.
        /// </param>
        /// <param name="courtCode">
        /// Código do tribunal no qual foi julgado.
        /// </param>
        /// <param name="degree">
        /// Grau no qual foi julgado.
        /// </param>
        /// <param name="district">
        /// Comarca de origem do recurso.
        /// </param>
        /// <param name="documentMatterList">
        /// Lista com assuntos baseado na TPU do CNJ.
        /// </param>
        /// <param name="documentType">
        /// Tipo de documento do julgado.
        /// </param>
        /// <param name="fullText">
        /// Texto do inteiro teor do julgado.
        /// </param>
        /// <param name="headnote">
        /// Ementa do julgado.
        /// </param>
        /// <param name="judgmentBody">
        /// Órgão responsável pelo julgamento.
        /// </param>
        /// <param name="processClassNameList">
        /// Classes da ação definidas pelo tribunal ou recurso.
        /// </param>
        /// <param name="processOriginState">
        /// Estado de origem do julgado.
        /// </param>
        /// <param name="judgmentDate">
        /// Data de julgamento do processo.
        /// </param>
        /// <param name="publicationDate">
        /// Data de publicação do julgado.
        /// </param>
        /// <param name="releaseDate">
        /// Data de disponibilização do documento.
        /// </param>
        /// <param name="signatureDate">
        /// Data de assinatura do documento.
        /// </param>
        /// <param name="orderDate">
        /// Tem o valor de uma das datas para facilitar a visualização de data.
        /// </param>
        /// <param name="title">
        /// O título do documento que é exibido na aplicação.
        /// </param>
        /// <param name="trier">
        /// Julgador responsável pelo caso, pode ser um Juiz, Desembargador ou Ministro.
        /// </param>
        /// <param name="justiceType">
        /// Indica o tipo de justiça que o processo pertence, podendo ser Juizado Especial e Juízo Comum.
        /// </param>
        /// <param name="rimorUrl"></param>
        /// <param name="artifacts">
        /// Lista de artefatos associados ao julgado.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JurisprudenceRecord(
            string? id,
            string? juitId,
            string? cnjUniqueNumber,
            string? courtCode,
            string? degree,
            string? district,
            global::System.Collections.Generic.IList<string>? documentMatterList,
            string? documentType,
            string? fullText,
            string? headnote,
            string? judgmentBody,
            global::System.Collections.Generic.IList<string>? processClassNameList,
            string? processOriginState,
            global::System.DateTime? judgmentDate,
            global::System.DateTime? publicationDate,
            global::System.DateTime? releaseDate,
            global::System.DateTime? signatureDate,
            global::System.DateTime? orderDate,
            string? title,
            string? trier,
            string? justiceType,
            string? rimorUrl,
            global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.Artifact>? artifacts)
        {
            this.Id = id;
            this.JuitId = juitId;
            this.CnjUniqueNumber = cnjUniqueNumber;
            this.CourtCode = courtCode;
            this.Degree = degree;
            this.District = district;
            this.DocumentMatterList = documentMatterList;
            this.DocumentType = documentType;
            this.FullText = fullText;
            this.Headnote = headnote;
            this.JudgmentBody = judgmentBody;
            this.ProcessClassNameList = processClassNameList;
            this.ProcessOriginState = processOriginState;
            this.JudgmentDate = judgmentDate;
            this.PublicationDate = publicationDate;
            this.ReleaseDate = releaseDate;
            this.SignatureDate = signatureDate;
            this.OrderDate = orderDate;
            this.Title = title;
            this.Trier = trier;
            this.JusticeType = justiceType;
            this.RimorUrl = rimorUrl;
            this.Artifacts = artifacts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JurisprudenceRecord" /> class.
        /// </summary>
        public JurisprudenceRecord()
        {
        }

    }
}