using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB3
    {
        public static void Main3(string[] args)
        {
            int l = 26;
            string[] strarr = { "asfd","s25","2dbf","4fbdfb", "5ddddd"};

            string res = strarr.LastOrDefault(x => char.IsNumber(x.ToCharArray()[0]) && x.Length == l) ?? "Not found";
            
            Console.WriteLine(res);
        }
    }
}
