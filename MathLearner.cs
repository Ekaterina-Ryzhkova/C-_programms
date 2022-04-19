// Задача на совместную работу
// Через первую трубу бассейн наполняется за a ч через вторую трубу за b часов. За сколько часов бассейн наполнится через обе эти трубы?

class Program
    {
        public static void Main()
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Бассейн который заполняется через обе трубы наполнится за " + Calculate(a, b) +" часов");
        }

        public static double Calculate (int a, int b)
        {
            return (a * b) / (a + b);
        }
    }
