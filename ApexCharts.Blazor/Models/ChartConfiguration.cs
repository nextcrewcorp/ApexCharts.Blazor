using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class ChartConfiguration
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<BaseSeries> Series { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ChartOptions Chart { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DataLabelsOptions DataLabels { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public StrokeOptions Stroke { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public TitleOptions Title { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public TitleOptions Subtitle { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public GridOptions Grid { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("xaxis")]
        public XAxisOptions XAxis { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("yaxis")]
        public List<YAxisOptions> YAxis { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public LegendOptions Legend { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("plotOptions")]
        public PlotOptions Plot { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public FillOptions Fill { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public TooltipOptions Tooltip { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Labels { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Colors { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ResponsiveOptions> Responsive { get; set; }

        #region Method Chaining

        public ChartConfiguration SetChart(ChartOptions chart)
        {
            Chart = chart;
            return this;
        }

        public ChartConfiguration SetDataLabels(DataLabelsOptions dataLabels)
        {
            DataLabels = dataLabels;
            return this;
        }

        public ChartConfiguration SetStroke(StrokeOptions stroke)
        {
            Stroke = stroke;
            return this;
        }

        public ChartConfiguration SetTitle(TitleOptions title)
        {
            Title = title;
            return this;
        }

        public ChartConfiguration SetSubtitle(TitleOptions subtitle)
        {
            Subtitle = subtitle;
            return this;
        }

        public ChartConfiguration SetGrid(GridOptions grid)
        {
            Grid = grid;
            return this;
        }

        public ChartConfiguration SetXAxis(XAxisOptions xaxis)
        {
            XAxis = xaxis;
            return this;
        }

        public ChartConfiguration AddYAxis(YAxisOptions yaxis)
        {
            if (YAxis == null)
                YAxis = new List<YAxisOptions>();

            YAxis.Add(yaxis);
            return this;
        }

        public ChartConfiguration SetLegend(LegendOptions legend)
        {
            Legend = legend;
            return this;
        }

        public ChartConfiguration SetPlot(PlotOptions plot)
        {
            Plot = plot;
            return this;
        }

        public ChartConfiguration SetFill(FillOptions fill)
        {
            Fill = fill;
            return this;
        }

        public ChartConfiguration SetTooltip(TooltipOptions tooltip)
        {
            Tooltip = tooltip;
            return this;
        }

        public ChartConfiguration SetLabels(IEnumerable<string> labels)
        {
            Labels = labels.ToList();
            return this;
        }

        public ChartConfiguration AddLabel(string label)
        {
            if (Labels == null)
                Labels = new List<string>();

            Labels.Add(label);
            return this;
        }

        public ChartConfiguration SetColors(IEnumerable<string> colors)
        {
            Colors = colors.ToList();
            return this;
        }

        public ChartConfiguration AddColor(string color)
        {
            if (Colors == null)
                Colors = new List<string>();

            Colors.Add(color);
            return this;
        }

        public ChartConfiguration AddResponsive(ResponsiveOptions responsive)
        {
            if (Responsive == null)
                Responsive = new List<ResponsiveOptions>();

            Responsive.Add(responsive);
            return this;
        }

        #endregion
    }
}
