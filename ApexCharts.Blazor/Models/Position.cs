using ApexCharts.Blazor.Converters;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(PositionConverter))]
    public enum Position
    {
        [Description("top")]
        Top,
        [Description("right")]
        Right,
        [Description("bottom")]
        Bottom,
        [Description("left")]
        Left
    }
}
