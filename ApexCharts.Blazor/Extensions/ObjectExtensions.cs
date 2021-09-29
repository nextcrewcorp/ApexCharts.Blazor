using System.ComponentModel;
using System.Linq;

namespace System
{
    public static class ObjectExtensions
    {
        public static string Name(this object source)
        {
            var field = source.GetType().GetField(source.ToString());
            var attrs = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attrs != null && attrs.Length > 0)
            {
                var attr = attrs.First();

                return attr.Description;
            }
            else
            {
                return source.ToString();
            }
        }
    }
}