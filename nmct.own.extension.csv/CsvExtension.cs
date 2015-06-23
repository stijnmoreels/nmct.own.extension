using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsvExtension
{
    public static class CsvExtensionClass
    {
        public static string ToCsv<T>(this IEnumerable<T> items, string seperator = ";") where T : class
        {
            // Get all properties (with Attribute = "CsvAttribute") from 'T'
            IEnumerable<string> properties = typeof(T).GetProperties()
                .Where(p => p.IsDefined(typeof(CsvAttribute), true))
                .Select(p => p.Name);
            
            // Make sure we have valid lists
            items = items ?? new List<T>();
            properties = properties ?? new List<string>();

            // Make headerline from properties
            string headerline = String.Join(seperator, properties) + Environment.NewLine;

            // Run through all items and get properties with Attribute = "CsvAttribute"
            IList<string> valuelines = new List<string>();
            foreach(T item in items)
            {
                foreach(string property in properties)
                {
                    object value = item.GetType().GetProperty(property).GetValue(item, null);
                    valuelines.Add(value.ToString() + seperator);
                }
                valuelines.Add(Environment.NewLine);
            }
            
            // return headerline concatenate with the values
            return headerline + String.Join(String.Empty, valuelines);
        }
    }

    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public sealed class CsvAttribute : Attribute
    {
       
    }
}
