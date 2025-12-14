using System;

namespace Program
{
    //Перша задача
    public class Program1
    {
        //Перша задача (for)
        public static void Func1_for(int a, int b, int n)
        {
            int number = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % a == 0 && i % b != 0)
                    number++;
            }

            Console.WriteLine($"Відповідь: {number}");
        }
        //Перша задача (while)
        public static void Func1_while(int a, int b, int n)
        {
            int number = 0;

            int currentNumber = 1;

            while (currentNumber <= n)
            {
                if (currentNumber % a == 0 && currentNumber % b != 0)
                    number++;

                currentNumber++;
            }

            Console.WriteLine($"Відповідь: {number}");
        }
        //Перша задача (do-while)
        public static void Func1_doWhile(int a, int b, int n)
        {
            int number = 0;

            int currentNumber = 1;

            do
            {
                if (currentNumber % a == 0 && currentNumber % b != 0)
                    number++;

                currentNumber++;
            } while (currentNumber <= n);

            Console.WriteLine($"Відповідь: {number}");
        }
    }
    //Друга задача
    public class Program2
    {
        //Друга задача (for)
        public static void Func2_for()
        {
            int number = int.Parse(Console.ReadLine());

            int min = number;
            int max = number;

            //Цикл MinMax
            for (int i = 0; number != 0; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (number != 0 && number < min)
                    min = number;

                if (number != 0 && number > max)
                    max = number;
            }

            int sumMinMax = min + max;

            Console.WriteLine($"Сума мінімального та максимального чисел: {sumMinMax}");
        }
        //Друга задача (while)
        public static void Func2_while()
        {
            int number = int.Parse(Console.ReadLine());

            int min = number;
            int max = number;

            //Цикл MinMax
            while (number != 0)
            {
                number = int.Parse(Console.ReadLine());

                if (number != 0 && number < min)
                    min = number;

                if (number != 0 && number > max)
                    max = number;
            }

            int sumMinMax = min + max;

            Console.WriteLine($"Сума мінімального та максимального чисел: {sumMinMax}");
        }
        //Друга задача (do-while)
        public static void Func2_doWhile()
        {
            int number = int.Parse(Console.ReadLine());

            int min = number;
            int max = number;

            //Цикл MinMax
            do
            {
                number = int.Parse(Console.ReadLine());

                if (number != 0 && number < min)
                    min = number;

                if (number != 0 && number > max)
                    max = number;
            } while (number != 0);

            int sumMinMax = min + max;

            Console.WriteLine($"Сума мінімального та максимального чисел: {sumMinMax}");
        }
    }
    //Третя задача
    public class Program3
    {
        //Функція для закінчень (-ий, -ій)
        private static void PrintOrdinalPrompt(int i)
        {
            string suffix = (i % 10 == 3 && i % 100 != 13) ? "-ій" : "-ий";
            Console.Write($"Введіть {i}{suffix} елемент: ");
        }
        //Третя задача (for)
        public static void Func3_for()
        {
            Console.Write("Введіть кількість елементів: ");

            int amount = int.Parse(Console.ReadLine());
            int indexOfNegative = -1;

            for (int i = 1; i <= amount; i++)
            {
                PrintOrdinalPrompt(i);

                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < 0)
                {
                    indexOfNegative = i;
                    break;
                }
            }

            if (indexOfNegative > -1)
                Console.WriteLine($"\nНомер першого від'ємного значення: {indexOfNegative}");
            else
                Console.WriteLine("\nВід'ємних чисел не знайдено");
        }
        //Третя задача (while)
        public static void Func3_while()
        {
            Console.Write("Введіть кількість елементів: ");

            int amount = int.Parse(Console.ReadLine());
            int indexOfNegative = -1;

            int currentNumber = 1;

            while (currentNumber <= amount)
            {
                PrintOrdinalPrompt(currentNumber);

                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < 0)
                {
                    indexOfNegative = currentNumber;
                    break;
                }
                currentNumber++;
            }

            if (indexOfNegative > -1)
                Console.WriteLine($"\nНомер першого від'ємного значення: {indexOfNegative}");
            else
                Console.WriteLine("\nВід'ємних чисел не знайдено");
        }
        //Третя задача (do-while)
        public static void Func3_doWhile()
        {
            Console.Write("Введіть кількість елементів: ");

            int amount = int.Parse(Console.ReadLine());
            int indexOfNegative = -1;

            int currentNumber = 1;

            do
            {
                PrintOrdinalPrompt(currentNumber);

                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < 0)
                {
                    indexOfNegative = currentNumber;
                    break;
                }

                currentNumber++;
            } while (currentNumber <= amount);

            if (indexOfNegative > -1)
                Console.WriteLine($"\nНомер першого від'ємного значення: {indexOfNegative}");
            else
                Console.WriteLine("\nВід'ємних чисел не знайдено");
        }
    }
    //Main
    public class ProgramMain
    {
        //Вхідна точка
        public static void Main(string[] args)
        {
            Console.Clear();

            bool isRunning = true;
            //Цикл вибору задачі
            do
            {
                Console.WriteLine("Оберіть задачу для виконання:\n\t1. Перша задача.\n\t2. Друга задача.\n\t3. Третя задача.");

                string? input = Console.ReadLine()?.Trim();

                if (int.TryParse(input, out int userInput))
                {
                    switch (userInput)
                    {
                        //Перша задача
                        case 1:
                            Console.Write("Оберіть цикл (1 - for, 2 - while, 3 - do-while): ");
                            int subchoice1 = int.Parse(Console.ReadLine());

                            Console.Write("Введiть K1: ");
                            int k1 = int.Parse(Console.ReadLine());

                            Console.Write("Введіть K2: ");
                            int k2 = int.Parse(Console.ReadLine());

                            Console.Write("Введіть n: ");
                            int n = int.Parse(Console.ReadLine());

                            switch (subchoice1)
                            {
                                //Перша задача (for)
                                case 1:
                                    Program1.Func1_for(k1, k2, n);

                                    isRunning = false;
                                    break;
                                //Пурша задача (while)
                                case 2:
                                    Program1.Func1_while(k1, k2, n);

                                    isRunning = false;
                                    break;
                                //Перша задача (do-while)
                                case 3:
                                    Program1.Func1_doWhile(k1, k2, n);

                                    isRunning = false;
                                    break;
                            } 
                            break;
                        //Друга задача
                        case 2:
                            Console.Write("Оберіть цикл (1 - for, 2 - while, 3 - do-while): ");
                            int subchoice2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть елементи, в кінці введіть нуль.");

                            switch (subchoice2)
                            {
                                //Друга задача (for)
                                case 1:
                                    Program2.Func2_for();

                                    isRunning = false;
                                    break;
                                //Друга задача (while)
                                case 2:
                                    Program2.Func2_while();

                                    isRunning = false;
                                    break;
                                //Друга задача (do-while)
                                case 3:
                                    Program2.Func2_doWhile();

                                    isRunning = false;
                                    break;
                            }
                            break;
                        //Третя задача
                        case 3:
                            Console.Write("Оберіть цикл (1 - for, 2 - while, 3 - do-while): ");
                            int subchoice3 = int.Parse(Console.ReadLine());

                            switch (subchoice3)
                            {
                                //Третя задача (for)
                                case 1:
                                    Program3.Func3_for();

                                    isRunning = false;
                                    break;
                                //Третя задача (while)
                                case 2:
                                    Program3.Func3_while();

                                    isRunning = false;
                                    break;
                                //Третя задача (do-while)
                                case 3:
                                    Program3.Func3_doWhile();

                                    isRunning = false;
                                    break;
                            }
                            break;
                        //Дефолт
                        default:
                            Console.WriteLine("Введено не корректне число.");
                            continue;
                    }
                }
                //Повернення юзера до початку циклу
                else
                {
                    Console.WriteLine("Введення не може бути пустим, або мати інші символи крім цифр. Введіть число 1-3.");
                    continue;
                }
            } while (isRunning);
        }
    }
}