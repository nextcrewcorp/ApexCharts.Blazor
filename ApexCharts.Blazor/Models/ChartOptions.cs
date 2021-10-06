using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class ChartOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Animations Animations { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Brush Brush { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Background { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DefaultLocale { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string FontFamily { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ForeColor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Group { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ChartType? Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Height { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? OffsetX { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? OffsetY { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? ParentHeightOffset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? RedrawOnParentResize { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Width { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ZoomOptions Zoom { get; set; }

        public bool Stacked { get; set; } = false;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DropShadow DropShadow { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ToolbarOptions Toolbar { get; set; }

        #region Method Chaining

        public ChartOptions SetAnimations(Animations animations)
        {
            Animations = animations;
            return this;
        }

        public ChartOptions SetBrush(Brush brush)
        {
            Brush = brush;
            return this;
        }

        public ChartOptions SetBackground(string background)
        {
            Background = background;
            return this;
        }

        public ChartOptions SetDefaultLocale(string defaultLocale)
        {
            DefaultLocale = defaultLocale;
            return this;
        }

        public ChartOptions SetDropShadow(DropShadow dropShadow)
        {
            DropShadow = dropShadow;
            return this;
        }

        public ChartOptions SetFontFamily(string fontFamily)
        {
            FontFamily = fontFamily;
            return this;
        }

        public ChartOptions SetForeColor(string foreColor)
        {
            ForeColor = foreColor;
            return this;
        }

        public ChartOptions SetGroup(string group)
        {
            Group = group;
            return this;
        }

        public ChartOptions SetHeight(string height)
        {
            Height = height;
            return this;
        }

        public ChartOptions SetOffsetX(decimal? offsetX)
        {
            OffsetX = offsetX;
            return this;
        }

        public ChartOptions SetOffsetY(decimal? offsetY)
        {
            OffsetY = offsetY;
            return this;
        }

        public ChartOptions SetParentHeightOffset(decimal? parentHeightOffset)
        {
            ParentHeightOffset = parentHeightOffset;
            return this;
        }

        public ChartOptions SetRedrawOnParentResize(bool? redrawOnParentResize)
        {
            RedrawOnParentResize = redrawOnParentResize;
            return this;
        }

        public ChartOptions SetType(ChartType type)
        {
            Type = type;
            return this;
        }

        public ChartOptions SetWidth(string width)
        {
            Width = width;
            return this;
        }

        public ChartOptions SetZoom(ZoomOptions zoom)
        {
            Zoom = zoom;
            return this;
        }

        public ChartOptions SetStacked(bool stacked)
        {
            Stacked = stacked;
            return this;
        }

        public ChartOptions SetToolbar(ToolbarOptions toolbar)
        {
            Toolbar = toolbar;
            return this;
        }

        #endregion
    }
}
