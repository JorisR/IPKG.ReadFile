using System;

namespace IPGK.ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the file to read");
            var fileName = Console.ReadLine();
            var file = new FlatFile();
            Console.Write(file.Read(fileName));

        }
    }
}
