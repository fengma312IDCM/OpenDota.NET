namespace OpenDotaDotNet.JsonConverters
{
    using System;
    using System.Buffers;
    using System.Buffers.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class IntConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
                if (Utf8Parser.TryParse(span, out int number, out int bytesConsumed) && span.Length == bytesConsumed)
                {
                    return number;
                }

                if (int.TryParse(reader.GetString(), out number))
                {
                    return number;
                }
                else
                {
                    return 0;
                }
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetInt32();
            }
            else
            {
                return 0;
            }
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
