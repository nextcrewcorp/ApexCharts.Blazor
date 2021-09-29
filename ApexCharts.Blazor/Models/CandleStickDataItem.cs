using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ApexCharts.Blazor.Models
{
    public class CandleStickDataItem : DataItem
    {

        public DateTime X { get; set; }
        public IEnumerable<decimal?> Values { get; set; }

        public CandleStickDataItem() { }
        public CandleStickDataItem(DateTime x, IEnumerable<decimal?> values)
        {
            X = x;
            Values = values;
        }

        public CandleStickDataItem(DateTime x, IEnumerable<double?> values)
        {
            X = x;
            Values = values.Select(x => (decimal?)(x == null ? null : Convert.ToDecimal(x)));
        }

        public void WriteJson(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteString("x", X);
            writer.WriteStartArray("y");

            foreach (var a in Values)
            {
                if (a.HasValue)
                    writer.WriteNumberValue(a.Value);
                else
                    writer.WriteNullValue();
            }

            writer.WriteEndArray();

            writer.WriteEndObject();

        }
    }
}
