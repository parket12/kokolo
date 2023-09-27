namespace MyGames;

class Program
{
    static void Main()
    {
        bool nach = true;

        while (nach)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выход");

            int vibor = Convert.ToInt32(Console.ReadLine());

            switch (vibor)
            {
                case 1:
                    ugadaika();
                    break;
                case 2:
                    tablica();
                    break;
                case 3:
                    deliteli();
                    break;
                case 0:
                    nach = false;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    break;
            }
        }
    }

    static void ugadaika()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);

        int popitka;
        int tries = 0;

        do
        {
            Console.Write("Введите число: ");
            popitka = Convert.ToInt32(Console.ReadLine());

            tries++;

            if (popitka < randomNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (popitka > randomNumber)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
        } while (popitka != randomNumber);

        Console.WriteLine($"Поздравляем! Вы угадали число за {tries} попыток.");
    }

    static void tablica()
    {
        int[,] table = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                table[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("Таблица умножения:");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{table[i, j],4}");
            }

            Console.WriteLine();
        }
    }

    static void deliteli()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Делители числа {number}: ");

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();
    }
}