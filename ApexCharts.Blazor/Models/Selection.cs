using ApexCharts.Blazor.Models.Enums;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(SelectionJsonConverter))]
    public class Selection
    {
        public bool Enabled { get; set; } = true;
        public Axis Type { get; set; } = Axis.X;
        /// <summary>
        /// fill.color
        /// </summary>
        public string FillColor { get; set; } = "#24292e";
        /// <summary>
        /// fill.opacity
        /// </summary>
        public double FillOpacity { get; set; } = 0.1;
        /// <summary>
        /// stroke.width
        /// </summary>
        public double StrokeWidth { get; set; } = 1;
        /// <summary>
        /// stroke.dashArray
        /// </summary>
        public double StrokeDashArray { get; set; } = 3;
        /// <summary>
        /// stroke.color
        /// </summary>
        public string StrokeColor { get; set; } = "#24292e";
        /// <summary>
        /// stroke.opacity
        /// </summary>
        public double StrokeOpacity { get; set; } = 0.4;
        /// <summary>
        /// xaxis.min
        /// </summary>
        public double XAxisMin { get; set; } = double.NegativeInfinity;
        /// <summary>
        /// xaxis.max
        /// </summary>
        public double XAxisMax { get; set; } = double.NegativeInfinity;
        /// <summary>
        /// yaxis.min
        /// </summary>
        public double YAxisMin { get; set; } = double.NegativeInfinity;
        /// <summary>
        /// yaxis.max
        /// </summary>
        public double YAxisMax { get; set; } = double.NegativeInfinity;

        #region Method Chaining

        public Selection SetEnabled(bool enabled)
        {
            Enabled = enabled;
            return this;
        }

        public Selection SetType(Axis type)
        {
            Type = type;
            return this;
        }

        public Selection SetFillColor(string fillColor)
        {
            FillColor = fillColor;
            return this;
        }

        public Selection SetFillOpacity(double fillOpacity)
        {
            FillOpacity = fillOpacity;
            return this;
        }

        public Selection SetStrokeWidth(double strokeWidth)
        {
            StrokeWidth = strokeWidth;
            return this;
        }

        public Selection SetStrokeDashArray(double strokeDashArray)
        {
            StrokeDashArray = strokeDashArray;
            return this;
        }

        public Selection SetStrokeColor(string strokeColor)
        {
            StrokeColor = strokeColor;
            return this;
        }

        public Selection SetStrokeOpacity(double strokeOpacity)
        {
            StrokeOpacity = strokeOpacity;
            return this;
        }

        public Selection SetXAxisMin(double xAxisMin)
        {
            XAxisMin = xAxisMin;
            return this;
        }

        public Selection SetXAxisMax(double xAxisMax)
        {
            XAxisMax = xAxisMax;
            return this;
        }

        public Selection SetYAxisMin(double yAxisMin)
        {
            YAxisMin = yAxisMin;
            return this;
        }

        public Selection SetYAxisMax(double yAxisMax)
        {
            YAxisMax = yAxisMax;
            return this;
        }

        #endregion
    }

    public class SelectionJsonConverter : JsonConverter<Selection>
    {
        public override Selection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return null;
        }

        public override void Write(Utf8JsonWriter writer, Selection value, JsonSerializerOptions options)
        {
            if (value != null)
            {
                var construct = new Selection();

                writer.WriteStartObject();

                // enabled
                if (value.Enabled != construct.Enabled)
                    writer.WriteBoolean("enabled", value.Enabled);

                // type
                if (value.Type != construct.Type)
                    writer.WriteString("type", value.Type.Name());

                // fill
                if (value.FillColor != construct.FillColor || value.FillOpacity != construct.FillOpacity)
                {
                    writer.WriteStartObject("fill");

                    if (value.FillColor != construct.FillColor)
                        writer.WriteString("color", value.FillColor);

                    if (value.FillOpacity != construct.FillOpacity)
                        writer.WriteNumber("opacity", value.FillOpacity);

                    writer.WriteEndObject();
                }

                // stroke
                if (value.StrokeWidth != construct.StrokeWidth || value.StrokeDashArray != construct.StrokeDashArray
                    || value.StrokeColor != construct.StrokeColor || value.StrokeOpacity != construct.StrokeOpacity)
                {
                    writer.WriteStartObject("stroke");

                    if (value.StrokeWidth != construct.StrokeWidth)
                        writer.WriteNumber("width", value.StrokeWidth);

                    if (value.StrokeDashArray != construct.StrokeDashArray)
                        writer.WriteNumber("dashArray", value.StrokeDashArray);

                    if (value.StrokeColor != construct.StrokeColor)
                        writer.WriteString("color", value.StrokeColor);

                    if (value.StrokeOpacity != construct.StrokeOpacity)
                        writer.WriteNumber("opacity", value.StrokeOpacity);

                    writer.WriteEndObject();
                }

                // xaxis
                if (value.XAxisMin != construct.XAxisMin || value.XAxisMax != construct.XAxisMax)
                {
                    Console.WriteLine("xaxis");
                    writer.WriteStartObject("xaxis");

                    if (value.XAxisMin != construct.XAxisMin)
                        writer.WriteNumber("min", value.XAxisMin);

                    if (value.XAxisMax != construct.XAxisMax)
                        writer.WriteNumber("max", value.XAxisMax);

                    writer.WriteEndObject();
                }

                // yaxis
                if (value.YAxisMin != construct.YAxisMin || value.YAxisMax != construct.YAxisMax)
                {
                    writer.WriteStartObject("yaxis");

                    if (value.YAxisMin != construct.YAxisMin)
                        writer.WriteNumber("min", value.YAxisMin);

                    if (value.YAxisMax != construct.YAxisMax)
                        writer.WriteNumber("max", value.YAxisMax);

                    writer.WriteEndObject();
                }

                writer.WriteEndObject();
            }
        }

    }
}
