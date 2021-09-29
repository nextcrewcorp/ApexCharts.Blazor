using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class StyleOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string FontSize { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string FontWeight { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string FontFamily { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Color { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string CssClass { get; set; }
    }
}
