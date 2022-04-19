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

// 3 Задача на совместную работу
// Двое рабочих работая совместно выполняют работу за c дней. За сколько дней работая отдельно выполнит эту работу первый рабочий если он за a дня выполняет
// такую же работу какую второй за b дня?
// Программа составлена с учетом выбора рабочего, чтобы решение было универсальным для любого подобного типа задач.

class Program
    {
        public static void Main()
        {
            Console.Write("Введите время за которое была выполнена работа двумя рабочими: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите какую часть работы выполняет первый рабочий какую выполняет второй рабочий: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите какую часть работы выполняет второй рабочий какую выполняет первый рабочий: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Время выполнения какого рабочего необходимо найти (1 - Первого, 2 - Второго): ");
            string k = Console.ReadLine();

            if (k == "1")
            {
                Console.WriteLine("Первый рабочий выполнит работу за " + Calculate1(c, a, b) +" дня");
            }

            else if (k == "2")
            {
                Console.WriteLine("Второй рабочий выполнит работу за " + Calculate2(c, a, b) + " дня");
            }

            else 
            {
                Console.WriteLine("Введите корректное значение!");
            }
            
        }

        public static double Calculate1 (int c, int a, int b)
        {
            return (c*(a+b)/b);
        }

        public static double Calculate2(int c, int a, int b)
        {
            return (c * (a + b) / a);
        }
    }
