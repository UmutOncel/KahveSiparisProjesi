using KahveSiparisUygulamasi.Exceptions;
using KahveSiparisUygulamasi.Interfaces;
using KahveSiparisUygulamasi.Personeller;
using KahveSiparisUygulamasi.Urunler;
using KahveSiparisUygulamasi.YanUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi
{
    public class Musteri:IMusteri
    {
        private int adimBoyu = 3;
        public int AdimBoyu { get { return this.adimBoyu; } set { adimBoyu = value; } }
        public Icecek Icecek { get; set; }
        public YanUrun YanUrun { get; set; }
        public decimal NakitBakiye { get; set; }
        public decimal KrediKartiBakiye { get; set; }

        /// <summary>
        /// Icecek siparisi veren metot. 
        /// </summary>
        /// <returns></returns>
        public Icecek IcecekSiparisiVer() 
        {
            return this.Icecek;
        }

        /// <summary>
        /// Icecek ucretini nakit olarak odeyen metot.
        /// </summary>
        /// <param name="kasaPersoneli"></param>
        /// <param name="odemeYontemi"></param>
        /// <exception cref="YetersizBakiyeException"></exception>
        public void UcretiNakitOde(KasaPersoneli kasaPersoneli, OdemeYontemi odemeYontemi) 
        {
            if (NakitBakiye < kasaPersoneli.ToplamUcretiAl(Icecek, YanUrun))
            {
                throw new YetersizBakiyeException();
            }
            this.NakitBakiye -= kasaPersoneli.ToplamUcretiAl(Icecek, YanUrun);
        }

        /// <summary>
        /// Icecek ucretini kredi karti ile odeyen metot.
        /// </summary>
        /// <param name="kasaPersoneli"></param>
        /// <param name="odemeYontemi"></param>
        /// <exception cref="YetersizBakiyeException"></exception>
        public void UcretiKrediKartiIleOde(KasaPersoneli kasaPersoneli, OdemeYontemi odemeYontemi) 
        {
            if (KrediKartiBakiye < kasaPersoneli.ToplamUcretiAl(Icecek, YanUrun))
            {
                throw new YetersizBakiyeException();
            }
            this.KrediKartiBakiye -= kasaPersoneli.ToplamUcretiAl(Icecek, YanUrun);
        }

        /// <summary>
        /// Servis personelinden gelen siparisi teslim alan metot.
        /// </summary>
        /// <param name="servisPersoneli"></param>
        public void SiparisiTeslimAl(ServisPersoneli servisPersoneli) 
        {
            this.Icecek = servisPersoneli.SiparisiHazirlaVeTeslimEt();
        }

        /// <summary>
        /// Musteriyi sirada bekleten metot.
        /// </summary>
        public void SiradaBekle() 
        {
            this.AdimBoyu = 0;
        }
    }
}
