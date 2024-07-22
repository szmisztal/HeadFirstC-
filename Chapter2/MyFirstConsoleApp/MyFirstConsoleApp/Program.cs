using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bobbo Junior";

            if ((someValue == 3) && (name == "Jasiek"))
            {
                Console.WriteLine("x is 3 and name is Jasiek");
            }

            Console.WriteLine("This line is always printing");
        }

        private static void TryAnIfElse()
        {
            int x = 5;

            if (x == 10)
            {
                Console.WriteLine("x has to be equal 10");
            }
            else
            {
                Console.WriteLine("x is not equal 10");
            }
        }

        private static void TrySomeLoops()
        {
            int count = 0;

            while (count < 10)
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }

            Console.WriteLine("Result is " + count);

        }
    }
}
