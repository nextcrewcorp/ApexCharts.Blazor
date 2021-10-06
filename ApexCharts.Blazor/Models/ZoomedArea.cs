using ApexCharts.Blazor.Converters;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    /// <summary>
    /// Serialized to zoomedArea:{fill:{...},stroke:{...}}
    /// </summary>
    [JsonConverter(typeof(ZoomedAreaConverter))]
    public class ZoomedArea
    {
        // fill

        public string FillColor { get; set; }

        public double? FillOpacity { get; set; }

        // stroke

        public string StrokeColor { get; set; }

        public double? StrokeOpacity { get; set; }

        public double? StrokeWidth { get; set; }

        #region Method Chaining

        public ZoomedArea SetFillColor(string fillColor)
        {
            FillColor = fillColor;
            return this;
        }

        public ZoomedArea SetFillOpacity(double? fillOpacity)
        {
            FillOpacity = fillOpacity;
            return this;
        }

        public ZoomedArea SetStrokeColor(string strokeColor)
        {
            StrokeColor = strokeColor;
            return this;
        }

        public ZoomedArea SetStrokeOpacity(double? strokeOpacity)
        {
            StrokeOpacity = strokeOpacity;
            return this;
        }

        public ZoomedArea SetStrokeWidth(double? strokeWidth)
        {
            StrokeWidth = strokeWidth;
            return this;
        }

        #endregion
    }

    public class ZoomedAreaConverter : JsonConverter<ZoomedArea>
    {
        public override ZoomedArea Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Console.WriteLine("ZoomedArea convert back");
            return null;
        }

        public override void Write(Utf8JsonWriter writer, ZoomedArea value, JsonSerializerOptions options)
        {
            if (value != null)
            {
                writer.WriteStartObject();

                // fill
                if (!string.IsNullOrWhiteSpace(value.FillColor) || value.FillOpacity.HasValue)
                {
                    writer.WriteStartObject("fill");

                    if (!string.IsNullOrWhiteSpace(value.FillColor))
                        writer.WriteString("color", value.FillColor);

                    if (value.FillOpacity.HasValue)
                        writer.WriteNumber("opacity", value.FillOpacity.Value);

                    writer.WriteEndObject();
                }
                // stroke
                if (!string.IsNullOrWhiteSpace(value.StrokeColor) || value.StrokeOpacity.HasValue || value.StrokeWidth.HasValue)
                {
                    writer.WriteStartObject("stroke");

                    if (!string.IsNullOrWhiteSpace(value.StrokeColor))
                        writer.WriteString("color", value.StrokeColor);

                    if (value.StrokeOpacity.HasValue)
                        writer.WriteNumber("opacity", value.StrokeOpacity.Value);

                    if (value.StrokeWidth.HasValue)
                        writer.WriteNumber("width", value.StrokeWidth.Value);

                    writer.WriteEndObject();
                }

                writer.WriteEndObject();
            }
        }
    }
}
