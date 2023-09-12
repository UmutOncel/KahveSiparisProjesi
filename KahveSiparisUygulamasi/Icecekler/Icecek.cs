using KahveSiparisUygulamasi.Icecekler.IcecekMalzemeleri;
using KahveSiparisUygulamasi.YanUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Urunler
{
    public abstract class Icecek
    {
        private bool sicakMi;
        public bool SicakMi { get { return this.sicakMi; } }
        public decimal Fiyat { get; set; }
        public int HazirlanmaSuresi { get; set; }
        public int BegenilmeOrani { get; set; }
        public BardakBoyutu BardakBoyutu { get; set; }

        private decimal buyukBoyBardakFiyatFarki = 10;
        public decimal BuyukBoyBardakFiyatFarki { get { return this.buyukBoyBardakFiyatFarki; } }
        public List<Malzeme> IcecekMalzemeleri { get; set; }
        public List<YanUrun> IcecekYanUrunleri { get; set; }
        public Icecek(bool sicakMi)
        {
            this.sicakMi = sicakMi;
        }
    }
}
