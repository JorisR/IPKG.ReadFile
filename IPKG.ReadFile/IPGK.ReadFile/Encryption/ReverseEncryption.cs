using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPGK.ReadFile.Encryption
{
    public class ReverseEncryption : IEncryption
    {
        public string Encrypt(string text)
        {
            var chars = text.ToCharArray();
            var reverse = chars.Reverse();
            return new string(reverse.ToArray());
        }
    }
}
