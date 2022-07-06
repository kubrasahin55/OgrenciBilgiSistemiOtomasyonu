using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class EBolumler
    {
        private int _Bolum_Id;
        private string _BolumAdi;
        private int _OgrenciSayisi;

        public int Bolum_Id
        {
            get
            {
                return _Bolum_Id;
            }
            set
            {
                _Bolum_Id = value;
            }
        }
        public string BolumAdi
        {
            get
            {
                return _BolumAdi;
            }
            set
            {
                _BolumAdi = value;
            }
        }
        public int OgrenciSayisi
        {
            get
            {
                return _OgrenciSayisi;
            }
            set
            {
                _OgrenciSayisi = value;
            }
        }


    }
}
