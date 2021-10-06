using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApexCharts.Blazor.Models
{
    [JsonConverter(typeof(AnimationsConverter))]
    public class Animations
    {
        public bool Enabled { get; set; } = true;
        public Easing? Easing { get; set; } = Models.Easing.EaseInOut;
        public double? Speed { get; set; }
        public bool? AnimateGraduallyEnabled { get; set; }
        public double? AnimateGraduallyDelay { get; set; }
        public bool? DynamicAnimationEnabled { get; set; }
        public double? DynamicAnimationSpeed { get; set; }

        #region Method Chaining

        public Animations SetEnabled(bool enabled)
        {
            Enabled = enabled;
            return this;
        }

        public Animations SetEasing(Easing? easing)
        {
            Easing = easing;
            return this;
        }

        public Animations SetSpeed(double? speed)
        {
            Speed = speed;
            return this;
        }

        public Animations SetAnimateGraduallyEnabled(bool? animateGraduallyEnabled)
        {
            AnimateGraduallyEnabled = animateGraduallyEnabled;
            return this;
        }

        public Animations SetAnimateGraduallyDelay(double? animateGraduallyDelay)
        {
            AnimateGraduallyDelay = animateGraduallyDelay;
            return this;
        }

        public Animations SetDynamicAnimationEnabled(bool? dynamicAnimationEnabled)
        {
            DynamicAnimationEnabled = dynamicAnimationEnabled;
            return this;
        }

        public Animations SetDynamicAnimationSpeed(double? dynamicAnimationSpeed)
        {
            DynamicAnimationSpeed = dynamicAnimationSpeed;
            return this;
        }


        #endregion
    }

    public class AnimationsConverter : JsonConverter<Animations>
    {
        public override Animations Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return null;

        }

        public override void Write(Utf8JsonWriter writer, Animations value, JsonSerializerOptions options)
        {
            if (value != null)
            {
                writer.WriteStartObject();

                if (!value.Enabled)
                    writer.WriteBoolean("enabled", value.Enabled);

                if (value.Easing.HasValue)
                    writer.WriteString("easing", value.Easing.Value.Name());

                if (value.Speed.HasValue)
                    writer.WriteNumber("speed", value.Speed.Value);

                if (value.AnimateGraduallyEnabled.HasValue || value.AnimateGraduallyDelay.HasValue)
                {
                    writer.WriteStartObject("animateGradually");

                    if (value.AnimateGraduallyEnabled.HasValue)
                        writer.WriteBoolean("enabled", value.AnimateGraduallyEnabled.Value);

                    if (value.AnimateGraduallyDelay.HasValue)
                        writer.WriteNumber("delay", value.AnimateGraduallyDelay.Value);

                    writer.WriteEndObject();
                }

                if (value.DynamicAnimationEnabled.HasValue || value.DynamicAnimationSpeed.HasValue)
                {
                    writer.WriteStartObject("dynamicAnimation");

                    if (value.DynamicAnimationEnabled.HasValue)
                        writer.WriteBoolean("enabled", value.DynamicAnimationEnabled.Value);

                    if (value.DynamicAnimationSpeed.HasValue)
                        writer.WriteNumber("speed", value.DynamicAnimationSpeed.Value);

                    writer.WriteEndObject();
                }

                writer.WriteEndObject();
            }
        }
    }

}
