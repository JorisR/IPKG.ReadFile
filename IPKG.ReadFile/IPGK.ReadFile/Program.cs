using System;
using IPGK.ReadFile.Encryption;

namespace IPGK.ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the file to read");
            var fileName = Console.ReadLine();
            var encryption = new ReverseEncryption();
            var file = new FlatFile(encryption);
            Console.Write(file.ReadEncrypted(fileName));

        }

       
    }
}
