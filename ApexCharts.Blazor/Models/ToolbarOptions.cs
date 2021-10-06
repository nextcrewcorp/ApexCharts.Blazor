using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class ToolbarOptions
    {
        public bool Show { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? OffsetX { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? OffsetY { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Tools Tools { get; set; }

        #region Method Chaining

        public ToolbarOptions SetShow(bool show)
        {
            Show = show;
            return this;
        }

        public ToolbarOptions SetOffsetX(decimal? offsetX)
        {
            OffsetX = offsetX;
            return this;
        }

        public ToolbarOptions SetOffsetY(decimal? offsetY)
        {
            OffsetY = offsetY;
            return this;
        }

        public ToolbarOptions SetTools(Tools tools)
        {
            Tools = tools;
            return this;
        }


        #endregion
    }
}
