using KahveSiparisUygulamasi.Icecekler.IcecekMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Urunler.SicakIcecekler
{
    public class TurkKahvesi:SicakIcecek
    {
        public TurkKahvesi()
        {
            IcecekMalzemeleri = new List<Malzeme>() { new Kahve(), new Seker(), new Su() };
            Fiyat = 100;
            HazirlanmaSuresi = 20;
            BegenilmeOrani = 90;
        }
    }
}
