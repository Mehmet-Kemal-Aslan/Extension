using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 // Returns difference of the entered DateTime and now.
namespace Extension
{
    public static class DateExtension
    {
        public static string DateDiffrence(this DateTime entry)
        {
            DateTime Now = DateTime.Now;
            var diff = Now - entry;
            string result = diff.Days + " days, " + diff.Hours + " hours, " + diff.Minutes + " minutes.";
            return result;
        }
    }
}
