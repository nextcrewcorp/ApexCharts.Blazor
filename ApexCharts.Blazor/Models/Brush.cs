using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class Brush
    {
        public bool Enabled { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Target { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("autoScaleYaxis")]
        public bool? AutoScaleYAxis { get; set; }

        #region Method Chaining

        public Brush SetEnabled(bool enabled)
        {
            Enabled = enabled;
            return this;
        }

        public Brush SetTarget(string target)
        {
            Target = target;
            return this;
        }

        public Brush SetAutoScaleYAxis(bool autoScaleYAxis)
        {
            AutoScaleYAxis = autoScaleYAxis;
            return this;
        }

        #endregion
    }
}
