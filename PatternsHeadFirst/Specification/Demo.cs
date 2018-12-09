using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHeadFirst.Specification
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }

        public override string ToString()
        {
            return $" - {Name} : {Color} : {Size}";
        }
    }

    public interface ISpecification<T>
    {
        bool IsSatisfied(T t); 
    }
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }

    public class BucketFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            return items.Where(i => spec.IsSatisfied(i));
        }
    }


    public class Demo
    {
        public static void Main6(string[] args)
        {
            // var apple = new Product("Apple", Color.Green, Size.Small);

            //Product[] products = {apple};

            //var pf = new BucketFilter();
            //foreach (var item in pf.Filter(products, new ColorSpecification(Color.Green)))
            //{
            //    Console.WriteLine(item);
            //    Console.ReadKey();
            //}

            //Garage garage = new Garage();
            //var list = new List<Car>(){ new Car { Name = "BMW" } , new Car { Name = "AUDI" } };
            //garage.Cars = list;

            //Console.WriteLine(garage.ToString());
            //Console.ReadKey();

            double amount = 1.11; //количество биткоинов от одного человека
            int peopleCount = 60; // количество человек
            int totalMoney = (int)amount * peopleCount; // ← исправьте ошибку в этой строке
            Console.WriteLine(totalMoney);
            Console.ReadKey(); 
        }
    }


    public class Car
    {
        public string Name;

        public override string ToString()
        {
            return Name;
        }
    }

    public class Garage
    {
        public List<Car> Cars;

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Cars);
        }
    }
}
