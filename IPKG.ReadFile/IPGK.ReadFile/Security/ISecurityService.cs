using System;
using System.Collections.Generic;
using System.Text;

namespace IPGK.ReadFile.Security
{
    public interface ISecurityService
    {
        bool HasAccessToFile(string file, UserRole userRole);
    }
}
