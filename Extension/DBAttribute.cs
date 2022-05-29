using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    // Table name attribute
    [AttributeUsage (AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string Name { get; set; }
    }

    // Columns attribute
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Required { get; set; }
    }
}
