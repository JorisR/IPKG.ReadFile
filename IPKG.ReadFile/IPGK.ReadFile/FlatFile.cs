using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPGK.ReadFile
{
    public class FlatFile
    {
        public string Read(string file)
        {
            var lines = System.IO.File.ReadAllLines(file);
            return string.Join(",", lines);
        }
    }
}
