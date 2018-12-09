using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCookBook.Ch2
{
    public class Pr1
    {
        public static void Main(string[] args)
        {
            char ch = ' ';
            bool flag = char.IsNumber(ch);

            string str = " ";
            bool flag2 = char.IsLetter(str, 1);

            bool flag3 = str.StartsWith(str, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
