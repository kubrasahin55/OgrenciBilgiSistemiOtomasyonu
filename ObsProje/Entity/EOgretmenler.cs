using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public class EOgretmenler
    {
        private int _Ogretmen_Id;
        private string _OgretmenAdi;
        private string _OgretmenSoyadi;
        private string _OgretmenBrans;


        public int Ogretmen_Id
        {
            get
            {
                return _Ogretmen_Id;
            }
            set
            {
                _Ogretmen_Id = value;
            }
        }
        public string OgretmenAdi
        {
            get
            {
                return _OgretmenAdi;

            }
            set
            {
                _OgretmenAdi = value;
            }
        }
        public string OgretmenSoyadi
        {
            get
            {
                return _OgretmenSoyadi;
            }
            set
            {
                _OgretmenSoyadi = value;
            }
        }
        public string OgretmenBrans
        {
            get
            {
                return _OgretmenBrans;
            }
            set
            {
                _OgretmenBrans = value;
            }

        }
    }
}
