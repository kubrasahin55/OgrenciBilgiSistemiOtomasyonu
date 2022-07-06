using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace BusinessLayer
{
  public class BLDersler
    {
        public static int Ekleme(EDersler veri)
        {
            if (veri.DersAdi != null && veri.DersAdi.Trim().Length > 0)  
            {
                return FDersler.Ekleme(veri);
            }
            return -1;
        }
        public static List<EDersler> Listele()
        {
            return FDersler.Listele();
        }



    }
}
