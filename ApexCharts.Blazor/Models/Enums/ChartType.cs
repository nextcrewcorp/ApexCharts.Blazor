using ApexCharts.Blazor.Converters;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(ChartTypeConverter))]
    public enum ChartType
    {
        [Description("area")]
        Area,
        [Description("bar")]
        Bar,
        [Description("candlestick")]
        CandleStick,
        [Description("column")]
        Column,
        [Description("donut")]
        Donut,
        [Description("line")]
        Line,
        [Description("pie")]
        Pie,
        [Description("radar")]
        Radar,
        [Description("rangeBar")]
        RangeBar,
    }
}
