using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class YAxisOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Opposite { get; set; } = false;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public YAxisTitle Title { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public YAxisTooltip Tooltip { get; set; }

        public static YAxisOptions[] CreateSingle(YAxisOptions yaxis)
        {
            return new YAxisOptions[]
            {
                yaxis
            };
        }

        public static YAxisOptions[] CreateDouble(YAxisOptions yaxis1, YAxisOptions yaxis2)
        {
            return new YAxisOptions[]
            {
                yaxis1,
                yaxis2
            };
        }

        #region Method Chaining

        public YAxisOptions SetOpposite(bool opposite)
        {
            Opposite = opposite;
            return this;
        }

        public YAxisOptions SetTitle(YAxisTitle title)
        {
            Title = title;
            return this;
        }

        public YAxisOptions SetTooltip(YAxisTooltip tooltip)
        {
            Tooltip = tooltip;
            return this;
        }

        #endregion
    }
}
