using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTTNT
{
    class BanCo
    {
        private int _SoCot;
        private int _SoDong;
        public int SoDong
        {
            get { return _SoDong; }
        }
        public int SoCot
        {
            get { return _SoCot; }
        }
        public BanCo()
        {
            _SoCot = 0;
            _SoDong = 0;
        }
        public BanCo(int soDong , int soCot)
        {
            _SoCot = soCot;
            _SoDong = soDong;
        }
    
          public void VeBanCo(Graphics g)
        {
            for(int i = 0; i <= _SoCot; i++)
            {
                g.DrawLine(CaroChess.pen,i*Oco.ChieuRong,0,i*Oco.ChieuRong,_SoDong*Oco.ChieuCao);
            }

            for (int j = 0; j <= _SoDong; j++)
            {
                g.DrawLine(CaroChess.pen, 0,j*Oco.ChieuCao,_SoCot*Oco.ChieuRong,j*Oco.ChieuCao);
            }
        }


        public void VeQuanCo(Graphics g, Point point,SolidBrush sb)
        {
            g.FillEllipse(sb, point.X +2, point.Y+2, Oco.ChieuRong-4, Oco.ChieuCao-4);
        }

        public void XoaQuanCo(Graphics g,Point p, SolidBrush sb)
        {
            g.FillRectangle(sb, p.X + 2, p.Y+2, Oco.ChieuRong - 4, Oco.ChieuCao-4);
        }
    }
}
