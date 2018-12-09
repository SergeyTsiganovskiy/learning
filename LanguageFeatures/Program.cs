using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    class Program
    {
        private int sideA;
        private int sideB;
        private string name;

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("");
                }

                name = value;
            }

            get { return string.IsNullOrEmpty(name) ? "No name" : name; }
        }

        public int SideA
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("");
                }

                this.sideA = value;  
            }

            get
            {
                return this.sideA;
            }
        }

        public int SideB { get => sideB; set => sideB = value; }

        static void Main1(string[] args)
        {
        }
    }

    class Car {
        public Car(int size)
        {
            
        }

        public Car() : this(2) 
        {
            
        }
    }
}
