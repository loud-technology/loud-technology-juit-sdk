#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetJurisprudencesJusticeTypeItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem?>
    {
        /// <inheritdoc />
        public override global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItemExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Loud.Technology.Juit.Jurisprudence.Sdk.GetJurisprudencesJusticeTypeItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
