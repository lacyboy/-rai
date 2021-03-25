using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            do
            {
                Console.WriteLine("Adj meg egy számot!");
                a = Convert.ToInt32(Console.ReadLine());

                if (a % 2 == 0) Console.WriteLine("A szám osztható 2-vel");
                if (a % 3 == 0) Console.WriteLine("A szám osztható 3-mal");
                if (a % 5 == 0) Console.WriteLine("A szám oszható 5-tel");

                Console.ReadKey();


            } while (a != 0);

        }
    }
}
