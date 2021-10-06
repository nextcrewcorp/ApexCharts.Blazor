using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class GridRowOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Colors { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? Opacity { get; set; }

        #region Method Chaining

        public GridRowOptions SetColors(IEnumerable<string> value)
        {
            Colors = value.ToList();
            return this;
        }

        public GridRowOptions AddColor(string value)
        {
            if (Colors == null)
                Colors = new List<string>();

            Colors.Add(value);
            return this;
        }

        public GridRowOptions SetOpacity(decimal? value)
        {
            Opacity = value;
            return this;
        }


        #endregion
    }
}
