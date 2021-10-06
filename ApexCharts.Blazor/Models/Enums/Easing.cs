using System;
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(EasingConverter))]
    public enum Easing
    {
        [Description("linear")]
        Linear,
        [Description("easein")]
        EaseIn,
        [Description("easeout")]
        EaseOut,
        [Description("easeinout")]
        EaseInOut,
    }

    public class EasingConverter : JsonConverter<Easing>
    {
        public override Easing Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (Easing)Enum.Parse(typeof(Easing), reader.GetString(), true);
        }

        public override void Write(Utf8JsonWriter writer, Easing value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name());
        }
    }

}
