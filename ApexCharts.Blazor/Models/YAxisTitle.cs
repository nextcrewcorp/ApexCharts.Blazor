using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class YAxisTitle
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Text { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Rotate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int OffsetX { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int OffsetY { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public StyleOptions Style { get; set; }

        #region Method Chaining

        public YAxisTitle SetText(string text)
        {
            Text = text;
            return this;
        }

        public YAxisTitle SetRotate(int rotate)
        {
            Rotate = rotate;
            return this;
        }

        public YAxisTitle SetOffsetX(int offsetX)
        {
            OffsetX = offsetX;
            return this;
        }

        public YAxisTitle SetOffsetY(int offsetY)
        {
            OffsetY = offsetY;
            return this;
        }

        public YAxisTitle SetStyle(StyleOptions style)
        {
            Style = style;
            return this;
        }

        #endregion
    }
}
