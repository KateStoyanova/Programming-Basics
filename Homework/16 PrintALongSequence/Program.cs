

using System;

namespace _16.PrintALongSequence
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("2");
            string a = Console.ReadLine();
            int b = Int32.Parse(a);
            Console.WriteLine("-1001");
            string c = Console.ReadLine();
            int d = Int32.Parse(c);

            for (int i = b; i < d; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i * (-1) + ", ");
                }

            }
        }
    }
}