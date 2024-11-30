using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.model
{
    public class TblHesap
    {
        public int HesapNo { get; set; }

        public string Isim { get; set; }
        public string Soyad { get; set; }
        public string Sube { get; set; }
        public decimal Bakiye { get; set; }
    }
}
