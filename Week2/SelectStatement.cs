using System;

//select statement
/*
if else
switch case
 */
namespace SelectStatement
{
    public class SelectStatement
    {

        public static void IfElse(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");

            }
            else if (b > a)
            {
                Console.WriteLine($"{b} is greater than {a}");
            }
            else
            {
                Console.WriteLine("a and b are equal");

            }
        }


        public static void SwitchCase()
        {

            Console.WriteLine("Press 1 for football");
            Console.WriteLine("Press 2 for basketball");
            Console.WriteLine("Enter your Choice");


            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("football");
                    break;
                case "2":
                    Console.WriteLine("basketball");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }


    }
}

