using ApexCharts.Blazor.Converters;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(HorizontalAlignmentConverter))]

    public enum HorizontalAlignment
    {
        [Description("left")]
        Left,
        [Description("center")]
        Center,
        [Description("right")]
        Right,
    }
}
