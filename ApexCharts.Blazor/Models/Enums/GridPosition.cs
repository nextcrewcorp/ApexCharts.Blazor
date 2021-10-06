using ApexCharts.Blazor.Converters;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(GridPositionConverter))]
    public enum GridPosition
    {
        [Description("back")]
        Back,
        [Description("front")]
        Front
    }
}
