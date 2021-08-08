using System;
using CharTable.Utility;

namespace CharTable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyChar.ConsoleWriteChars(-10, 1000);
            Console.WriteLine("\n==============\n");

            MyChar.ConsoleWriteCharsLinq(-100, 1000, 7);
            Console.ReadLine();
        }
    }
}
