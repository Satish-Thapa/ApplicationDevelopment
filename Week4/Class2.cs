using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDev.AbsClass;
namespace AppDev.InheratingClass
{
    public class Class2 : Class1
    {
        public override void Area(int length) {
            //if parameter isn't taken
            //Console.WriteLine("Enter the length of the square");
            //int user_input = Convert.ToInt32(Console.ReadLine());
            //length = user_input;

            int area = length * length;
            //or use Math.Pow(lenght, 2); by using Math.
            Console.WriteLine($"THe area of square with length {length} is {area}");
        }
    }
}
