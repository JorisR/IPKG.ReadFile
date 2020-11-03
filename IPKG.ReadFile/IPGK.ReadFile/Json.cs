using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using IPGK.ReadFile.Encryption;
using IPGK.ReadFile.Security;
using Newtonsoft.Json;

namespace IPGK.ReadFile
{
    public class Json : File
    {
        public Json(IEncryption encryption, ISecurityService securityService) : base(encryption, securityService)
        {
        }

        public override string Read(string file)
        {
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();
                dynamic item = JsonConvert.DeserializeObject(json);
                return item.ToString();
            }

           

        }
    }
}
