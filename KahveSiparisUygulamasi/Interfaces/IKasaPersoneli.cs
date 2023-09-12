using KahveSiparisUygulamasi.Icecekler.IcecekMalzemeleri;
using KahveSiparisUygulamasi.Urunler;
using KahveSiparisUygulamasi.YanUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Interfaces
{
    public interface IKasaPersoneli
    {
        void MusteridenSiparisAl(Musteri musteri, TumYanUrunListesi tumYanUrunListesi, Icecek icecek, YanUrun yanUrun);
        Icecek SiparisiServisPersonelineIlet();
        decimal ToplamUcretiAl(Icecek icecek, YanUrun yanUrun);
        void IcecekBardakBoyutunuBuyukYap(Icecek icecek);
        void IcecegeYanUrunEkle(TumYanUrunListesi tumYanUrunListesi, Icecek icecek, YanUrun yanUrun);
        void IcecektenMalzemeCikar(Icecek icecek, Malzeme malzeme);
    }
}
