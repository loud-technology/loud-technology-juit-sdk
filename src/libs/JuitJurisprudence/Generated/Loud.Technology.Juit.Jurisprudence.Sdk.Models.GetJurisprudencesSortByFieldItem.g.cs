
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum GetJurisprudencesSortByFieldItem
    {
        /// <summary>
        ///
        /// </summary>
        JuitId,
        /// <summary>
        ///
        /// </summary>
        OrderDate,
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJurisprudencesSortByFieldItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJurisprudencesSortByFieldItem value)
        {
            return value switch
            {
                GetJurisprudencesSortByFieldItem.JuitId => "juit_id",
                GetJurisprudencesSortByFieldItem.OrderDate => "order_date",
                GetJurisprudencesSortByFieldItem.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJurisprudencesSortByFieldItem? ToEnum(string value)
        {
            return value switch
            {
                "juit_id" => GetJurisprudencesSortByFieldItem.JuitId,
                "order_date" => GetJurisprudencesSortByFieldItem.OrderDate,
                "score" => GetJurisprudencesSortByFieldItem.Score,
                _ => null,
            };
        }
    }
}