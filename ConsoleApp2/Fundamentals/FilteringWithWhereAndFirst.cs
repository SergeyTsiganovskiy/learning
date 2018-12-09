using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Fundamentals
{
    public class FilteringWithWhereAndFirst
    {
        public static void Main4(string[] args)
        {
            var cars = ProcessFile("Fundamentals/fuel.csv");

            var query =
                from car in cars
                where car.Manufacturer == "BMW" && car.Year == 2016
                orderby car.Combined, car.Name
                select car;

            var query2 = cars
                .Where(c => c.Manufacturer == "BMW" && c.Year == 2016)
                .OrderBy(c => c.Combined)
                .ThenBy(c => c.Name)
                .Select(c => c);

            var query3 = cars
                .Where(c => c.Manufacturer == "BMW" && c.Year == 2016)
                .OrderBy(c => c.Combined)
                .ThenBy(c => c.Name)
                .FirstOrDefault();

            Console.WriteLine($"{query3?.Manufacturer} : {query3?.Name}");

            //foreach (var car in query2.Take(10))
            //{
            //    Console.WriteLine($"{car.Manufacturer} : {car.Name} : {car.Combined}");
            //}

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
