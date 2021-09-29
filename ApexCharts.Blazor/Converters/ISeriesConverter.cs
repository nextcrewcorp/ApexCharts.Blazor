using ApexCharts.Blazor.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Converters
{
    public class BaseSeriesConverter : JsonConverter<BaseSeries>
    {
        public override BaseSeries Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, BaseSeries value, JsonSerializerOptions options)
        {
            if (value is Series)
            {
                var v = value as Series;

                writer.WriteStartObject();

                if (v.Name != null)
                    writer.WriteString("name", v.Name);

                if (v.Type.HasValue)
                    writer.WriteString("type", v.Type.Value.Name());

                writer.WriteStartArray("data");

                foreach (var item in v.Data)
                {
                    switch (item)
                    {
                        case NumericDataItem: (item as NumericDataItem).WriteJson(writer); break;
                        case CategoryDataItem: (item as CategoryDataItem).WriteJson(writer); break;
                        case PointDataItem: (item as PointDataItem).WriteJson(writer); break;
                        case TimelineDataItem: (item as TimelineDataItem).WriteJson(writer); break;
                        case CandleStickDataItem: (item as CandleStickDataItem).WriteJson(writer); break;
                        default: break;
                    }
                }

                writer.WriteEndArray();
                writer.WriteEndObject();
            }
            else if (value is SimpleSeries)
            {
                var v = value as SimpleSeries;

                foreach (var item in v.Data)
                {
                    if (item.HasValue)
                        writer.WriteNumberValue(item.Value);
                    else
                        writer.WriteNullValue();
                }
            }
        }
    }
}
