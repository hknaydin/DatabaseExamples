using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.model
{
    public class TblGorus
    {
        public int GorusKod { get; set; }
        public int UrunKod { get; set; }
        public int KullaniciKod { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Ip { get; set; }
        public bool AktifMi { get; set; }
        public DateTime Tarih { get; set; }
        public int Katilan { get; set; }
        public int Katilmayan { get; set; }
    }
}
