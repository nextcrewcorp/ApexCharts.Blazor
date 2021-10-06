using ApexCharts.Blazor.Converters;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(ZoomTypeConverter))]
    public enum ZoomType
    {
        [Description("x")]
        X,
        [Description("y")]
        Y,
        [Description("xy")]
        XY
    }
}
