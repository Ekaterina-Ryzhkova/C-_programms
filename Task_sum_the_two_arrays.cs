using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {   
            int column = 3; //столбцы 
            int row = 2; //строки 
            int[,] mas = new int[column, row];
            Random rn = new Random();
            for (int i = 0; i < column; i++) 
            	for (int j = 0; j < row; j++)
            		mas[i, j] = rn.Next(100); 
                    for (int i = 0; i < column; i++)
                    {
                        for (int j = 0; j < row; j++)
                            Console.Write(String.Format("{0,3}", mas[i, j]));
                        Console.WriteLine();
                    }       
            int sum = 0;
            string[] cum = new string [100]; 
            for (int i = 0; i < column; i++)
            {
            	for (int j = 0; j < row; j++)
                {
                    sum+=mas[i,j];
                    if(row-j==1)

                    {   Console.Write($"{sum} ");
                        sum = 0;
                    }
                } 
            }
        }
    }
}
