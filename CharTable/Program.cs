using System;
using CharTable.Utility;

namespace CharTable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyChar.ConsoleWriteChars(0, 1000);
            Console.WriteLine();

            MyChar.ConsoleWriteCharsLinq(0, 1000, 7);
            Console.ReadLine();
        }
    }
}
