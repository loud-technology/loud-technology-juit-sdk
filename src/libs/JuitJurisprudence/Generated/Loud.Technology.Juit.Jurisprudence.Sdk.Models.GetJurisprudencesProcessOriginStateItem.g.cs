
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum GetJurisprudencesProcessOriginStateItem
    {
        /// <summary>
        ///
        /// </summary>
        Ac,
        /// <summary>
        ///
        /// </summary>
        Al,
        /// <summary>
        ///
        /// </summary>
        Am,
        /// <summary>
        ///
        /// </summary>
        Ap,
        /// <summary>
        ///
        /// </summary>
        Ba,
        /// <summary>
        ///
        /// </summary>
        Ce,
        /// <summary>
        ///
        /// </summary>
        Df,
        /// <summary>
        ///
        /// </summary>
        Es,
        /// <summary>
        ///
        /// </summary>
        Go,
        /// <summary>
        ///
        /// </summary>
        Ma,
        /// <summary>
        ///
        /// </summary>
        Mg,
        /// <summary>
        ///
        /// </summary>
        Ms,
        /// <summary>
        ///
        /// </summary>
        Mt,
        /// <summary>
        ///
        /// </summary>
        Pa,
        /// <summary>
        ///
        /// </summary>
        Pb,
        /// <summary>
        ///
        /// </summary>
        Pe,
        /// <summary>
        ///
        /// </summary>
        Pi,
        /// <summary>
        ///
        /// </summary>
        Pr,
        /// <summary>
        ///
        /// </summary>
        Rj,
        /// <summary>
        ///
        /// </summary>
        Rn,
        /// <summary>
        ///
        /// </summary>
        Ro,
        /// <summary>
        ///
        /// </summary>
        Rr,
        /// <summary>
        ///
        /// </summary>
        Rs,
        /// <summary>
        ///
        /// </summary>
        Sc,
        /// <summary>
        ///
        /// </summary>
        Se,
        /// <summary>
        ///
        /// </summary>
        Sp,
        /// <summary>
        ///
        /// </summary>
        To,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJurisprudencesProcessOriginStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJurisprudencesProcessOriginStateItem value)
        {
            return value switch
            {
                GetJurisprudencesProcessOriginStateItem.Ac => "AC",
                GetJurisprudencesProcessOriginStateItem.Al => "AL",
                GetJurisprudencesProcessOriginStateItem.Am => "AM",
                GetJurisprudencesProcessOriginStateItem.Ap => "AP",
                GetJurisprudencesProcessOriginStateItem.Ba => "BA",
                GetJurisprudencesProcessOriginStateItem.Ce => "CE",
                GetJurisprudencesProcessOriginStateItem.Df => "DF",
                GetJurisprudencesProcessOriginStateItem.Es => "ES",
                GetJurisprudencesProcessOriginStateItem.Go => "GO",
                GetJurisprudencesProcessOriginStateItem.Ma => "MA",
                GetJurisprudencesProcessOriginStateItem.Mg => "MG",
                GetJurisprudencesProcessOriginStateItem.Ms => "MS",
                GetJurisprudencesProcessOriginStateItem.Mt => "MT",
                GetJurisprudencesProcessOriginStateItem.Pa => "PA",
                GetJurisprudencesProcessOriginStateItem.Pb => "PB",
                GetJurisprudencesProcessOriginStateItem.Pe => "PE",
                GetJurisprudencesProcessOriginStateItem.Pi => "PI",
                GetJurisprudencesProcessOriginStateItem.Pr => "PR",
                GetJurisprudencesProcessOriginStateItem.Rj => "RJ",
                GetJurisprudencesProcessOriginStateItem.Rn => "RN",
                GetJurisprudencesProcessOriginStateItem.Ro => "RO",
                GetJurisprudencesProcessOriginStateItem.Rr => "RR",
                GetJurisprudencesProcessOriginStateItem.Rs => "RS",
                GetJurisprudencesProcessOriginStateItem.Sc => "SC",
                GetJurisprudencesProcessOriginStateItem.Se => "SE",
                GetJurisprudencesProcessOriginStateItem.Sp => "SP",
                GetJurisprudencesProcessOriginStateItem.To => "TO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJurisprudencesProcessOriginStateItem? ToEnum(string value)
        {
            return value switch
            {
                "AC" => GetJurisprudencesProcessOriginStateItem.Ac,
                "AL" => GetJurisprudencesProcessOriginStateItem.Al,
                "AM" => GetJurisprudencesProcessOriginStateItem.Am,
                "AP" => GetJurisprudencesProcessOriginStateItem.Ap,
                "BA" => GetJurisprudencesProcessOriginStateItem.Ba,
                "CE" => GetJurisprudencesProcessOriginStateItem.Ce,
                "DF" => GetJurisprudencesProcessOriginStateItem.Df,
                "ES" => GetJurisprudencesProcessOriginStateItem.Es,
                "GO" => GetJurisprudencesProcessOriginStateItem.Go,
                "MA" => GetJurisprudencesProcessOriginStateItem.Ma,
                "MG" => GetJurisprudencesProcessOriginStateItem.Mg,
                "MS" => GetJurisprudencesProcessOriginStateItem.Ms,
                "MT" => GetJurisprudencesProcessOriginStateItem.Mt,
                "PA" => GetJurisprudencesProcessOriginStateItem.Pa,
                "PB" => GetJurisprudencesProcessOriginStateItem.Pb,
                "PE" => GetJurisprudencesProcessOriginStateItem.Pe,
                "PI" => GetJurisprudencesProcessOriginStateItem.Pi,
                "PR" => GetJurisprudencesProcessOriginStateItem.Pr,
                "RJ" => GetJurisprudencesProcessOriginStateItem.Rj,
                "RN" => GetJurisprudencesProcessOriginStateItem.Rn,
                "RO" => GetJurisprudencesProcessOriginStateItem.Ro,
                "RR" => GetJurisprudencesProcessOriginStateItem.Rr,
                "RS" => GetJurisprudencesProcessOriginStateItem.Rs,
                "SC" => GetJurisprudencesProcessOriginStateItem.Sc,
                "SE" => GetJurisprudencesProcessOriginStateItem.Se,
                "SP" => GetJurisprudencesProcessOriginStateItem.Sp,
                "TO" => GetJurisprudencesProcessOriginStateItem.To,
                _ => null,
            };
        }
    }
}