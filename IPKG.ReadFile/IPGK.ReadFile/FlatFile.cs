using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPGK.ReadFile.Encryption;

namespace IPGK.ReadFile
{
    public class FlatFile
    {
        private readonly IEncryption _encryption;

        public FlatFile(IEncryption encryption)
        {
            _encryption = encryption;
        }

        public string Read(string file)
        {
            var lines = System.IO.File.ReadAllLines(file);
            return string.Join(",", lines);
        }

        public string ReadEncrypted(string file)
        {
            var lines = System.IO.File.ReadAllLines(file);
            var text = string.Join(",", lines);
            return _encryption.Encrypt(text);
        }
    }
}
