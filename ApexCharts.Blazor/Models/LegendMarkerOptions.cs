using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class LegendMarkerOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Width { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Height { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal StrokeWidth { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<string> FillColors { get; set; }

        #region Method Chaining

        public LegendMarkerOptions SetWidth(decimal width)
        {
            Width = width;
            return this;
        }

        public LegendMarkerOptions SetHeight(decimal height)
        {
            Height = height;
            return this;
        }

        public LegendMarkerOptions SetStrokeWidth(decimal strokeWidth)
        {
            StrokeWidth = strokeWidth;
            return this;
        }

        public LegendMarkerOptions SetFillColors(IEnumerable<string> fillColors)
        {
            FillColors = fillColors.ToList();
            return this;
        }

        public LegendMarkerOptions AddFillColor(string fillColor)
        {
            if (FillColors == null)
                FillColors = new List<string>();

            FillColors.Add(fillColor);
            return this;
        }

        #endregion
    }
}
