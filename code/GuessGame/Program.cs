using System;
class Task3_GuessGame
{
    static void Main()
    {
        Console.WriteLine("Компьютер загадал число от 1 до 100!");
        Console.WriteLine();
        
        bool playAgain = true;
        Random random = new Random();
        
        while (playAgain)
        {
            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            bool guessed = false;
            Console.WriteLine("Новая игра! Попробуйте угадать число.");
            Console.WriteLine();
            while (!guessed)
            {
                Console.Write("Введите ваше предположение: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Ошибка! Введите целое число.");
                    continue;
                }
                attempts++;
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Число должно быть от 1 до 100!");
                    continue;
                }
                if (guess == secretNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine($"ПОЗДРАВЛЯЮ! Вы угадали число {secretNumber}!");
                    Console.WriteLine($"Количество попыток: {attempts}");
                    if (attempts <= 5)
                        Console.WriteLine("Отличный результат!");
                    else if (attempts <= 10)
                        Console.WriteLine("Хороший результат!");
                    else
                        Console.WriteLine("Попрактикуйтесь ещё!");
                    
                    guessed = true;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Загаданное число БОЛЬШЕ!");
                }
                else
                {
                    Console.WriteLine("Загаданное число МЕНЬШЕ!");
                }
            }
            Console.WriteLine();
            Console.Write("Хотите сыграть ещё? (да/нет): ");
            string answer = Console.ReadLine().ToLower();
            
            if (answer != "да" && answer != "yes" && answer != "д")
            {
                playAgain = false;
                Console.WriteLine();
                Console.WriteLine("Спасибо за игру! До свидания!");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}