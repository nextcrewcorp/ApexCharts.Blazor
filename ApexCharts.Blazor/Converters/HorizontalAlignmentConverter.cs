using ApexCharts.Blazor.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Converters
{
    public class HorizontalAlignmentConverter : JsonConverter<HorizontalAlignment>
    {
        public override HorizontalAlignment Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (HorizontalAlignment)Enum.Parse(typeof(HorizontalAlignment), reader.GetString(), true);
        }

        public override void Write(Utf8JsonWriter writer, HorizontalAlignment value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name());
        }
    }
}
