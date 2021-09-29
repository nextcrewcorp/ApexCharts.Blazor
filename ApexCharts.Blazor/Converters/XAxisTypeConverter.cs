using ApexCharts.Blazor.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Converters
{
    public class XAxisTypeConverter : JsonConverter<XAxisType>
    {
        public override XAxisType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (XAxisType)Enum.Parse(typeof(XAxisType), reader.GetString());

        }

        public override void Write(Utf8JsonWriter writer, XAxisType value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name());
        }
    }
}
