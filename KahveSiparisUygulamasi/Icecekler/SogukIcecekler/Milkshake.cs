using KahveSiparisUygulamasi.Icecekler.IcecekMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Urunler.SogukIcecekler
{
    public class Milkshake:SogukIcecek
    {
        public Milkshake()
        {
            IcecekMalzemeleri = new List<Malzeme>() { new Kahve(), new Sut(), new Seker() };
            Fiyat = 120;
            HazirlanmaSuresi = 25;
            BegenilmeOrani = 60;
        }
    }
}
