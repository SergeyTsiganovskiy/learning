using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate int ArithmeticOperation(int x, int y);

    //Info 
    //As Lambda  is data type we can put it as parameter
    //into another methods as variable
    public class Lambda
    {
        static void Main8(string[] args)
        {

            Calculator calculator = new Calculator();
            ArithmeticOperation func1 = calculator.PlusFunction1();
            Console.WriteLine(func1(2, 3));

            Func<int, int, int> func2 = calculator.PlusFunction3();
            Console.WriteLine(func2(2, 3));

            // even without class Calculator

            Func<int, int, int> func3 = (x, y) => x + y;
            Console.WriteLine(func3(2, 3));

            // Lambda into Lambda

            Func<int, Func<int, int, int>, int> func4 = (k, f) => f(2, 3) * k;
            int result = func4(5, func3);

            // Recurcion with Lambda
            Func<int, int> fc = null;
            fc = i => i == 0 ? 0 : fc(--i);
            fc(10);

            // another way
            fc = i =>
            {
                Console.WriteLine(i);
                return i == 0 ? 0 : fc(--i);
            };

            // zamikanie1

            Action action = null;

            for (int cycleCounter = 1; cycleCounter <= 4; cycleCounter++)
            {
                action = () => Console.WriteLine(cycleCounter);
                action(); // out -> 5,5,5,5
            }

            // zamikanie2

            Action action2 = null;

            for (int cycleCounter = 1; cycleCounter <= 4; cycleCounter++)
            {
                int buffer = cycleCounter;
                action2 += () => Console.WriteLine(buffer);
            }

            action2(); // out -> 1,2,3,4
            Console.ReadLine();

            // Expression - is a discription of func  - not reference
            // It gives us an opportunity to change dynamically final lambda expression
            // They work only with atomic operations

            Expression<Func<int, int, int, int>> expr = (x, y, z) => (x + y) * z;
            expr.Compile();
        }
    }

    public class Calculator
    {
        public ArithmeticOperation PlusFunction1()
        {
            ArithmeticOperation func = delegate(int x, int y) { return x + y; };
            return func;
        }

        // the same  but with local function
        public ArithmeticOperation PlusFunction2()
        {
            int Func(int x, int y)
            {
                return x + y;
            }
            return Func;
        }

        // the same  but with Func
        public Func<int, int, int> PlusFunction3()
        {
            Func<int,int,int> func = delegate (int x, int y) { return x + y; };
            return func;
        }

        // the same  but with Lambda
        public Func<int, int, int> PlusFunction4()
        {
            Func<int, int, int> func = (x,  y) => x + y;
            return func;
        }
    }

}
