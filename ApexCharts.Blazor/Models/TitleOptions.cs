using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class TitleOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Text { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public HorizontalAlignment Align { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Margin { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int OffsetX { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int OffsetY { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Floating { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public StyleOptions Style { get; set; }

        #region Method Chaining

        public TitleOptions SetText(string text)
        {
            Text = text;
            return this;
        }

        public TitleOptions SetAlign(HorizontalAlignment align)
        {
            Align = align;
            return this;
        }

        public TitleOptions SetMargin(int margin)
        {
            Margin = margin;
            return this;
        }

        public TitleOptions SetOffsetX(int offsetX)
        {
            OffsetX = offsetX;
            return this;
        }

        public TitleOptions SetOffsetY(int offsetY)
        {
            OffsetY = offsetY;
            return this;
        }

        public TitleOptions SetFloating(bool floating)
        {
            Floating = floating;
            return this;
        }

        public TitleOptions SetStyle(StyleOptions styleOptions)
        {
            Style = styleOptions;
            return this;
        }

        #endregion
    }
}
