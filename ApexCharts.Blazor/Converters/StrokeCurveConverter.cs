using ApexCharts.Blazor.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Converters
{
    public class StrokeCurveConverter : JsonConverter<StrokeCurve>
    {
        public override StrokeCurve Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (StrokeCurve)Enum.Parse(typeof(StrokeCurve), reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, StrokeCurve value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name());
        }
    }
}
