using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.YanUrunler
{
    public class TatlandiriciSurup:YanUrun
    {
        public TatlandiriciSurup():base(YanUrunCesidi.TatlandiriciSurup)
        {
            Fiyat = 20;
            HazirlanmaSüresi = 10;
        }
    }
}
