using System;
using System.Collections.Generic;

/*
В приведенной ниже программе целое число
выводится словами. Например, число 1908 
выводится словами "один девять ноль восемь".
*/

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1908;

            string num1 = num.ToString();

            List<string> str = new List<string>();

            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] == '0')
                {
                    str.Add("ноль");
                }

                if (num1[i] == '1')
                {
                    str.Add("один");
                }

                if (num1[i] == '2')
                {
                    str.Add("два");
                }

                if (num1[i] == '3')
                {
                    str.Add("три");
                }

                if (num1[i] == '4')
                {
                    str.Add("четыре");
                }

                if (num1[i] == '5')
                {
                    str.Add("пять");
                }

                if (num1[i] == '6')
                {
                    str.Add("шесть");
                }

                if (num1[i] == '7')
                {
                    str.Add("семь");
                }

                if (num1[i] == '8')
                {
                    str.Add("восемь");
                }

                if (num1[i] == '9')
                {
                    str.Add("девять");
                }
            }

            foreach (var str1 in str)
                {
                Console.Write($"{str1} ");
                }
        }
    }
}
