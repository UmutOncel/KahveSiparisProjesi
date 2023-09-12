using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.YanUrunler
{
    public class Karamel:YanUrun
    {
        public Karamel():base(YanUrunCesidi.Karamel)
        {
            Fiyat = 15;
            HazirlanmaSüresi = 10;
        }
    }
}
