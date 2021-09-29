using ApexCharts.Blazor.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(BaseSeriesConverter))]
    public class BaseSeries
    {
    }
}
