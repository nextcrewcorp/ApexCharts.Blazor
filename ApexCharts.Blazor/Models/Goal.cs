using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class Goal
    {
        public string Name { get; set; }
        public decimal? Value { get; set; }
        public decimal? StrokeWidth { get; set; }
        public string StrokeColor { get; set; }

        #region Method Chaining

        public Goal SetName(string name)
        {
            Name = name;
            return this;
        }

        public Goal SetValue(decimal? value)
        {
            Value = value;
            return this;
        }

        public Goal SetStrokeWidth(decimal strokeWidth)
        {
            StrokeWidth = strokeWidth;
            return this;
        }

        public Goal SetStrokeColor(string strokeColor)
        {
            StrokeColor = strokeColor;
            return this;
        }

        #endregion
    }
}
