
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum GetJurisprudencesSortByDirectionItem
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJurisprudencesSortByDirectionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJurisprudencesSortByDirectionItem value)
        {
            return value switch
            {
                GetJurisprudencesSortByDirectionItem.Asc => "asc",
                GetJurisprudencesSortByDirectionItem.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJurisprudencesSortByDirectionItem? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetJurisprudencesSortByDirectionItem.Asc,
                "desc" => GetJurisprudencesSortByDirectionItem.Desc,
                _ => null,
            };
        }
    }
}