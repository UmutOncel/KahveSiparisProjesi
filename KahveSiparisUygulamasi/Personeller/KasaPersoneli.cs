using KahveSiparisUygulamasi.Exceptions;
using KahveSiparisUygulamasi.Icecekler.IcecekMalzemeleri;
using KahveSiparisUygulamasi.Interfaces;
using KahveSiparisUygulamasi.Urunler;
using KahveSiparisUygulamasi.YanUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Personeller
{
    public class KasaPersoneli:Personel, IKasaPersoneli
    {
        private bool servisPersoneliBosMu;
        private bool yanUrunVarMi;
        private bool bardakBuyukBoyMu;
        private List<Icecek> IcecekSiparisleri;

        public KasaPersoneli():base(Gorev.KasaPersoneli)
        {
            IcecekSiparisleri = new List<Icecek>();
        }

        /// <summary>
        /// Musteriden icecek siparisi alan, alırken de yan urun isteyip istemedigini ve bardak boyunu buyutmek isteyip istemedigini soran metot. Alinan siparis, liste icine atanir.
        /// </summary>
        /// <param name="musteri"></param>
        /// <param name="tumYanUrunListesi"></param>
        /// <param name="icecek"></param>
        /// <param name="yanUrun"></param>
        /// <exception cref="BostaServisPersoneliYokException"></exception>
        public void MusteridenSiparisAl(Musteri musteri, TumYanUrunListesi tumYanUrunListesi, Icecek icecek, YanUrun yanUrun) 
        {
            if (!servisPersoneliBosMu)
            {
                throw new BostaServisPersoneliYokException();
            }
            if (yanUrunVarMi)
            {
                IcecegeYanUrunEkle(tumYanUrunListesi, icecek, yanUrun);
            }
            if (bardakBuyukBoyMu)
            {
                IcecekBardakBoyutunuBuyukYap(musteri.IcecekSiparisiVer());
            }
            IcecekSiparisleri.Add(musteri.IcecekSiparisiVer());
        }

        /// <summary>
        /// Musteriden alinan siparisi servis personeline ileten metot.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="YeniSiparisYokException"></exception>
        public Icecek SiparisiServisPersonelineIlet() 
        {
            if (IcecekSiparisleri.Count == 0)
            {
                throw new YeniSiparisYokException();
            }
            Icecek guncelSiparis = IcecekSiparisleri[0];
            IcecekSiparisleri.Remove(guncelSiparis);
            return guncelSiparis;
        }

        /// <summary>
        /// Musteriden siparis ucretini alan, alırken ek ucretler varsa ucretin uzerine ekleyen metot. 
        /// </summary>
        /// <param name="icecek"></param>
        /// <param name="yanUrun"></param>
        /// <returns></returns>
        public decimal ToplamUcretiAl(Icecek icecek, YanUrun yanUrun) 
        {
            decimal fiyat = icecek.Fiyat;
            if (yanUrunVarMi)
            {
                fiyat += yanUrun.Fiyat;
            }
            if (bardakBuyukBoyMu)
            {
                fiyat += icecek.BuyukBoyBardakFiyatFarki;
            }
            return fiyat;
        }

        /// <summary>
        /// Musterinin tercih ettigi icecegin bardak boyutunu buyuten metot.
        /// </summary>
        /// <param name="icecek"></param>
        public void IcecekBardakBoyutunuBuyukYap(Icecek icecek)
        {
            icecek.BardakBoyutu = BardakBoyutu.Buyuk;
        }

        /// <summary>
        /// Kasa personelini molaya cikaran metot.
        /// </summary>
        /// <param name="value"></param>
        public override void MolayaCik(object value)
        {
            value = null;
        }

        /// <summary>
        /// Yeni bir kasa personeli donduren metot.
        /// </summary>
        /// <returns></returns>
        public override KasaPersoneli MoladanDon()
        {
            return this;
        }

        /// <summary>
        /// Musterinin siparis ettigi icecege yan urun ekleyen, bu urun yok ise hata firlatan metot.
        /// </summary>
        /// <param name="tumYanUrunListesi"></param>
        /// <param name="icecek"></param>
        /// <param name="yanUrun"></param>
        /// <exception cref="ElimizdeBuYanUrunYokException"></exception>
        public void IcecegeYanUrunEkle(TumYanUrunListesi tumYanUrunListesi, Icecek icecek, YanUrun yanUrun)
        {
            if (tumYanUrunListesi.TumYanUrunler.Contains(yanUrun))
            {
                icecek.IcecekYanUrunleri.Add(yanUrun);
            }
            else
            {
                throw new ElimizdeBuYanUrunYokException();
            }
        }

        /// <summary>
        /// Musterinin siparis ettigi icecekten malzeme cikaran, bu malzeme icecek icinde yoksa hata firlatan metot.
        /// </summary>
        /// <param name="icecek"></param>
        /// <param name="malzeme"></param>
        /// <exception cref="IcecekIcindeBuMalzemeYokException"></exception>
        public void IcecektenMalzemeCikar(Icecek icecek, Malzeme malzeme) 
        {
            if (icecek.IcecekMalzemeleri.Contains(malzeme))
            {
                icecek.IcecekMalzemeleri.Remove(malzeme);
            }
            else
            {
                throw new IcecekIcindeBuMalzemeYokException();
            }
        }
    }
}
