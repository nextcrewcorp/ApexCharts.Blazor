using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class MarkerOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("size")]
        public List<int> Sizes { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Colors { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> StrokeColors { get; set; }

        #region Method Chaining

        public MarkerOptions SetSizes(IEnumerable<int> sizes)
        {
            Sizes = sizes.ToList();
            return this;
        }

        public MarkerOptions AddSize(int size)
        {
            if (Sizes == null)
                Sizes = new List<int>();

            Sizes.Add(size);
            return this;
        }

        public MarkerOptions SetColors(IEnumerable<string> colors)
        {
            Colors = colors.ToList();
            return this;
        }

        public MarkerOptions AddColor(string color)
        {
            if (Colors == null)
                Colors = new List<string>();

            Colors.Add(color);
            return this;
        }

        public MarkerOptions SetStrokeColors(IEnumerable<string> strokeColors)
        {
            StrokeColors = strokeColors.ToList();
            return this;
        }

        public MarkerOptions AddStrokeColor(string strokeColor)
        {
            if (StrokeColors == null)
                StrokeColors = new List<string>();

            StrokeColors.Add(strokeColor);
            return this;
        }

        #endregion
    }
}
