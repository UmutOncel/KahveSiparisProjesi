using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Exceptions
{
    public class YeniSiparisYokException:Exception
    {
        public YeniSiparisYokException():base("Yeni Siparis Yok")
        {
            
        }
    }
}
