using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class GridLines
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Show { get; set; }
    }
}
