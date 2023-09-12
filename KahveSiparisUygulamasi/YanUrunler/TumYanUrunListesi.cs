using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.YanUrunler
{
    public class TumYanUrunListesi
    {
        private List<YanUrun> tumYanUrunler = new List<YanUrun>() { new CikolataAromasi(), new Karamel(), new TatlandiriciSurup() };
        public List<YanUrun> TumYanUrunler { get { return this.tumYanUrunler; } }
    }
}
