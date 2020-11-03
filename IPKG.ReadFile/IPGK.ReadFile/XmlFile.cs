using System;
using System.Collections.Generic;
using System.Text;
using IPGK.ReadFile.Security;

namespace IPGK.ReadFile
{
    public class XmlFile
    {
        private readonly ISecurityService _securityService;

        public XmlFile(ISecurityService securityService)
        {
            _securityService = securityService;
        }
        public string Read(string location)
        {
            string xmlString = System.IO.File.ReadAllText(location);
            return xmlString;
        }

        public string ReadSecure(string location, UserRole userRole)
        {
            if (!_securityService.HasAccessToFile(location, userRole))
                return "No Access";
            return Read(location);
        }
    }
}
