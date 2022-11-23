using System;

namespace ClassworkW3
{
    public class ClassworkW3
    {
        public static void Prime()
        {
            Console.WriteLine("Enter a number to find if it's a prime number");
            int a = Convert.ToInt32(Console.ReadLine());
            int used = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    used++;
                }
            }
            if (used > 2)
            {
                Console.WriteLine($"{a} is not a prime number");
            }
            else
            {
                Console.WriteLine($"{a} is a prime number.");
            }
        }

        //Odd or Even
        public static void OddOrEven()
        {
            Console.WriteLine("Enter a number to check if it's odd or even");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is an even number");
            }
            else
            {
                Console.WriteLine($"{a} is an odd number");

            }
        }

        //swapping values
        public static void SwappingValues()
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            int c;

            Console.WriteLine($"You chose a as {a} and b as {b}");
            c = b;
            b = a;
            a = c;

            Console.WriteLine($"a = {a} and b = {b} are now changed");
        }

        public static void SwapArrayValues()
        {
            //just an idea, might not work
            string[] balls = { "fooaball", "basketball" };

            var a = (balls[0]);
            var b = (balls[1]);
            var tempValue = "random";

            Console.WriteLine(balls);

            tempValue = b;
            b = a;
            a = tempValue;

            Console.WriteLine($"Changed{balls}");



        }

        public static void SearchArray()
        {
            string[] peoples = { "Ajit", "Satish", "Chirag", "Rojesh" };
            Console.WriteLine("Enter a name to search");
            var searchedName = Console.ReadLine();
            bool valueFound = false;

            foreach (string name in peoples)
            {
                if (name.ToLower() == searchedName.ToLower())
                {
                    valueFound = true;
                    break;
                }
            }
            if (valueFound)
            {
                Console.WriteLine($"Yes, {searchedName} is in our array.");
            }
            else
            {
                Console.WriteLine($"No, {searchedName} is not in our array.");
            }
        }
    }
}

