using KahveSiparisUygulamasi.Personeller;
using KahveSiparisUygulamasi.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Interfaces
{
    public interface IServisPersoneli
    {
        void KasaPersonelindenSiparisiAl(KasaPersoneli kasaPersoneli);
        Icecek SiparisiHazirlaVeTeslimEt();
    }
}
