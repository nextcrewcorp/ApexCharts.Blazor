using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCharts.Blazor.Models
{
    public static class BaseSeriesExtensions
    {
        const string s4 = "    ";
        static string nl = Environment.NewLine;

        public static string ToCodeString(this List<BaseSeries> s)
        {
            var indent = Indent(1);
            var sb = new StringBuilder();

            sb.Append($"{indent}public List<BaseSeries> series = new List<BaseSeries>");
            sb.Append($"{nl}{indent}{{");
            indent = Indent(2);

            foreach (var series in s)
            {
                if (series is Series)
                {
                    sb.Append($"{nl}{indent}new Series");
                    sb.Append($"{nl}{indent}{{");

                    sb.Append($"{nl}{indent}}}");
                }
                else if (series is SimpleSeries)
                {

                }
            }

            indent = Indent(1);
            sb.Append($"{nl}{indent}}}");
            return sb.ToString();
        }

        private static string Indent(int depth)
        {
            return string.Join(s4, new string[depth + 1]);
        }
    }
}
