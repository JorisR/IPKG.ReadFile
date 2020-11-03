using System;
using System.Collections.Generic;
using System.Text;
using IPGK.ReadFile.Encryption;
using IPGK.ReadFile.Security;

namespace IPGK.ReadFile
{
    public class XmlFile : File
    {


        public XmlFile(IEncryption encryption, ISecurityService securityService) : base(encryption, securityService)
        {
        }
        public override string Read(string location)
        {
            string xmlString = System.IO.File.ReadAllText(location);
            return xmlString;
        }


    }
}
