using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class GridOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Show { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string BorderColor { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int StrokeDashArray { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public GridPosition Position { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("xaxis")]
        public GridXAxisOptions XAxis { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("yaxis")]
        public GridYAxisOptions YAxis { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public GridRowOptions Row { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public GridColumnOptions Column { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Padding Padding { get; set; }

        #region Method Chaining

        public GridOptions SetShow(bool show)
        {
            Show = show;
            return this;
        }

        public GridOptions SetBorderColor(string value)
        {
            BorderColor = value;
            return this;
        }

        public GridOptions SetRow(GridRowOptions value)
        {
            Row = value;
            return this;
        }

        #endregion
    }
}
