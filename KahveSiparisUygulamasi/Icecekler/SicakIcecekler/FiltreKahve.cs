using KahveSiparisUygulamasi.Icecekler.IcecekMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Urunler.SicakIcecekler
{
    public class FiltreKahve:SicakIcecek
    {
        public FiltreKahve()
        {
            IcecekMalzemeleri = new List<Malzeme>() { new Kahve(), new Su() };
            Fiyat = 90;
            HazirlanmaSuresi = 10;
            BegenilmeOrani = 80;
        }
    }
}
