using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Fundamentals
{
    public class QuantifingDataWihAnyAllContains
    {
        public static void Main5(string[] args)
        {
            var cars = ProcessFile("Fundamentals/fuel.csv");

            var resAny = cars.Any(c => c.Manufacturer == "Ford");
            var resContains = cars.Contains(new Car());
            var resAll = cars.All(c => c.Manufacturer == "Ford");

            Console.WriteLine(resAny);
            Console.WriteLine(resAll);
            Console.WriteLine(resContains);
        }

        private static List<Car> ProcessFile(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(Car.ParseFromCsv)
                .ToList();
        }
    }
}
