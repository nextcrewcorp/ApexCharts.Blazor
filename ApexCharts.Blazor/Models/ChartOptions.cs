using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class ChartOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ChartType? Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Height { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Width { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ZoomOptions Zoom { get; set; }

        #region Method Chaining

        public ChartOptions SetType(ChartType type)
        {
            Type = type;
            return this;
        }

        public ChartOptions SetHeight(string height)
        {
            Height = height;
            return this;
        }

        public ChartOptions SetWidth(string width)
        {
            Width = width;
            return this;
        }

        public ChartOptions SetZoom(ZoomOptions zoom)
        {
            Zoom = zoom;
            return this;
        }

        #endregion
    }
}
