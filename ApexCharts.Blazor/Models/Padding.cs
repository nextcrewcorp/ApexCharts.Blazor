using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApexCharts.Blazor.Models
{
    public class Padding
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Top { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Right { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Bottom { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Left { get; set; }
    }
}
