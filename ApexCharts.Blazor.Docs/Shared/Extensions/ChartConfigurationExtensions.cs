using System.Text;

namespace ApexCharts.Blazor.Models
{
    public static class ChartConfigurationExtensions
    {
        const string s4 = "    ";

        public static string ToCodeString(this ChartConfiguration c)
        {
            var sb = new StringBuilder();


            sb.Append($"{s4}ChartConfiguration config = new Configuration()");

            //sb.AppendLine("");

            return sb.ToString();
        }
    }
}
