using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class StrokeOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Show { get; set; } = true;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public StrokeCurve Curve { get; set; } = StrokeCurve.Smooth;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public LineCap LineCap { get; set; } = LineCap.Butt;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<string> Colors { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<int> Width { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<int> DashArray { get; set; }

        #region Method Chaining

        public StrokeOptions SetShow(bool show)
        {
            Show = show;
            return this;
        }

        public StrokeOptions SetCurve(StrokeCurve curve)
        {
            Curve = curve;
            return this;
        }

        public StrokeOptions SetLineCap(LineCap linecap)
        {
            LineCap = linecap;
            return this;
        }

        public StrokeOptions SetColors(IEnumerable<string> colors)
        {
            Colors = colors.ToList();
            return this;
        }

        public StrokeOptions AddColor(string color)
        {
            if (Colors == null)
                Colors = new List<string>();

            Colors.Add(color);
            return this;
        }

        public StrokeOptions SetWidths(IEnumerable<int> widths)
        {
            Width = widths.ToList();
            return this;
        }

        public StrokeOptions AddWidth(int width)
        {
            if (Width == null)
                Width = new List<int>();

            Width.Add(width);
            return this;
        }

        public StrokeOptions SetDashArray(IEnumerable<int> dashArray)
        {
            DashArray = dashArray.ToList();
            return this;
        }

        public StrokeOptions AddToDashArray(int dash)
        {
            if (DashArray == null)
                DashArray = new List<int>();

            DashArray.Add(dash);
            return this;
        }


        #endregion
    }
}
