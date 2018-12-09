using System;

namespace PatternsHeadFirst.Strategy
{
    public class QuackSilently : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
