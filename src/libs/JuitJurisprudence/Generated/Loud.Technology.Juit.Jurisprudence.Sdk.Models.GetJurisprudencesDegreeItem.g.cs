
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum GetJurisprudencesDegreeItem
    {
        /// <summary>
        ///
        /// </summary>
        x1ªInstância,
        /// <summary>
        ///
        /// </summary>
        x2ªInstância,
        /// <summary>
        ///
        /// </summary>
        Administrativo,
        /// <summary>
        ///
        /// </summary>
        TribunalSuperior,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJurisprudencesDegreeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJurisprudencesDegreeItem value)
        {
            return value switch
            {
                GetJurisprudencesDegreeItem.x1ªInstância => "1ª Instância",
                GetJurisprudencesDegreeItem.x2ªInstância => "2ª Instância",
                GetJurisprudencesDegreeItem.Administrativo => "Administrativo",
                GetJurisprudencesDegreeItem.TribunalSuperior => "Tribunal Superior",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJurisprudencesDegreeItem? ToEnum(string value)
        {
            return value switch
            {
                "1ª Instância" => GetJurisprudencesDegreeItem.x1ªInstância,
                "2ª Instância" => GetJurisprudencesDegreeItem.x2ªInstância,
                "Administrativo" => GetJurisprudencesDegreeItem.Administrativo,
                "Tribunal Superior" => GetJurisprudencesDegreeItem.TribunalSuperior,
                _ => null,
            };
        }
    }
}