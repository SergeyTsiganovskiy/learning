using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Fundamentals
{
    public class ProcessCSVFile
    {
        public static void Main3(string[] args)
        {
            var cars = ProcessCars("Fundamentals/fuel.csv");

            var query = cars.OrderByDescending(c => c.Combined)
                .ThenBy(c => c.Name);

            var query2 =
                from car in cars
                orderby car.Combined descending, car.Name descending
                select car; 
             
            foreach (var car in query2.Take(10) )
            {
                Console.WriteLine($"{car.Name} : {car.Combined}");
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

        private static List<Car> ProcessFile2(string path)
        {
            var query = from line in File.ReadAllLines(path).Skip(1)
                where line.Length > 1
                select Car.ParseFromCsv(line);

            return query.ToList();
        }
    }
}
