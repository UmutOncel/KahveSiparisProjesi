using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Exceptions
{
    public class ElimizdeBuYanUrunYokException:Exception
    {
        public ElimizdeBuYanUrunYokException():base("Elimizde Bu Yan Urun Yok")
        {
            
        }
    }
}
