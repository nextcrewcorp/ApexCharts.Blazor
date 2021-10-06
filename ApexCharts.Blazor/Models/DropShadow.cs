using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class DropShadow
    {
        public bool Enabled { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<int> EnabledOnSeries { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? Top { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? Left { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? Blur { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Color { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? Opacity { get; set; }

        #region Method Chaining

        public DropShadow SetEnabled(bool enabled)
        {
            Enabled = enabled;
            return this;
        }

        public DropShadow SetEnabledOnSeries(IEnumerable<int> indexes)
        {
            EnabledOnSeries = indexes.ToList();
            return this;
        }

        public DropShadow AddEnabledOnSeries(int index)
        {
            if (EnabledOnSeries == null)
                EnabledOnSeries = new List<int>();

            EnabledOnSeries.Add(index);
            return this;
        }

        public DropShadow SetTop(decimal? top)
        {
            Top = top;
            return this;
        }

        public DropShadow SetLeft(decimal? left)
        {
            Left = left;
            return this;
        }

        public DropShadow SetBlur(decimal? blur)
        {
            Blur = blur;
            return this;
        }

        public DropShadow SetColor(IEnumerable<string> color)
        {
            Color = color.ToList();
            return this;
        }

        public DropShadow AddColor(string color)
        {
            if (Color == null)
                Color = new List<string>();

            Color.Add(color);
            return this;
        }

        public DropShadow SetOpacity(decimal? opacity)
        {
            Opacity = opacity;
            return this;
        }


        #endregion
    }
}
