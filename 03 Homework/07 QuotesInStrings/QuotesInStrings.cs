using System;


namespace _07_QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string one = "The \"use\" of quotations is very difficult";
            string two = @"The ""use"" of quotations is very difficult";
            Console.WriteLine("{0}\n{1}\n", one, two);
        }
    }
}
