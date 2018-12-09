using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures.Generics
{

    // WAYS TO USE GENERICS
    class Generics
    {
        public void Move<T>(T distance)
        {
        }
    }

    public interface IShip<T>
    {
    }

    public class Car<T>
    {
        public T Move(T distance)
        {
            T res = distance;
            return res;
        }
    }

    // RESTRICTIONS IN GENERICS
    public class Animal
    {
        public void Move()
        {
        }
    }

    public class Cat : Animal
    {
    }

    public class Dog : Animal
    {
    }

    public class Zoo<T> where T : Animal, new()
    {
        public void MoveAnimal(T animal)
        {
            animal.Move();
        }

        public T GetNewAnimal()
        {
            T t = new T();
            return t;
        }
    }

    // VARIANCE

    public interface IStudent<in T>
    {
    }

    public class Student<T> : IStudent<T>
    {
    }

    public class Proga
    {
        public static void Main(string[] args)
        {
            // In C# default behavior - type of generics must be the same, INVARIANT BEHAVIOR
            // so here is mistake
            // IStudent<Animal> student1 = new Student<Cat>();

            // if we set IStudent<T> as IStudent<out T> we allow compilator casting child generic type to parent
            // COVARIANT BEHAVIOR puts some restriction on methods which are inside covariant interface
            // we may do just like this - T Move(int distance) and can not  - void Set(T distance)
            //IStudent<Animal> student1 = new Student<Cat>();

            // if we set IStudent<T> as IStudent<in T> we allow compilator casting parent generic type to child generic type
            // CONTRVARIANT BEHAVIOR puts some restriction on methods which are inside contrvariant interface
            // we may do just like this - void Set(T distance) and can not  - T Move(int distance)
            IStudent<Cat> student1 = new Student<Animal>();

            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.position);
            Console.WriteLine(stack.Pop());

        }

    }

    class Stack<T>
    {
        public int position;
        private T[] data = new T[100];
        public void Push(T obj) => data[position++] = obj;
        public T Pop() => data[--position];
    }
}
