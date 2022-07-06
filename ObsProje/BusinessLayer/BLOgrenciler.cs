using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace BusinessLayer
{
 public   class BLOgrenciler
    {
        public static int Ekleme(EOgrenciler veri )
        {
            if (veri.OgrenciAdi != null && veri.OgrenciAdi.Trim().Length > 0)
            {
                return FOgrenciler.Ekleme(veri);
            }
            return -1;
        }
        public static List<EOgrenciler> Listele()
        {
            return FOgrenciler.Listele();
        }


    }
}
