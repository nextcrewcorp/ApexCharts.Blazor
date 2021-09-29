using ApexCharts.Blazor.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Converters
{
    public class PositionConverter : JsonConverter<Position>
    {
        public override Position Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (Position)Enum.Parse(typeof(Position), reader.GetString());

        }

        public override void Write(Utf8JsonWriter writer, Position value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name());
        }
    }
}
