using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev.AbsClass
{
    public abstract class Class1
    {
        public abstract void Area(int l);

        private void MyName(string name)
        {
            Console.WriteLine($"HEllo my name is {name}");
        }
        protected void MyAge(int age)
        {
            Console.WriteLine($"My age is {age}");
        }
        internal void MyCountry(string country)
        {
            Console.WriteLine($"I live in {country}");
        }
    }

}   
