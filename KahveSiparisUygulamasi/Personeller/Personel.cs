using KahveSiparisUygulamasi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisUygulamasi.Personeller
{
    public abstract class Personel:IPersonel
    {
        public Gorev Gorev { get; set; }
        public Personel(Gorev gorev)
        {
            this.Gorev = gorev;
        }

        /// <summary>
        /// Molaya cik metodu tum personellerde ortak oldugu icin ezildi. Ilgili siniflarda override yapilacak.
        /// </summary>
        /// <param name="value"></param>
        public abstract void MolayaCik(object value);

        /// <summary>
        /// Molayadan don metodu tum personellerde ortak oldugu icin ezildi. Ilgili siniflarda override yapilacak.
        /// </summary>
        /// <returns></returns>
        public abstract Personel MoladanDon();
    }
}
