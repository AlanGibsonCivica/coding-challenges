using System;

namespace dotnet
{
    class Program
    {
        static String[] TESTS = 
        {
            "HELLO WORLD",
            "SOMETHING ELSE",
            "ABCDEFG"
        };

        static void Main(string[] args)
        {
            foreach (var test in TESTS) 
            {
                var result = FindRepeatCharacter(test);
                Console.WriteLine("{0} : {1}", test, result);
            }
        }

        static char? FindRepeatCharacter(String input) {
            return null;
        }
    }
}
