using ApexCharts.Blazor.Converters;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(StrokeCurveConverter))]
    public enum StrokeCurve
    {
        [Description("smooth")]
        Smooth,
        [Description("straight")]
        Straight,
        [Description("stepline")]
        Stepline,
    }
}
