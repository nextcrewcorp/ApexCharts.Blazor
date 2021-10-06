using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class Series : BaseSeries
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ChartType? Type { get; set; }

        public IEnumerable<DataItem> Data { get; set; }

    }
}
