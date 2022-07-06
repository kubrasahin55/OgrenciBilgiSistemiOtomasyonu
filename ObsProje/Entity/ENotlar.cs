using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ENotlar
    {
        private int _Not_Id;
        private int _Ders_Id;
        private int _OgrenciNo;
        private float _Vize;
        private float _Final;
        private float _Ortalama;
        private string _Durum;

        public int Not_Id
        {
            get
            {
                return _Not_Id;
            }
            set
            {
                _Not_Id = value;
            }
        }
        public int Ders_Id
        {
            get
            {
                return _Ders_Id;
            }
            set
            {
                _Ders_Id = value;
            }
        }
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
        public float Vize
        {
            get
            {
                return _Vize;
            }
            set
            {
                _Vize = value;
            }
        }
        public float Final
        {
            get
            {
                return _Final;
            }
            set
            {
                _Final = value;
            }
        }
        public float Ortalama
        {
            get
            {
                return _Ortalama;
            }
            set
            {
                _Ortalama = value;
            }
        }
        public string Durum
        {
            get
            {
                return _Durum;
            }
            set
            {
                _Durum = value;
            }
        }
    }
}
