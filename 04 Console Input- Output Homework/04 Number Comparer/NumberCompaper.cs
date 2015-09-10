using System;

namespace _04_Number_Comparer
{
    class NumberCompaper
    {
        static void Main()
        {
            char a = 'a';
            char b = 'b';
            string greater = "greater";
            Console.WriteLine("{0, 5}|{1, 5}|{2, 10}", a, b, greater);
            int var1 = 5;
            int var2 = 6;
            Console.WriteLine("{0, 5}|{1, 5}|{2, 10}", var1, var2, (Math.Max(var1, var2)));
            int var3 = 10;
            int var4 = 5;
            Console.WriteLine("{0, 5}|{1, 5}|{2, 10}", var3, var4, (Math.Max(var3, var4)));
            int var5 = 0;
            int var6 = 0;
            Console.WriteLine("{0, 5}|{1, 5}|{2, 10}", var5, var6, (Math.Max(var5, var6)));
            int var7 = -5;
            int var8 = -2;
            Console.WriteLine("{0, 5}|{1, 5}|{2, 10}", var7, var8, (Math.Max(var7, var8)));
            float var9 = 1.5f;
            float var10 = 1.6f;
            Console.WriteLine("{0, 5}|{1, 5}|{2, 10}", var9, var10, (Math.Max(var10, var9)));
        }
    }
}
