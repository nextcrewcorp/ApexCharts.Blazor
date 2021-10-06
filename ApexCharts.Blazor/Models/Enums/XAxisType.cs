using ApexCharts.Blazor.Converters;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(XAxisTypeConverter))]
    public enum XAxisType
    {
        [Description("category")]
        Category,
        [Description("datetime")]
        DateTime,
        [Description("numeric")]
        Numeric
    }
}
