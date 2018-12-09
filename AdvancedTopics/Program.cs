using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    class Program
    {
        static void Main1(string[] args)
        {
            BookList bl = new BookList();
            string s1 = bl[1];
        }
    }

    class BookList
    {
        public void Add(String str)
        {
        }

        public string this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    class MyNullable<T> where T : struct
    {
        private object _value;

        public MyNullable()
        {
        }

        public MyNullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public bool HasValueD(object t)
        {
            return _value == t;
        }

        public T GetValueOrDefault()
        {
            if (HasValue) return (T) _value;

            return default(T);
        }
    }
}