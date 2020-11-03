using System;
using IPGK.ReadFile.Security;

namespace IPGK.ReadFile.Web.Models
{
    public class ReadFileModel
    {
        public string File { get; set; }
        public FileType FileType { get; set; }
        public bool UseSecurity { get; set; }
        public bool UseEncryption { get; set; }
        public UserRole UserRole { get; set; }
    }
}