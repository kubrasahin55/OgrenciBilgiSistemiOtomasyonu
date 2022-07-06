using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class EOgrenciler
    {
        private int _OgrenciNo;
        private string _OgrenciAdi;
        private string _OgrenciSoyadi;
        private int _Bolum_Id;



        public int OgrenciNo
        {
            get
            {
                return _OgrenciNo;

            }
            set
            {
                _OgrenciNo = value;
            }
        }
        public string OgrenciAdi
        {
            get
            {
                return _OgrenciAdi;
            }
            set
            {
                _OgrenciAdi = value;
            }
        }
        public string OgrenciSoyadi
        {
            get
            {
                return _OgrenciSoyadi;
            }
            set
            {
                _OgrenciSoyadi = value;
            }
        }
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

    }
}
