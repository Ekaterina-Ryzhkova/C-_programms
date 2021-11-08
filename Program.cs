using System;

namespace visual_studio_code_bin
{
    class Program
    {
        static bool x;
        public static void Main(string[] args)
        {
           
 Console.WriteLine(IsLeapYear(2014));
 Console.WriteLine(IsLeapYear(1999));
 Console.WriteLine(IsLeapYear(8992));
 Console.WriteLine(IsLeapYear(1));
 Console.WriteLine(IsLeapYear(14));
 Console.WriteLine(IsLeapYear(400));
 Console.WriteLine(IsLeapYear(600));
 Console.WriteLine(IsLeapYear(3200));
 FinalTesting(IsLeapYear(Convert.ToInt32(x))); // Idk

}

public static bool IsLeapYear(int year)

{
    x = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    return x;

}

public static void FinalTesting(bool IsLeapYear)

{

    for (int i = Convert.ToInt32(IsLeapYear); i < 7; i++) { 
        
if (i == 0) {
        Console.WriteLine("Год {0} високосный", i);
    } else Console.WriteLine("Год {0} невисокосный", i);
}
}
    
        
    }
}

