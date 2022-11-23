using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static void Additions(int a, int b)
        {
            Console.WriteLine($"Your result: {a} + {b} = " + (a + b));
        }

        public static void Subtraction(int a, int b)
        {
            Console.WriteLine($"Your result: {a} - {b} = " + (a - b));
        }

        public static void Multiplication(int a, int b)
        {
            Console.WriteLine($"Your result: {a} * {b} = " + (a * b));
        }

        public static void Division(int a, int b)
        {
            Console.WriteLine($"Your result: {a} / {b} = " + (a / b));
        }
    }
}
