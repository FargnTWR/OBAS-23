namespace ConsoleApp2
{
    /*
     * Выполнили работу (задание 1)
     * 
     * Василенко Никита
     * Соловьев Павел
     * Воробьев Даниил
    */
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
                // TODO menu

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

            string job = Console.ReadLine();

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
    }
}
