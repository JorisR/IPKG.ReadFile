using System;
using System.Collections.Generic;
using System.Text;
using IPGK.ReadFile.Encryption;
using IPGK.ReadFile.Security;

namespace IPGK.ReadFile
{
    public abstract class File
    {
        protected readonly IEncryption Encryption;
        private readonly ISecurityService _securityService;

        protected File(IEncryption encryption, ISecurityService securityService)
        {
            Encryption = encryption;
            _securityService = securityService;
        }

        public abstract string Read(string file);

        public string ReadEncrypted(string file)
        {
            var text = Read(file);
            return Encryption.Encrypt(text);
        }
        public string ReadSecure(string location, UserRole userRole)
        {
            if (!_securityService.HasAccessToFile(location, userRole))
                return "No Access";
            return Read(location);
        }


    }
}
