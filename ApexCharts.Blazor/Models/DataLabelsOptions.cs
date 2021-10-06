using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class DataLabelsOptions
    {
        public bool Enabled { get; set; } = true;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<int> EnabledOnSeries { get; set; }

        [JsonIgnore]
        public string FormatExpression { get; set; }

        #region Method Chaining

        public DataLabelsOptions SetEnabled(bool enabled)
        {
            Enabled = enabled;
            return this;
        }

        public DataLabelsOptions SetEnabledOnSeries(IEnumerable<int> indexes)
        {
            EnabledOnSeries = indexes.ToList();
            return this;
        }

        public DataLabelsOptions AddEnabledOnSeries(int index)
        {
            if (EnabledOnSeries == null)
                EnabledOnSeries = new List<int>();

            EnabledOnSeries.Add(index);
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
