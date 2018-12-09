using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Fundamentals
{
    public class ProjectingDataWithSelect
    {
        public static void Main5(string[] args)
        {
            var cars = ProcessFile("Fundamentals/fuel.csv");

            var query =
                from car in cars
                where car.Manufacturer == "BMW" && car.Year == 2016
                orderby car.Combined, car.Name
                select new
                {
                    car.Manufacturer,
                    car.Name
                };

            var anon = new {Name = "Scott"};

            var query2 = cars.Select(c => new {c.Manufacturer, c.Name, c.Combined});

            foreach (var car in query)
            {
                Console.WriteLine(car.Manufacturer);
            }
            
        }

        private static List<Car> ProcessFile(string path)
        {
            var query =  File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(Car.ParseFromCsv);

            return query.ToList();
        }

        private static List<Car> ProcessFile2(string path)
        {
            var query = File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .ToCar();

            return query.ToList();
        }
    }

    public static class CarExtension
    {
        public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
        {
            foreach (var line in source)
            {
                var columns = line.Split(',');

                yield return new Car
                {
                    Year = int.Parse(columns[0]),
                    Manufacturer = columns[1],
                    Name = columns[2],
                    Displacement = double.Parse(columns[3]),
                    Cylinders = int.Parse(columns[4]),
                    City = int.Parse(columns[5]),
                    Highway = int.Parse(columns[6]),
                    Combined = int.Parse(columns[7])
                };
            }
        }

    }
}
