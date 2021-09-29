using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ApexCharts.Blazor.Models
{
    public class TimelineDataItem : DataItem
    {

        public string Category { get; set; }
        public IEnumerable<DateTime?> Values { get; set; }

        public TimelineDataItem() { }
        public TimelineDataItem(string category, IEnumerable<DateTime?> values)
        {
            Category = category;
            Values = values;
        }

        public void WriteJson(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteString("x", Category);

            writer.WriteStartArray("y");

            foreach (var a in Values)
            {

                if (a.HasValue)
                    writer.WriteNumberValue(a.Value.ToUnixTicks());
                else
                    writer.WriteNullValue();
            }

            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
