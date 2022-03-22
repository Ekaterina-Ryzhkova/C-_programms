using System;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку содержащую N слов:");
            string str = Console.ReadLine();

            char[] separator = { ',', ' ' };
            String[] strlist = str.Split(separator);

            if (strlist.Length == N)
            {
                //Вывод:
                //сон
                // да - с
                // да - о
                // да - н
                // нор
                // да - н
                // да - о
                // нет - р
                // рос
                // нет - р
                // да - о
                // да - с
                int sum = 0;

                for (int i = 0; i < strlist.Length; i++)
                {
                    Console.WriteLine(strlist[i]);

                    foreach (var item in strlist[i])
                    {
                        foreach (var c in strlist[0])
                        {
                            {
                                if (c == item)
                                {
                                    System.Console.WriteLine("да - {0}", c);
                                }

                                if (!strlist[0].Contains(item))
                                {
                                    sum++;

                                    if (sum == strlist[0].Length)
                                    {
                                        System.Console.WriteLine("нет - {0}", item);
                                        sum = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            else
            {
                Console.WriteLine("Количество слов не соответствует N");
                Console.WriteLine("Повторите попытку");
            }
        }
    }
}
