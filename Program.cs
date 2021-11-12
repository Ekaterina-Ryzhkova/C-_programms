using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter the number of three pairs");
            int rows = int.Parse(Console.ReadLine()); //строки
            int columns = 3; //столбцы
            int[,] mas = new int[rows, columns];
            string[] str_arr;

            int k = 0; //7 3 5 15 20 40 300 550 137

            str_arr = (Console.ReadLine()).Split(' ');

            for (int i = 0; i < rows; ++i)
                {
                    for (int j =0; j<columns ;j++) {
                    Console.WriteLine("{0} {1} {2}",i,j,str_arr[k]);
                    mas[i, j] = Convert.ToInt32(str_arr[k]);
                    k++;
                    }
                }

            Console.WriteLine("Полученная матрица:");
            for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    Console.Write(String.Format("{0,5}", mas[i, j]));
                    Console.WriteLine();
                }

            int minValue = 0; 
            Console.WriteLine("min " + minValue);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {   
                    if (j==2)
                    {
                        minValue = mas[i,j];
                        if ((minValue > mas[i,j-1]) && (minValue > mas[i,j-2]))
                        {
                            minValue = mas[i,j-1];
                            if (minValue > mas[i,j-2])
                            {
                                minValue = mas[i,j-2];
                                Console.Write($"{minValue} ");
                            }
                            else
                            {
                                minValue = mas[i,j-1];
                                Console.Write($"{minValue} ");
                            }
                        }else
                        {
                            minValue = mas[i,j];
                            Console.Write($"{minValue} ");
                        }

                        minValue = 0;
                    }
                    
                } 
            }
            
        } 
    }
} 

            
        
