using System;

namespace PatternsHeadFirst.Strategy
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new QuackSilently();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Red Headed duck");
        }
    }
    

}
