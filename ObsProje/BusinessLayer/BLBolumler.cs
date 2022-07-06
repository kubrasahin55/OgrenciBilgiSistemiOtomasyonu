using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace BusinessLayer
{
  public class BLBolumler
    {

        public static int Ekleme(EBolumler veri)
        {
            if (veri.BolumAdi != null && veri.BolumAdi.Trim().Length > 0)  //trim boşluk kontrolü yapıyor.
            {
                return FBolumler.Ekleme(veri);
            }
            return -1;
        }
        public static List<EBolumler> Listele()
        {
            return FBolumler.Listele();
        }

    }
}
