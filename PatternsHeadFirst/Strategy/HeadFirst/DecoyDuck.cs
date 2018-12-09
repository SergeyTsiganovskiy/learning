using System;

namespace PatternsHeadFirst.Strategy
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new MuteQuack());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a duck Decoy");
        }
    }
}
