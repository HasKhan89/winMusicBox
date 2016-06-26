using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winMusicBox
{
    public class Resim
    {
        public string DosyaAdi { get; set; }
        public string Konumu { get; set; }

        public Resim(string pDosyaAdi, string pKonum)
        {
            DosyaAdi = pDosyaAdi;
            Konumu = pKonum;
        }

        public override string ToString()
        {
            return DosyaAdi;
        }
    }
}
