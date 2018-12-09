using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB5
    {
        public static void Main5(string[] args)
        {
            char ch = 'z';
            string[] strarr = { "asfd","s25","2dbf","4fbdfb", "5ddddd","zsz"};
            var res = from elem in strarr
                let elemchars = elem.ToCharArray()
                where elemchars.FirstOrDefault().Equals(ch) 
                      && elemchars.LastOrDefault().Equals(ch)
                select elem;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
