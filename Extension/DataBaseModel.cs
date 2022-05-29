using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data table model
namespace Extension
{
    [Table(Name = "Student")]
    public class DataBaseModel
    {
        [Column(Name = "Name", Type = "string", Required = "Required")]
        public string Columns { get; set; }
    }
}
