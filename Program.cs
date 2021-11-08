using System;

namespace visual_studio_code_bin
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] years = { 2014, 1999, 8992, 1, 14, 400, 600, 3200 };

            foreach (int n in years)
            {
                if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
                {
                    Console.WriteLine("Год {0} високосный", n);
                }
                else Console.WriteLine("Год {0} НЕвисокосный", n);
            }
        }
    } //Форматирование CTRL+SHIFT+I
}

