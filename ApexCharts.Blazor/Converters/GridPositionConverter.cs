using ApexCharts.Blazor.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Converters
{
    public class GridPositionConverter : JsonConverter<GridPosition>
    {
        public override GridPosition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (GridPosition)Enum.Parse(typeof(GridPosition), reader.GetString(), true);
        }

        public override void Write(Utf8JsonWriter writer, GridPosition value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name());
        }
    }
}
