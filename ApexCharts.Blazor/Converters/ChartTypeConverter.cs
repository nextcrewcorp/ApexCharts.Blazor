using ApexCharts.Blazor.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Converters
{
    public class ChartTypeConverter : JsonConverter<ChartType>
    {
        public override ChartType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (ChartType)Enum.Parse(typeof(ChartType), reader.GetString());

        }

        public override void Write(Utf8JsonWriter writer, ChartType value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name());
        }
    }
}
