
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum GetJurisprudencesSearchOnItem
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
    public static class GetJurisprudencesSearchOnItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJurisprudencesSearchOnItem value)
        {
            return value switch
            {
                GetJurisprudencesSearchOnItem.FullText => "full_text",
                GetJurisprudencesSearchOnItem.Headnote => "headnote",
                GetJurisprudencesSearchOnItem.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJurisprudencesSearchOnItem? ToEnum(string value)
        {
            return value switch
            {
                "full_text" => GetJurisprudencesSearchOnItem.FullText,
                "headnote" => GetJurisprudencesSearchOnItem.Headnote,
                "title" => GetJurisprudencesSearchOnItem.Title,
                _ => null,
            };
        }
    }
}