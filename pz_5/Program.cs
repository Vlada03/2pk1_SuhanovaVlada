using System.Runtime.CompilerServices;

namespace pz_5
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
                    for (int w = 20; w <= 100; w += 5)
                    {
                        l++;
                        Console.WriteLine($"{l} шаг. {w}");
                    }
                    break;
                case 2:
                    for (char a = 'Е'; a <= 'К'; a++)
                    {
                        Console.Write($"{a} ");
                    }
                    break;
                case 3:
                    int n = 6;
                    int m = 9;
                    for (int k = 0; k < m; k++)
                    {
                        for (int x = 0; x < n; x++)
                        {
                            Console.Write('#');
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    Console.WriteLine("Числа, кратные 5:");
                    for (int p = 0; p <= 100; p++)
                    {
                        if (p % 5 == 0)
                        {
                            Console.Write($"{p} ");
                        }

                    }
                    break;
                case 5:
                    int j = 99;
                    int i = 5;
                    for (; i - j != 4; i++, j--)
                    {
                        Console.WriteLine($"{i} - {j} != 4");
                    }
                    Console.WriteLine($"{i} - {j} = 4");
                    break;
            }
            Console.ReadKey();
            
        }
    }
}