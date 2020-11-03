using System;
using System.Collections.Generic;
using System.Text;
using IPGK.ReadFile.Encryption;

namespace IPGK.ReadFile
{
    public abstract class File
    {
        protected readonly IEncryption Encryption;

        protected File(IEncryption encryption)
        {
            Encryption = encryption;
        }

        public abstract string Read(string file);

        public string ReadEncrypted(string file)
        {
            var text = Read(file);
            return Encryption.Encrypt(text);
        }

    }
}
