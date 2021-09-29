using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class FillOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double Opacity { get; set; }

        #region Method Chaining

        public FillOptions SetOpacity(double opacity)
        {
            Opacity = opacity;
            return this;
        }

        #endregion
    }
}
