using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winMusicBox
{
    public class Muzik
    {
        public string Adi { get; set; }
        public string Konumu { get; set; }
        public string DosyaUzantisi { get; set; }

        // Constructor
        public Muzik(string pAd, string pKonum, string pUzanti)
        {
            // Nesneyi new ederken değerleri alma.
            Adi = pAd;
            Konumu = pKonum;
            DosyaUzantisi = pUzanti;
        }

        public override string ToString()
        {
            return Adi;
        }
    }
}
