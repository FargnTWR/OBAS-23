namespace ConsoleApp2
{
    internal class Program
    {

        static int coins = 50;
        static int bulochkas = 0;

        static readonly Dictionary<string, int> jobs = new Dictionary<string, int>
        {
            {"1", 10 },
            {"2", 20},
        };

        static readonly Dictionary<string, int> shop = new Dictionary<string, int>
        {
            {"1", 15 },
            {"2", 40},
        };

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===============");
                Console.WriteLine("Баланс: " + coins);
                Console.WriteLine("Булочки: " + bulochkas);
                Console.WriteLine("===============");
                Console.WriteLine("1.Работа");
                Console.WriteLine("2.Магазин");
                Console.WriteLine("3.Выход");
                Console.WriteLine("===============");
                Console.Write("Выбор: ");

                string choice = Console.ReadLine();
                if (choice == "1") Work();
                else if (choice == "2") Buy();
                else if (choice == "3") break;
            }
        }

        static void Work()
        {
            Console.Clear();
            Console.WriteLine("===============");
            Console.WriteLine("Выберите работу: ");
            Console.WriteLine("===============");
            Console.WriteLine("1.Простая работа - 10 монет");
            Console.WriteLine("2.Адская работа - 20 монет");
            Console.WriteLine("===============");
            Console.Write("Выбор: ");

            string? job = Console.ReadLine();

            if (job == null) 
            {
                Console.WriteLine("Введите работу");
                Console.ReadKey();
                return;
            }

            if (jobs.ContainsKey(job))
            {
                coins += jobs[job];
                Console.WriteLine("Вы заработали " + jobs[job] + "монет");
            }
            else
            {
                Console.WriteLine("Работы не существует!");
            }

            Console.ReadKey();
        }

        static void Buy()
        {
            Console.Clear();
            Console.WriteLine("===============");
            Console.WriteLine("Монеты: " + coins);
            Console.WriteLine("===============");
            Console.WriteLine("1. Булочка - 15 монет");
            Console.WriteLine("2. Двойная булочка - 40 монет");
            Console.WriteLine("===============");
            Console.Write("Выбор: ");

            string item = Console.ReadLine();

            if (shop.ContainsKey(item))
            {
                if (coins >= shop[item])
                {
                    coins -= shop[item];
                    bulochkas++;
                    if (item == "2") bulochkas++;
                    Console.WriteLine("Куплено");
                }
                else
                {
                    Console.WriteLine("Не хватает монет");
                }
            }
            else
            {
                Console.WriteLine("Нет такого товара");
            }

            Console.ReadKey();
        }
    }
}
