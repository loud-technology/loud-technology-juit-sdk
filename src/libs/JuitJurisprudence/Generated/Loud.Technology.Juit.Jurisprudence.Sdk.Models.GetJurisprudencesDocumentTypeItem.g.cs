
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum GetJurisprudencesDocumentTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        Acórdão,
        /// <summary>
        ///
        /// </summary>
        Admissibilidade,
        /// <summary>
        ///
        /// </summary>
        Decisão,
        /// <summary>
        ///
        /// </summary>
        DecisãoMonocrática,
        /// <summary>
        ///
        /// </summary>
        Despacho,
        /// <summary>
        ///
        /// </summary>
        DúvidaDeCompetência,
        /// <summary>
        ///
        /// </summary>
        NâoIdentificado,
        /// <summary>
        ///
        /// </summary>
        Sentença,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJurisprudencesDocumentTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJurisprudencesDocumentTypeItem value)
        {
            return value switch
            {
                GetJurisprudencesDocumentTypeItem.Acórdão => "Acórdão",
                GetJurisprudencesDocumentTypeItem.Admissibilidade => "Admissibilidade",
                GetJurisprudencesDocumentTypeItem.Decisão => "Decisão",
                GetJurisprudencesDocumentTypeItem.DecisãoMonocrática => "Decisão Monocrática",
                GetJurisprudencesDocumentTypeItem.Despacho => "Despacho",
                GetJurisprudencesDocumentTypeItem.DúvidaDeCompetência => "Dúvida de Competência",
                GetJurisprudencesDocumentTypeItem.NâoIdentificado => "Nâo identificado",
                GetJurisprudencesDocumentTypeItem.Sentença => "Sentença",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJurisprudencesDocumentTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "Acórdão" => GetJurisprudencesDocumentTypeItem.Acórdão,
                "Admissibilidade" => GetJurisprudencesDocumentTypeItem.Admissibilidade,
                "Decisão" => GetJurisprudencesDocumentTypeItem.Decisão,
                "Decisão Monocrática" => GetJurisprudencesDocumentTypeItem.DecisãoMonocrática,
                "Despacho" => GetJurisprudencesDocumentTypeItem.Despacho,
                "Dúvida de Competência" => GetJurisprudencesDocumentTypeItem.DúvidaDeCompetência,
                "Nâo identificado" => GetJurisprudencesDocumentTypeItem.NâoIdentificado,
                "Sentença" => GetJurisprudencesDocumentTypeItem.Sentença,
                _ => null,
            };
        }
    }
}