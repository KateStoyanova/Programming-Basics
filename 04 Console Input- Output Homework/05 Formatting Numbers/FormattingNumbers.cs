using System;

namespace _05_Formatting_Numbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            char a = 'A';
            char b = 'B';
            char c = 'C';
            string result = "RESULT";
            Console.WriteLine("{0, -10}|{1, -10}|{2, -10}|{3, -42}|", a, b, c, result);
            int d = 254;
            float e = 11.6f;
            float f = 0.5f;
            string hex = d.ToString("X");
            string binary = Convert.ToString(d, 2);
            Console.WriteLine("{0, -10}|{1, -10}|{2, -10}|{3, -10}|{4}|{5, 10}|{6:0.000    }|", d, e, f, hex, binary.PadLeft(10, '0'), e, f);
            int d1 = 499;
            float e1 = -0.5559f;
            short f1 = 10000;
            string hex1 = d1.ToString("X");
            string binary1 = Convert.ToString(d1, 2);
            Console.WriteLine("{0, -10}|{1, -10}|{2, -10}|{3, -10}|{4}|{5, 10}|{6:0.000}|", d1, e1, f1, hex1, binary1.PadLeft(10, '0'), Math.Round(e1, 2), f1);
            byte d2 = 0;
            byte e2 = 3;
            float f2 = -0.1234f;
            string hex2 = d2.ToString("X");
            string binary2 = Convert.ToString(d2, 2);
            Console.WriteLine("{0, -10}|{1, -10}|{2, -10}|{3, -10}|{4}|{5, 10}|{6:0.000   }|", d2, e2, f2, hex2, binary2.PadLeft(10, '0'), e2, Math.Round(f2, 3));
        }
    }
}
