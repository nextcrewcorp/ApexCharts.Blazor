﻿using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class BarPlotOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Horizontal { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double BorderRadius { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ColumnWidth { get; set; }

        #region Method Chaining

        public BarPlotOptions SetHorizontal(bool horizontal)
        {
            Horizontal = horizontal;
            return this;
        }

        public BarPlotOptions SetBorderRadius(double borderRadius)
        {
            BorderRadius = borderRadius;
            return this;
        }
        public BarPlotOptions SetColumnWidth(string columnWidth)
        {
            ColumnWidth = columnWidth;
            return this;
        }

        #endregion
    }
}
