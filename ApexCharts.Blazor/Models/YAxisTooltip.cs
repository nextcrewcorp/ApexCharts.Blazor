using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class YAxisTooltip
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("enabled")]
        public bool IsEnabled { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double OffsetX { get; set; }

        #region Method Chaining

        public YAxisTooltip SetIsEnabled(bool isEnabled)
        {
            IsEnabled = isEnabled;
            return this;
        }

        public YAxisTooltip SetOffsetX(double offsetX)
        {
            OffsetX = offsetX;
            return this;
        }

        #endregion
    }
}
