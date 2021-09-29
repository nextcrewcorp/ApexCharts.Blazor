using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApexCharts.Blazor.Models
{
    public class PointDataItem : DataItem
    {
        public decimal X { get; set; }
        public decimal? Y { get; set; }

        public PointDataItem() { }
        public PointDataItem(decimal x, decimal? y)
        {
            X = x;
            Y = y;
        }

        public void WriteJson(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteNumber("x", X);

            if (Y.HasValue)
                writer.WriteNumber("y", Y.Value);
            else
                writer.WriteNull("y");

            writer.WriteEndObject();
        }

        public static IEnumerable<PointDataItem> FromDictionary(IDictionary<decimal, decimal?> dictionary)
        {
            return dictionary.Select(x => new PointDataItem(x.Key, x.Value));
        }

    }
}
