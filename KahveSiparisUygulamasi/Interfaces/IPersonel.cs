using KahveSiparisUygulamasi.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Interfaces
{
    public interface IPersonel
    {
        void MolayaCik(object value);
        Personel MoladanDon();
    }
}
