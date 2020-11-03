using System;
using System.Collections.Generic;
using System.Text;

namespace IPGK.ReadFile
{
    public class XmlFile
    {
        public string Read(string location)
        {
            string xmlString = System.IO.File.ReadAllText(location);
            return xmlString;
        }
    }
}
