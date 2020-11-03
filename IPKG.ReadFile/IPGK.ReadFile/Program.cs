using System;
using IPGK.ReadFile.Encryption;
using IPGK.ReadFile.Security;

namespace IPGK.ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the file to read");
            var fileName = Console.ReadLine();
            var encryption = new ReverseEncryption();
            var security = new SecurityService();

            var file = new FlatFile(encryption, security);
            Console.Write(file.ReadSecure(fileName, UserRole.Admin));

        }

       
    }
}
