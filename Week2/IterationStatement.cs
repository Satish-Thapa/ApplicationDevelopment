using System;

namespace IterationStatement

{
    public class IterationStatement
    {

        /*
		 * iteration statement
			for 
			for each

			do while
			while
		 */

        //Whbile Statement
        public static void WhileStatement(int a)
        {
            while (a < 10)
            {
                Console.WriteLine(a);
                a++;
            }
        }

        public static void DoWhileStatement(int a)
        {
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 10);
        }

        public static void ForLoop(int a)
        {


            for (int i = a; i < 5; i++)
            {
                Console.WriteLine(i);
            }

        }

        public static void ForEachLoop()
        {
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibNumbers)
            {
                Console.Write($"{element} \n");
            }
        }


    }
}
