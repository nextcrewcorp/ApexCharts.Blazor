using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class ZoomOptions
    {
        public bool Enabled { get; set; } = true;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ZoomType? Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("autoScaleYaxis")]
        public bool? AutoScaleYAxis { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ZoomedArea ZoomedArea { get; set; }

        #region Method Chaining

        public ZoomOptions SetIsEnabled(bool enabled)
        {
            Enabled = enabled;
            return this;
        }

        public ZoomOptions SetType(ZoomType? type)
        {
            Type = type;
            return this;
        }

        public ZoomOptions SetAutoScaleYAxis(bool? autoScaleYAxis)
        {
            AutoScaleYAxis = autoScaleYAxis;
            return this;
        }

        public ZoomOptions SetZoomedArea(ZoomedArea zoomedArea)
        {
            ZoomedArea = zoomedArea;
            return this;
        }

        #endregion
    }
}
