using System;


namespace _01SumOfThreeNumbers
{
    class SumOfThreeNumbers

    {
        static void Main()
        {
            char a = 'A';
            char b = 'B';
            char c = 'C';
            string sum = "SUM";
            Console.WriteLine("{0, 5}|{1, 5}|{2, 5}|{3, 5}|", a, b, c, sum);
            Console.WriteLine("________________________");
            byte d = 3;
            byte e = 4;
            byte f = 11;
            Console.WriteLine("{0, 5}|{1, 5}|{2, 5}|{3, 5}|", d, e, f, d + e + f);
            sbyte g = -2;
            byte h = 0;
            byte i = 3;
            Console.WriteLine("{0, 5}|{1, 5}|{2, 5}|{3, 5}|", g, h, i, g + h + i);
            float j = 5.5f;
            float k = 4.5f;
            float l = 20.1f;
            Console.WriteLine("{0, 5}|{1, 5}|{2, 5}|{3, 5}|", j, k, l, j + k + l);
        }
    }
}
