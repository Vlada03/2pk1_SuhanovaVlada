
namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задана функция y = |x|? где -4 <= x <= 4. Шаг: 0,5");
            double x = -4;
            Console.WriteLine("y = ");
            do
            {
                Console.WriteLine(Math.Abs(x));
                x += 0.5;
            }
            while (x <= 4);
        }
    }
}