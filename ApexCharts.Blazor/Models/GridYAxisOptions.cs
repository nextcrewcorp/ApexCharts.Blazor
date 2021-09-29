using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class GridYAxisOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public GridLines Lines { get; set; }
    }
}
