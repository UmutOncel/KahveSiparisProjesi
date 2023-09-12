using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.YanUrunler
{
    public class CikolataAromasi:YanUrun
    {
        public CikolataAromasi():base(YanUrunCesidi.CikolataAromasi)
        {
            Fiyat = 15;
            HazirlanmaSüresi = 10;
        }
    }
}
