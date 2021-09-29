using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class Series : BaseSeries
    {
        public string Name { get; set; }

        public ChartType? Type { get; set; }

        public IEnumerable<DataItem> Data { get; set; }

    }
}
