using System;


namespace _03_Circle_Perimeter_and_Area
{
    class 	CirclePerimeterAndArea
    {
        static void Main()
        {
            char r = 'r';
            string perimeter = "perimeter";
            string area = "area";
            Console.WriteLine("{0,-5}|{1, 10}|{2, 5}", r, perimeter, area);
            Console.WriteLine("______________________");
            byte r1 = 2;
            Console.WriteLine("{0}{1, 5}{2:F2}{3, 6}{4:F2}", r1, "|", r1 * 2 * 3.141592, "|", 3.141592 * r1 * r1);
            float r2 = 3.5f;
            Console.WriteLine("{0}{1, 3}{2:F2}{3, 6}{4:F2}", r2, "|", r2 * 2 * 3.141592, "|", 3.141592 * r2 * r2);
        }
    }
}
