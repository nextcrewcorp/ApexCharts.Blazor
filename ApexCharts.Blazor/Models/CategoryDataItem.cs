using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class CategoryDataItem : DataItem
    {

        public string Category { get; set; }
        public decimal? Y { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Goal> Goals { get; set; }

        public CategoryDataItem() { }
        public CategoryDataItem(string category, decimal? y)
        {
            Category = category;
            Y = y;
        }

        public void WriteJson(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();

            writer.WriteString("x", Category);

            if (Y.HasValue)
                writer.WriteNumber("y", Y.Value);
            else
                writer.WriteNull("y");

            if (Goals != null)
            {
                writer.WriteStartArray("goals");

                foreach (var goal in Goals)
                {
                    writer.WriteStartObject();

                    if (goal.Name != null)
                        writer.WriteString("name", goal.Name);

                    if (goal.Value.HasValue)
                        writer.WriteNumber("value", goal.Value.Value);
                    else
                        writer.WriteNull("value");

                    if (goal.StrokeWidth.HasValue)
                        writer.WriteNumber("strokeWidth", goal.StrokeWidth.Value);

                    if (goal.StrokeColor != null)
                        writer.WriteString("strokeColor", goal.StrokeColor);

                    writer.WriteEndObject();
                }

                writer.WriteEndArray();
            }

            writer.WriteEndObject();
        }

        public static IEnumerable<CategoryDataItem> FromDictionary(IDictionary<string, decimal?> dictionary)
        {
            return dictionary.Select(x => new CategoryDataItem(x.Key, x.Value));
        }

        #region Method Chaining

        public CategoryDataItem SetGoals(IEnumerable<Goal> goals)
        {
            Goals = goals.ToList();
            return this;
        }

        public CategoryDataItem AddGoal(Goal goal)
        {
            if (Goals == null)
                Goals = new List<Goal>();

            Goals.Add(goal);
            return this;
        }

        #endregion
    }
}
