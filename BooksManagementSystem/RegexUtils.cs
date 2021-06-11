using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsWithSql
{
    class RegexUtils
    {
        public static bool CheckPrice(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d+([.]{1}\d+){0,1}$");
        }

        public static bool CheckDate(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d{4}-\d{1,2}-\d{1,2}$");
        }
    }
}
