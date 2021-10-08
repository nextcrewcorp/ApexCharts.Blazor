using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(SparklineConverter))]
    public class Sparkline
    {
        public bool Enabled { get; set; } = false;

        #region Method Chaining

        public Sparkline SetEnabled(bool enabled)
        {
            Enabled = enabled;
            return this;
        }

        #endregion
    }

    public class SparklineConverter : JsonConverter<Sparkline>
    {
        public override Sparkline Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return null;
        }

        public override void Write(Utf8JsonWriter writer, Sparkline value, JsonSerializerOptions options)
        {
            if (value != null)
            {
                writer.WriteStartObject();
                writer.WriteBoolean("enabled", value.Enabled);
                writer.WriteEndObject();
            }
        }
    }
}
