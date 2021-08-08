using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharTable.Utility
{
    public static class MyChar
    {      
        /// <summary>
        /// Выводит на экран таблицу символов с заданным количеством столбцов по заданному диапазону кодов.
        /// </summary>
        /// <param name="startCharCode">Код первого символа.</param>
        /// <param name="endCharCode">Код последнего символа.</param>
        /// <param name="columnNumber">Количество столбцов. По умолчанию - 4.</param>
        public static void ConsoleWriteChars(int startCharCode, int endCharCode, int columnNumber = 4)
        {
            short counter = 0; // счётчик столбцов

            try
            {
                for (int i = startCharCode; i <= endCharCode; i++)
                {
                    var str = (char)i + "\t";

                    if (++counter == columnNumber)
                    {
                        counter = 0; // обнуление счётчика
                        str += "\n";
                    }

                    Console.OutputEncoding = Encoding.Unicode; // кодировка символов
                                      
                    ChangeColor(); // изменение цвета символов
                    Console.Write(str); // вывод символа на экран
                    Console.ResetColor(); // сброс цвета символов до значения по умолчанию
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            var chars = new List<int>(lastCharCode);
            
            for (int i = 0; i <= lastCharCode; i++)
            {
                chars.Add(i); // создание списка кодов символов
            }            

            var listChars = chars.Where(x => firstCharCode < x); // выбор символов в заданном диапазоне кодов

            short counter = 0; // счётчик столбцов

            try
            {
                foreach (var item in listChars)
                {
                    var str = (char)item + "\t";

                    if (++counter == columnNumber)
                    {
                        counter = 0; // обнуление счётчика
                        str += "\n";
                    }

                    Console.OutputEncoding = Encoding.Unicode; // кодировка символов

                    ChangeColor();
                    Console.Write(str); // вывод символа на экран
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Изменяет цвет текста, отображаемого в консоли.
        /// </summary>
        private static void ChangeColor() 
        {
            Array colors = Enum.GetValues(typeof(ConsoleColor));   // формирование массива цветов консоли         
            Random random = new Random();
            ConsoleColor randomColor = (ConsoleColor)colors.GetValue(random.Next(colors.Length));

            if (randomColor == ConsoleColor.Black) 
            {
                //Console.BackgroundColor = ConsoleColor.White; 
                randomColor = ConsoleColor.White;
            }

            Console.ForegroundColor = randomColor;   // изменение цвета текста на случайный         
        }
    }
}
