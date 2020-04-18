namespace OpenDotaDotNet.JsonConverters
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class NullableIntConverter : JsonConverter<int?>
    {
        public override int? Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                if (int.TryParse(reader.GetString(), out var number))
                {
                    return number;
                }
                else
                {
                    return null;
                }
            }

            return reader.GetInt32();
        }

        public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value?.ToString());
        }
    }
}
