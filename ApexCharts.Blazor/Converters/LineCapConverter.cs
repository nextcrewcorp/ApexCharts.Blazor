using ApexCharts.Blazor.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Converters
{
    public class LineCapConverter : JsonConverter<LineCap>
    {
        public override LineCap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (LineCap)Enum.Parse(typeof(LineCap), reader.GetString(), true);
        }

        public override void Write(Utf8JsonWriter writer, LineCap value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name());
        }
    }
}
