﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Fundamentals
{
    public class JoiningGroupingAggregating
    {
        public static void Main6(string[] args)
        {
            var cars = ProcessCars("Fundamentals/fuel.csv");
            var manufacturers = ProcessManufactures("Fundamentals/manufacturers.csv");

            var queary =
                from car in cars
                join manufacturer in manufacturers
                    on car.Manufacturer equals manufacturer.Name
                orderby car.Combined descending, car.Name
                select new
                {
                    manufacturer.Headquarters,
                    car.Name,
                    car.Combined
                };

            foreach (var car in queary.Take(10))
            {
                Console.WriteLine($"{car.Headquarters} : {car.Name} : {car.Combined}");
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
