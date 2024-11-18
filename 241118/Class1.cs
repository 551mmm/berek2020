using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _241118
{
    internal class Class1
    {
        public string nev { get; set;}
        public string neme { get; set;}
        public string reszleg { get; set;}
        public int belepes { get; set;}
        public int ber { get; set; }

        public Class1(string sor)
        {
            string[] s = sor.Split(";");
            nev = s[0];
            neme = s[1];
            reszleg = s[2];
            belepes = Convert.ToInt32(s[3]);
            ber = Convert.ToInt32(s[4]);
        }
    }

    
}
