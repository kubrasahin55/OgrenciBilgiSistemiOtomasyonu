using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EDersler
    {
        private int _Ders_Id;
        private string _DersAdi;
        private int _Ogretmen_Id;

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
        public string DersAdi
        {
            get
            {
                return _DersAdi;

            }
            set
            {
                _DersAdi = value;
            }
        }
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
    }
}
