using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program3
    {
        static void Main3(string[] args)
        {

            Console.Write("\nLINQ : Find the uppercase words in a string : ");
            Console.Write("\n----------------------------------------------\n");

            string strNew;

            Console.Write("Input the string : ");
            strNew = Console.ReadLine();

            var ucWord = WordFilt(strNew);
            Console.Write("\nThe UPPER CASE words are :\n ");
            foreach (string strRet in ucWord)
            {
                Console.WriteLine(strRet.Trim());
            }
            Console.ReadLine();
        }

        static IEnumerable<string> WordFilt(string mystr)
        {
            var upWord = mystr.Split(' ')
                .Where(x => String.Equals(x, x.ToUpper(),
                    StringComparison.Ordinal));

            return upWord;

        }
    }
}
