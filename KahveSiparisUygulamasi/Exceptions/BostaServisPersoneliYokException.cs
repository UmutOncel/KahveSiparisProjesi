using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Exceptions
{
    public class BostaServisPersoneliYokException:Exception
    {
        public BostaServisPersoneliYokException():base("Bosta Servis Personeli Yok")
        {
            
        }
    }
}
