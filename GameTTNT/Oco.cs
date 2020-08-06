using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTTNT
{
    class Oco
    {
        public static int ChieuRong = 20;
        public static int ChieuCao = 20;
        private int _Dong;
        public int Dong   // ctr + r+e
        {
            set { _Dong = value; }
            get { return _Dong; }
        }

        public int Cot
        {
            get
            {
                 return _Cot;
            }

            set
            {
                _Cot = value;
            }
        }

        private int _Cot;

        private Point _Vitri;
        public Point Vitri
        {
            set { _Vitri = value; }
            get { return _Vitri; }
        }


        private int _SoHuu;
        public int SoHuu
        {
            set { _SoHuu = value; }
            get { return _SoHuu; }
        }

        public Oco(int dong, int cot, Point vitri,int sohuu)
        {
            _Dong = dong;
            _Cot = cot;
            _Vitri = vitri;
            _SoHuu = sohuu;
        }
        public Oco(){

            }
    }
}
