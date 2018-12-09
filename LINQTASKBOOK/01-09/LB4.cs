using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB4
    {
        public static void Main4(string[] args)
        {
            char ch = 'z';
            string[] strarr = { "asfd","s25","2dbf","4fbdfb", "5ddddd"};
            string res = string.Empty;

            try
            {
                // v1
                res = strarr.Single(x => x.ToCharArray().Last().Equals(ch));
                // v2
                res = strarr.Single(x => x.Length != 0 && x[x.Length - 1] == ch);
                // v3
                Console.WriteLine(strarr.Single(x => x.EndsWith(ch.ToString())));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message.Contains("more") ? "Error" : string.Empty);
            }
        }
    }
}
