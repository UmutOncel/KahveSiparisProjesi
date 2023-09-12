using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Exceptions
{
    public class IcecekIcindeBuMalzemeYokException:Exception
    {
        public IcecekIcindeBuMalzemeYokException():base("Icecek Icinde Bu Malzeme Yok")
        {
            
        }
    }
}
