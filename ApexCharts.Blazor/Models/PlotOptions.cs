using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class PlotOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BarPlotOptions Bar { get; set; }

        #region Method Chaining

        public PlotOptions SetBar(BarPlotOptions bar)
        {
            Bar = bar;
            return this;
        }

        #endregion
    }
}
