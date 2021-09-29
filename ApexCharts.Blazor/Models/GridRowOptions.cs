using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class GridRowOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string[] Colors { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Opacity { get; set; }
    }
}
