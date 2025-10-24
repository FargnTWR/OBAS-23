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
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите число: ");
                string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Введите число!");
                    return;
                }
                if (int.TryParse(input, out int parsed))
                {
                    numbers.Add(parsed);
                } else
                {
                    Console.WriteLine("Введите число нормально!");
                    return;
                }
            }

            if (numbers == null || numbers.Count < 3)
            {
                Console.WriteLine("Вы не ввели достаточно чисел или произошла ошибка!");
            }

            Console.WriteLine("Считаем...");
            var num1 = Math.Pow(numbers[0], 3);
            var num2 = Math.Pow(numbers[1], 3);
            var num3 = Math.Pow(numbers[2], 3);
            var result = num1 + num2 + num3;
            Console.WriteLine("Результат: " + result);
        }
    }
}
