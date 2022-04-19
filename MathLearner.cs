/// <summary>
/// Формулы были выведены самостоятельно
/// </summary>

// 1 Задача на совместную работу
// Через первую трубу бассейн наполняется за a ч через вторую трубу за b часов. За сколько часов бассейн наполнится через обе эти трубы?

    class Program
        {
            public static void Main()
            {
                Console.Write("Введите a: ");
                int a = int.Parse(Console.ReadLine()); 
                Console.Write("Введите b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Бассейн наполнится через обе трубы за " + Calculate(a, b) +" часов");
            }

            public static double Calculate (int a, int b)
            {
                return (a * b) / (a + b);
            }
        }
// 2 Задача на совместную работу
// Через обе трубы бассейн наполняется за x ч через одну из труб за b часов. За сколько часов бассейн наполнится через другую трубу?

    class Program
    {
        public static void Main()
        {
            Console.Write("Введите время за которое наполянется бассейн через обе трубы: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите время за которое наполянется бассейн через одну трубу: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Бассейн наполнится через другую трубу за " + Calculate(x, b) +" часов");
        }

        public static double Calculate (int x, int b)
        {
            return (x * b) / (b - x);
        }
    }

// 3 Задача на совместную работу
// Две трубы наполняя бассейн отдельно делают это за x ч. Первая труба начала наполнять бассейн. Спустя c часов к ней присоединилась другая труба. 
// Сколько часов наполнялся бассейн?

    class Program
    {
        public static void Main()
        {
            Console.Write("Введите время за которое наполянется бассейн через каждую из труб: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите время через которое к первой трубе присоединилась другая труба: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Бассейн наполнялся " + Calculate(x, c) +" часов");
        }

        public static double Calculate (int x, int c)
        {
            return ((x-c)/2) + c;
        }
    }
