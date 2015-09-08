using System;

namespace _06_StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string first = "Hello";
            string second = "World";
            object greetings = first + " " + second;
            string greeting = (string)greetings;
            Console.WriteLine(greeting);
        }
    }
}
