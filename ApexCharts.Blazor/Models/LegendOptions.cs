using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class LegendOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Show { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool ShowForSingleSeries { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public HorizontalAlignment HorizontalAlign { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Position Position { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> CustomLegendItems { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public LegendMarkerOptions Markers { get; set; }

        #region Method Chaining

        public LegendOptions SetShow(bool show)
        {
            Show = show;
            return this;
        }

        public LegendOptions SetShowForSingleSeries(bool showForSingleSeries)
        {
            ShowForSingleSeries = showForSingleSeries;
            return this;
        }

        public LegendOptions SetHorizontalAlign(HorizontalAlignment align)
        {
            HorizontalAlign = align;
            return this;
        }

        public LegendOptions SetPosition(Position position)
        {
            Position = position;
            return this;
        }

        public LegendOptions SetCustomLegendItems(IEnumerable<string> customLegendItems)
        {
            CustomLegendItems = customLegendItems.ToList();
            return this;
        }

        public LegendOptions AddCustomLegendItem(string customLegendItem)
        {
            if (CustomLegendItems == null)
                CustomLegendItems = new List<string>();

            CustomLegendItems.Add(customLegendItem);
            return this;
        }

        public LegendOptions SetMarkers(LegendMarkerOptions markers)
        {
            Markers = markers;
            return this;
        }

        #endregion

    }
}
