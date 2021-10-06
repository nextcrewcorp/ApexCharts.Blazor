using ApexCharts.Blazor.Converters;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(LineCapConverter))]
    public enum LineCap
    {
        [Description("butt")]
        Butt,
        [Description("square")]
        Square,
        [Description("round")]
        Round,
    }
}
