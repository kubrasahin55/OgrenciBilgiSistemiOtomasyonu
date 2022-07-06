using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace BusinessLayer
{
   public class BLNotlar
    {

        public static int Ekleme(ENotlar veri)
        {
            if (veri.Durum != null && veri.Durum.Trim().Length > 0)
            {
                return FNotlar.Ekleme(veri);
            }
            return -1;
        }
        public static List<ENotlar> Listele()
        {
            return FNotlar.Listele();
        }



    }
}
