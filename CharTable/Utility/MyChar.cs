using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharTable.Utility
{
    public static class MyChar
    {
        private static readonly List<ConsoleColor> colors = new List<ConsoleColor> // список цветов консоли
            {
                ConsoleColor.DarkBlue,
                ConsoleColor.DarkGreen,
                ConsoleColor.DarkCyan,
                ConsoleColor.DarkRed,
                ConsoleColor.DarkMagenta,
                ConsoleColor.DarkYellow,
                ConsoleColor.Gray,
                ConsoleColor.DarkGray,
                ConsoleColor.Blue,
                ConsoleColor.Green,
                ConsoleColor.Cyan,
                ConsoleColor.Red,
                ConsoleColor.Magenta,
                ConsoleColor.Yellow,
                ConsoleColor.White
            };

        /// <summary>
        /// Выводит на экран таблицу символов с заданным количеством столбцов по заданному диапазону кодов.
        /// </summary>
        /// <param name="startCharCode">Код первого символа.</param>
        /// <param name="endCharCode">Код последнего символа.</param>
        /// <param name="columnNumber">Количество столбцов. По умолчанию - 4.</param>
        public static void ConsoleWriteChars(int startCharCode, int endCharCode, int columnNumber = 4)
        {
            short columnCounter = 0; // счётчик столбцов

            Console.OutputEncoding = Encoding.Unicode; // кодировка символов

            try
            {
                for (int i = startCharCode; i <= endCharCode; i++)
                {
                    var str = (char)i + "\t";

                    if (++columnCounter == columnNumber)
                    {
                        columnCounter = 0; // обнуление счётчика
                        str += "\n";
                    }
                    
                    ChangeColor(); // изменение цвета символов
                    Console.Write(str); // вывод символа на экран
                    Console.ResetColor(); // сброс цвета символов до значения по умолчанию
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{DateTime.Now}]\tВ методе [ ConsoleWriteChars ]\t" + ex.Message);
            }
        }

        /// <summary>
        /// Выводит на экран таблицу символов с заданным количеством столбцов по заданному диапазону кодов.
        /// </summary>
        /// <param name="firstCharCode">Код первого символа.</param>
        /// <param name="lastCharCode">Код последнего символа.</param>
        /// <param name="columnNumber">Количество столбцов. По умолчанию - 4.</param>
        public static void ConsoleWriteCharsLinq(int firstCharCode, int lastCharCode, int columnNumber = 4)
        {
            var listChars = Enumerable.Range(firstCharCode, lastCharCode + 1).ToList(); // формирование списка кодов в заданном диапазоне

            short columnCounter = 0; // счётчик столбцов

            Console.OutputEncoding = Encoding.Unicode; // кодировка символов 

            try
            {
                foreach (var item in listChars)
                {
                    var str = (char)item + "\t";

                    if (++columnCounter == columnNumber)
                    {
                        columnCounter = 0; // обнуление счётчика
                        str += "\n";
                    }

                    ChangeColor();
                    Console.Write(str); // вывод символа на экран
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{DateTime.Now}]\tВ методе [ ConsoleWriteCharsLinq ]\t" + ex.Message);
            }
        }

        /// <summary>
        /// Изменяет цвет текста, отображаемого в консоли.
        /// </summary>
        private static void ChangeColor() 
        {
            Random random = new Random();

            int startIndex = 0;
            int lastIndex = colors.Count;

            try
            {
                int randomValue = random.Next(startIndex, lastIndex);
                ConsoleColor randomColor = colors[randomValue];

                Console.ForegroundColor = randomColor;   // изменение цвета текста на случайный
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{DateTime.Now}]\tВ методе [ ChangeColor ]\t" + ex.Message);
            }
        }
    }
}
