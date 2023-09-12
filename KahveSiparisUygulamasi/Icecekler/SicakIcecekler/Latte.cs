using KahveSiparisUygulamasi.Icecekler.IcecekMalzemeleri;
using KahveSiparisUygulamasi.Urunler.SicakIcecekler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Icecekler.SicakIcecekler
{
    public class Latte:SicakIcecek
    {
        public Latte()
        {
            IcecekMalzemeleri = new List<Malzeme>() { new Kahve(), new Su(), new Krema(), new Sut(), new Seker() };
            Fiyat = 80;
            HazirlanmaSuresi = 20;
            BegenilmeOrani = 60;
        }
    }
}
