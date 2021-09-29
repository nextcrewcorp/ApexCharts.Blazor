using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class TooltipOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("enabled")]
        public bool IsEnabled { get; set; }

        [JsonIgnore]
        public string YFormatExpression { get; set; }

        #region Method Chaining

        public TooltipOptions SetIsEnabled(bool isEnabled)
        {
            IsEnabled = isEnabled;
            return this;
        }

        public TooltipOptions SetYFormatExpression(string expression)
        {
            YFormatExpression = expression;
            return this;
        }

        #endregion
    }
}
