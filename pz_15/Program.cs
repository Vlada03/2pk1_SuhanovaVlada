using System.IO;

namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к папке: ");
            string dirName = Console.ReadLine();
            String[] files = Directory.GetFiles(dirName); //поменять на директори
            if (files.Length == 0)
                Console.WriteLine("Файлов нет");
            else if (new DirectoryInfo(dirName).GetFiles("*.exe").Any(x => x.Extension == ".exe"))
            {
                Console.WriteLine("Файлы с расширением .exe");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}