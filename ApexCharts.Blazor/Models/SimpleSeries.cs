using System;
using System.Collections.Generic;
using System.Linq;

namespace ApexCharts.Blazor.Models
{
    public class SimpleSeries : BaseSeries
    {
        public IEnumerable<decimal?> Data { get; set; }

        public SimpleSeries(IEnumerable<decimal?> data)
        {
            Data = data;
        }

        public SimpleSeries(IEnumerable<double?> data)
        {
            Data = data.Select(x => (decimal?)(x == null ? null : Convert.ToDecimal(x)));
        }
    }
}
