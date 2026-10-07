
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum GetJurisprudencesDisableSynonymOnItem
    {
        /// <summary>
        ///
        /// </summary>
        FullText,
        /// <summary>
        ///
        /// </summary>
        Headnote,
        /// <summary>
        ///
        /// </summary>
        Title,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJurisprudencesDisableSynonymOnItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJurisprudencesDisableSynonymOnItem value)
        {
            return value switch
            {
                GetJurisprudencesDisableSynonymOnItem.FullText => "full_text",
                GetJurisprudencesDisableSynonymOnItem.Headnote => "headnote",
                GetJurisprudencesDisableSynonymOnItem.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJurisprudencesDisableSynonymOnItem? ToEnum(string value)
        {
            return value switch
            {
                "full_text" => GetJurisprudencesDisableSynonymOnItem.FullText,
                "headnote" => GetJurisprudencesDisableSynonymOnItem.Headnote,
                "title" => GetJurisprudencesDisableSynonymOnItem.Title,
                _ => null,
            };
        }
    }
}