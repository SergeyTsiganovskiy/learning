using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Fundamentals
{
    public class GroupingData
    {
        public static void Main9(string[] args)
        {
            var cars = ProcessCars("Fundamentals/fuel.csv");
            var manufacturers = ProcessManufactures("Fundamentals/manufacturers.csv");

            //var queary = from car in cars
            //    group car by car.Manufacturer;

            //foreach (var result in queary)
            //{
            //    Console.WriteLine($"{result.Key} has {result.Count()} cars");
            //}


            //var queary2 = from car in cars
            //    group car by car.Manufacturer.ToUpper()
            //    into manufacturer
            //    orderby manufacturer.Key
            //    select manufacturer;

            // the same 

            var queary3 = cars.GroupBy(c => c.Manufacturer.ToUpper())
                .OrderBy(g => g.Key);

            foreach (var group in queary3)
            {
                Console.WriteLine(group.Key);
                foreach (var car in group.OrderByDescending(c => c.Combined).Take(2))
                {
                    Console.WriteLine($"\t{car.Name} : {car.Combined}");
                }
            }


        }

        private static List<Car> ProcessCars(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(Car.ParseFromCsv)
                .ToList();
        }

        private static List<Manufacturer> ProcessManufactures(string path)
        {
            var queary =
                File.ReadAllLines(path)
                    .Where(l => l.Length > 1)
                    .Select(l =>
                    {
                        var columns = l.Split(',');
                        return new Manufacturer
                        {
                            Name = columns[0],
                            Headquarters = columns[1],
                            Year = int.Parse(columns[2])
                        };
                    });

            return queary.ToList();
        }
    }
}
