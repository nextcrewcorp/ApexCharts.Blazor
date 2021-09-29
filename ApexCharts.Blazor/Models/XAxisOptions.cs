using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class XAxisOptions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public XAxisType Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<string> Categories { get; set; } = new List<string>();

        #region Method Chaining

        public XAxisOptions SetType(XAxisType type)
        {
            Type = type;
            return this;
        }

        public XAxisOptions SetCategories(IEnumerable<string> categories)
        {
            Categories = categories.ToList();
            return this;
        }

        public XAxisOptions AddCategory(string category)
        {
            Categories.Add(category);
            return this;
        }

        #endregion
    }
}
