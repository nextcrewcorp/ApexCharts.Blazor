using ApexCharts.Blazor.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Converters
{
    public class ZoomTypeConverter : JsonConverter<ZoomType>
    {
        public override ZoomType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (ZoomType)Enum.Parse(typeof(ZoomType), reader.GetString(), true);
        }

        public override void Write(Utf8JsonWriter writer, ZoomType value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name());
        }
    }
}
