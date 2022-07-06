using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace BusinessLayer
{
  public class BLOgretmenler
    {

        public static int Ekleme(EOgretmenler veri)
        {
            if (veri.OgretmenAdi != null && veri.OgretmenAdi.Trim().Length > 0)
            {
                return FOgretmenler.Ekleme(veri);
            }
            return -1;
        }
        public static List<EOgretmenler> Listele()
        {
            return FOgretmenler.Listele();
        }

    }
}
