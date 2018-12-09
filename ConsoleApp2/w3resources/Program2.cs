using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main2(string[] args)
        {
            string chst, chen;
            char ch;
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
            Console.Write("\n-----------------------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

            Console.Write("\nInput starting character for the string : ");
            ch = (char)Console.Read();
            chst = ch.ToString();
            Console.Write("\nInput ending character for the string : ");
            ch = (char)Console.Read();
            chen = ch.ToString();

            var result = from x in cities
                         where x.StartsWith(chst)
                         where x.EndsWith(chen)
                         select x;
            Console.Write("\n\n");
            foreach (var city in result)
            {
                Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, city);
            }
            Console.ReadLine();
            //----------------------------------------------------------------------------------------------
            var i = 0;
            var templist = new List<int>
            {
                55,
                200,
                740,
                76,
                230,
                482,
                95
            };

            Console.Write("\nLINQ : Create a list of numbers and display the numbers greater than 80 : ");
            Console.Write("\n-------------------------------------------------------------------------\n");
            Console.WriteLine("\nThe members of the list are : ");
            foreach (var lstnum in templist)
            {
                Console.Write(lstnum + " ");
            }
            List<int> FilterList = templist.FindAll(x => x > 80);
            Console.WriteLine("\n\nThe numbers greater than 80 are : ");
            foreach (var num in FilterList)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
            //----------------------------------------------------------------------------------------------

        }
    }
}
