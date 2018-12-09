using System;

namespace PatternsHeadFirst.Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new QuackSilently();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
