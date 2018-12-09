using System;

namespace PatternsHeadFirst.Strategy
{
    public class FakeQuack : IQuackBehavior
    {

        public void Quack()
        {
            Console.WriteLine("Qwak");
        }
    }
}
