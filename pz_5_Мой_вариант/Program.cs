namespace pz_5_Мой_вариант
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания от 1 до 5");
            int zadanie = Convert.ToInt32(Console.ReadLine());
            switch (zadanie)
            {
                case 1:
                    int l = 0;
                    Console.Write("Введите начало диапазона: ");
                    int w = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите конец диапазона: ");
                    int k_d = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите, на сколько шагов будет прибавляться: ");
                    int prib = Convert.ToInt32(Console.ReadLine());
                    for (; w <= k_d; w += prib)
                    {
                        l++;
                        Console.WriteLine($"{l} шаг. {w}");
                    }
                    break;
                case 2:
                    Console.Write("Введите, с какой буквы начать перечисление: ");
                    char a = Convert.ToChar(Console.ReadLine());
                    Console.Write($"Введите букву, до которой надо перечислить: ");
                    char b = Convert.ToChar(Console.ReadLine());
                    for (; a <= b; a++)
                    {
                        Console.Write($"{a}, ");
                    }
                    break;
                case 3:
                    Console.Write("Введите количество символов в строке: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите количество строк: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите символ, который будет выводиться: ");
                    string sim = Console.ReadLine();
                    for (int k = 0; k < m; k++)
                    {
                        for (int x = 0; x < n; x++)
                        {
                            Console.Write(sim);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    Console.Write("Введите начало диапазона: ");
                    int p = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите конец диапазона: ");
                    int kd = Convert.ToInt32(Console.ReadLine());
                    Console.Write("введите кратное число: ");
                    int krat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Числа, кратные {krat}:");
                    for (; p <= kd; p++)
                    {
                        if (p % 5 == 0)
                        {
                            Console.Write($"{p} ");
                        }

                    }
                    break;
                case 5:
                    Console.WriteLine("Рекомендованные числа: первое - 99, второе - 5 и третье - 4");
                    Console.Write("Введите первую переменную: ");
                    int j = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите вторую переменную: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.Write("К какому числу надо прировнять? ");
                    int pri = Convert.ToInt32(Console.ReadLine());
                    for (; i - j != pri; i++, j--)
                    {
                        Console.WriteLine($"{i} - {j} не ровняется {pri}");
                    }
                    Console.WriteLine($"А вот тут {i} - {j} = {pri}");
                    break;
            }
            Console.ReadKey();
        }
    }
}