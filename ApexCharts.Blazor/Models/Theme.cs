using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class Theme
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Palette { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Mode { get; set; }
    }
}
