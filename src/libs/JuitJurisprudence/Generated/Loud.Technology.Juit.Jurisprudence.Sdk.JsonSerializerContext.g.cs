
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesSearchOnItemJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesSearchOnItemNullableJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesDisableSynonymOnItemJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesDisableSynonymOnItemNullableJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesSortByFieldItemJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesSortByFieldItemNullableJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesSortByDirectionItemJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesSortByDirectionItemNullableJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesDegreeItemJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesDegreeItemNullableJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesProcessOriginStateItemJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesProcessOriginStateItemNullableJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesDocumentTypeItemJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesDocumentTypeItemNullableJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesJusticeTypeItemJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.GetJurisprudencesJusticeTypeItemNullableJsonConverter),

            typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.SearchInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.Artifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.ErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSearchOnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSearchOnItem), TypeInfoPropertyName = "GetJurisprudencesSearchOnItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDisableSynonymOnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDisableSynonymOnItem), TypeInfoPropertyName = "GetJurisprudencesDisableSynonymOnItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByFieldItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByFieldItem), TypeInfoPropertyName = "GetJurisprudencesSortByFieldItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByDirectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByDirectionItem), TypeInfoPropertyName = "GetJurisprudencesSortByDirectionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDegreeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDegreeItem), TypeInfoPropertyName = "GetJurisprudencesDegreeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesProcessOriginStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesProcessOriginStateItem), TypeInfoPropertyName = "GetJurisprudencesProcessOriginStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDocumentTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDocumentTypeItem), TypeInfoPropertyName = "GetJurisprudencesDocumentTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem), TypeInfoPropertyName = "GetJurisprudencesJusticeTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.JurisprudenceRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSearchOnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDisableSynonymOnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByFieldItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesSortByDirectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDegreeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesProcessOriginStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesDocumentTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}