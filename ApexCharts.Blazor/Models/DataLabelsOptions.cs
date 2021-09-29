using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class DataLabelsOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("enabled")]
        public bool IsEnabled { get; set; } = true;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enabledOnSeries")]
        public List<int> IsEnabledOnSeries { get; set; }

        [JsonIgnore]
        public string FormatExpression { get; set; }

        #region Method Chaining

        public DataLabelsOptions SetIsEnabled(bool isEnabled)
        {
            IsEnabled = isEnabled;
            return this;
        }

        public DataLabelsOptions SetIsEnabledOnSeries(IEnumerable<int> indexes)
        {
            IsEnabledOnSeries = indexes.ToList();
            return this;
        }

        public DataLabelsOptions AddIsEnabledOnSeries(int index)
        {
            if (IsEnabledOnSeries == null)
                IsEnabledOnSeries = new List<int>();

            IsEnabledOnSeries.Add(index);
            return this;
        }

        public DataLabelsOptions SetFormatExpression(string expression)
        {
            FormatExpression = expression;
            return this;
        }

        #endregion
    }
}
