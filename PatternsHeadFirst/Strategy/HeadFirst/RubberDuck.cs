using System;

namespace PatternsHeadFirst.Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duckie");
        }
    }
}
