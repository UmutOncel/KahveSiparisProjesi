using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.YanUrunler
{
    public abstract class YanUrun
    {
        public YanUrunCesidi YanUrunCesidi { get; set; }
        public int HazirlanmaSüresi { get; set; }
        public decimal Fiyat { get; set; }
        public YanUrun(YanUrunCesidi yanUrunCesidi)
        {
            this.YanUrunCesidi = yanUrunCesidi;
        }
    }
}
