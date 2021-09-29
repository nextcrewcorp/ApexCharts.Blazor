using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class GridXAxisOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public GridLines Lines { get; set; }
    }
}
