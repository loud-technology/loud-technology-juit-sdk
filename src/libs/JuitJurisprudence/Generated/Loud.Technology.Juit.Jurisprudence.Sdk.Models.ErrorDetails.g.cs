
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ErrorDetails
    {
        /// <summary>
        /// Error trace id. The trace ID have this pattern `{1}-{2}-{3}`, where:<br/>
        /// 1. A letter indicating the error layer:<br/>
        ///     - `D` &amp;rarr; Database<br/>
        ///     - `B` &amp;rarr; Backend<br/>
        ///     - `F` &amp;rarr; Frontend<br/>
        /// 2. A letter indicating the log level<br/>
        ///     - `D` &amp;rarr; Debug<br/>
        ///     - `I` &amp;rarr; Info<br/>
        ///     - `W` &amp;rarr; Warning<br/>
        ///     - `E` &amp;rarr; Error<br/>
        ///     - `F` &amp;rarr; Fatal<br/>
        /// 3. A Short UUID implemented based on MySQL Funcion [`UUID_SHORT()`](https://dev.mysql.com/doc/refman/8.0/en/miscellaneous-functions.html#function_uuid-short)
        /// </summary>
        [global::System.ComponentModel.DataAnnotations.RegularExpression("^[BFD]\\-[DIWEF]\\-\\d.+$")]
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// The error feedback short message. Usually in portuguese.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_message")]
        public string? ShortMessage { get; set; }

        /// <summary>
        /// The error feedback complete message. Usually in portuguese.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_message")]
        public string? LongMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetails" /> class.
        /// </summary>
        /// <param name="traceId">
        /// Error trace id. The trace ID have this pattern `{1}-{2}-{3}`, where:<br/>
        /// 1. A letter indicating the error layer:<br/>
        ///     - `D` &amp;rarr; Database<br/>
        ///     - `B` &amp;rarr; Backend<br/>
        ///     - `F` &amp;rarr; Frontend<br/>
        /// 2. A letter indicating the log level<br/>
        ///     - `D` &amp;rarr; Debug<br/>
        ///     - `I` &amp;rarr; Info<br/>
        ///     - `W` &amp;rarr; Warning<br/>
        ///     - `E` &amp;rarr; Error<br/>
        ///     - `F` &amp;rarr; Fatal<br/>
        /// 3. A Short UUID implemented based on MySQL Funcion [`UUID_SHORT()`](https://dev.mysql.com/doc/refman/8.0/en/miscellaneous-functions.html#function_uuid-short)
        /// </param>
        /// <param name="shortMessage">
        /// The error feedback short message. Usually in portuguese.
        /// </param>
        /// <param name="longMessage">
        /// The error feedback complete message. Usually in portuguese.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorDetails(
            string? traceId,
            string? shortMessage,
            string? longMessage)
        {
            this.TraceId = traceId;
            this.ShortMessage = shortMessage;
            this.LongMessage = longMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetails" /> class.
        /// </summary>
        public ErrorDetails()
        {
        }

    }
}