using System;


namespace _12_NullValuesArithmetic
{
    class NullValuesArithmetics
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("{0} {1}", a, b);
            a += 5;
            b += null;
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
