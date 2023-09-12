using KahveSiparisUygulamasi.Personeller;
using KahveSiparisUygulamasi.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Interfaces
{
    public interface IMusteri
    {
        Icecek IcecekSiparisiVer();
        void UcretiNakitOde(KasaPersoneli kasaPersoneli, OdemeYontemi odemeYontemi);
        void UcretiKrediKartiIleOde(KasaPersoneli kasaPersoneli, OdemeYontemi odemeYontemi);
        void SiparisiTeslimAl(ServisPersoneli servisPersoneli);
        void SiradaBekle();
    }
}
