using System;
using System.Collections.Generic;
using System.Text;

namespace IPGK.ReadFile.Security
{
    public class SecurityService : ISecurityService
    {
        public bool HasAccessToFile(string file, UserRole userRole)
        {
            switch (userRole)
            {
                case UserRole.Admin:
                    return true;
                case UserRole.Boss:
                    return !file.Contains("Admin");
                case UserRole.Employee:
                    return file.Contains("emp");
                case UserRole.Stage:
                    return false;
                default:
                    throw new ArgumentOutOfRangeException(nameof(userRole), userRole, null);
            }
        }
    }
}
