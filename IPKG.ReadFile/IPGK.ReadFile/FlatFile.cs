using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPGK.ReadFile.Encryption;
using IPGK.ReadFile.Security;

namespace IPGK.ReadFile
{
    public class FlatFile : File
    {
        public FlatFile(IEncryption encryption, ISecurityService securityService) :base(encryption, securityService)
        {
        }

        public override string Read(string file)
        {
            var lines = System.IO.File.ReadAllLines(file);
            return string.Join(",", lines);
        }
    }
}
