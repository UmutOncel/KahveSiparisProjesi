using KahveSiparisUygulamasi.Exceptions;
using KahveSiparisUygulamasi.Interfaces;
using KahveSiparisUygulamasi.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Personeller
{
    public class ServisPersoneli:Personel, IServisPersoneli
    {
        private bool molaBittiMi;
        private bool siparisHazirMi;
        private List<Icecek> ServisBolumuIcecekSiparisleri;

        public ServisPersoneli():base(Gorev.ServisPersoneli)
        {
            ServisBolumuIcecekSiparisleri = new List<Icecek>();
        }

        /// <summary>
        /// Kasa personelinden musteri siparisini alan, siparis yok ise servis personelini molaya cikaran metot.
        /// </summary>
        /// <param name="kasaPersoneli"></param>
        public void KasaPersonelindenSiparisiAl(KasaPersoneli kasaPersoneli) 
        {
            try
            {
                ServisBolumuIcecekSiparisleri.Add(kasaPersoneli.SiparisiServisPersonelineIlet());
            }
            catch (YeniSiparisYokException)
            {
                MolayaCik(this);
                if (molaBittiMi)
                {
                    MoladanDon();
                }
            }
        }

        /// <summary>
        /// Servis personelini molaya cikaran metot.
        /// </summary>
        /// <param name="value"></param>
        public override void MolayaCik(object value)
        {
            value = null;
        }

        /// <summary>
        /// Yeni bir servis personeli donduren metot.
        /// </summary>
        /// <returns></returns>
        public override ServisPersoneli MoladanDon()
        {
            return this;
        }

        /// <summary>
        /// Siparisi hazirlayip teslim eden, siparis henuz hazir degilse hata firlatan metot.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="YeniSiparisYokException"></exception>
        /// <exception cref="SiparisHazirDegilException"></exception>
        public Icecek SiparisiHazirlaVeTeslimEt() 
        {
            if (siparisHazirMi)
            {
                Icecek hazirSiparis = ServisBolumuIcecekSiparisleri[0];
                ServisBolumuIcecekSiparisleri.Remove(hazirSiparis);
                return hazirSiparis;
            }
            else
            {
                throw new SiparisHazirDegilException();
            }
        }
    }
}
