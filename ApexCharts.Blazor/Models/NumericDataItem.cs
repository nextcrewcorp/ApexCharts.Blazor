using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ApexCharts.Blazor.Models
{
    public class NumericDataItem : DataItem
    {

        public decimal? Value { get; set; }

        public NumericDataItem() { }
        public NumericDataItem(decimal? value)
        {
            Value = value;
        }

        public void WriteJson(Utf8JsonWriter writer)
        {
            if (Value.HasValue)
                writer.WriteNumberValue(Value.Value);
            else
                writer.WriteNullValue();
        }

        public static IEnumerable<NumericDataItem> FromArray(decimal?[] array)
        {
            return array.Select(x => new NumericDataItem(x));
        }

        public static IEnumerable<NumericDataItem> FromArray(double?[] array)
        {
            return array.Select(x => new NumericDataItem(Convert.ToDecimal(x)));
        }
    }
}
