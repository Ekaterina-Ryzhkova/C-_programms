using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {   
            int column = 3; //столбцы n
            int row = 2; //строки m
            int[,] mas = new int[column, row];
            Random rn = new Random();
            for (int i = 0; i < column; i++) 
            	for (int j = 0; j < row; j++)
            		mas[i, j] = rn.Next(100); //заполнили массив двигаемся дальше
                    for (int i = 0; i < column; i++)
                    {
                        for (int j = 0; j < row; j++)
                            Console.Write(String.Format("{0,3}", mas[i, j]));
                        Console.WriteLine();
                    }       
            int sum = 0;
            int scr= 0; 
            string[] cum = new string [100]; //100 сумм
            for (int i = 0; i < column; i++)
            {
            	for (int j = 0; j < row; j++)
                {
                    sum+=mas[i,j];
                    Console.WriteLine("i {0} j {1} sum {2}", i,j,sum); //проблема начинается
                    if(row-j==1)

                    {   Console.WriteLine("fffffffffffffff {0} - ", sum);
                        cum[scr] = sum.ToString();//счетчик скр епта
                        scr++;
                        sum = 0; //мне нужно записать значения из sum в массив и обнулить sum
                    }
                } //проблема кончается
            }
               
            for (scr = 0; scr < 3; scr++) 
            Console.Write("{0} ", cum[scr]);
        }
    }
}
