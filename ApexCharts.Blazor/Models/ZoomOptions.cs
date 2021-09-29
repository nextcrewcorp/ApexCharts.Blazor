using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class ZoomOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("enabled")]
        public bool IsEnabled { get; set; } = false;

        #region Method Chaining

        public ZoomOptions SetIsEnabled(bool isEnabled)
        {
            IsEnabled = isEnabled;
            return this;
        }

        #endregion
    }
}
