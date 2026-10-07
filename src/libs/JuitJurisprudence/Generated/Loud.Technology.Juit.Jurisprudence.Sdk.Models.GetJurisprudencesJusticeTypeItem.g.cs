
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum GetJurisprudencesJusticeTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        JuizadoEspecial,
        /// <summary>
        ///
        /// </summary>
        JuízoComum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJurisprudencesJusticeTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJurisprudencesJusticeTypeItem value)
        {
            return value switch
            {
                GetJurisprudencesJusticeTypeItem.JuizadoEspecial => "Juizado Especial",
                GetJurisprudencesJusticeTypeItem.JuízoComum => "Juízo Comum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJurisprudencesJusticeTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "Juizado Especial" => GetJurisprudencesJusticeTypeItem.JuizadoEspecial,
                "Juízo Comum" => GetJurisprudencesJusticeTypeItem.JuízoComum,
                _ => null,
            };
        }
    }
}