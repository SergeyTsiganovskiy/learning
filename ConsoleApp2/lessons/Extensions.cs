
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.lessons
{
    public static class Extensions
    {
        public static string ChangeFirstLetterCase(this string str)
        {
            char[] arr = str.ToCharArray();
            arr[0] = char.IsUpper(arr[0]) ? char.ToLower(arr[0]) : char.ToUpper(arr[0]);
            return new string(arr);
        }
    }
}
