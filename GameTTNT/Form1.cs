using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTTNT
{
    public partial class GAME : Form
    {
        private CaroChess caroChess;
        private Graphics grs;
        public GAME()
        {
            InitializeComponent();
            caroChess = new CaroChess();
            grs = pnlBanCo.CreateGraphics();
            caroChess.KhoiTaoMangOCo();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GAME_Load(object sender, EventArgs e)
        {

        }

        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {
            caroChess.VeBanCo(grs);
            caroChess.VeLaiQuanCo(grs);
        }

        private void pnlBanCo_MouseClick(object sender, MouseEventArgs e)
        {


            timer1.Start();
            if (caroChess.DanhCo(e.X, e.Y, grs)) {
                if (caroChess.KiemTraChienThang())
                {
                    caroChess.KetThucTroChoi();
                }
                else
                {
                    if (caroChess.CheDoChoi == 2)
                    {
                        caroChess.KhoiDongCom(grs);
                        if (caroChess.KiemTraChienThang())
                        {
                            caroChess.KetThucTroChoi();
                        }
                    }
                }

            } // e la chuot cua chung ta

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PvsP()
        {
            grs.Clear(pnlBanCo.BackColor);
            caroChess.StartPlayrvsPlayer(grs);
        }
        private void PvsC()
        {
            grs.Clear(pnlBanCo.BackColor);
            caroChess.StartPlayervsCom(grs);
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ngườiVsNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PvsP();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            PvsP();
            btnPvsP.Enabled = false;
            btnPvsC.Enabled = true;
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   grs.Clear(pnlBanCo.BackColor);
            caroChess.Undo(grs);
        }

        private void tiếnTiếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caroChess.Redo(grs);
        }

        private void ngườiVsMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PvsC();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            PvsC();
            btnPvsC.Enabled = false;
            btnPvsP.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                this.bar.Increment(1);
           
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (caroChess.CheDoChoi == 1)
            {
                PvsP();
            }
            else if (caroChess.CheDoChoi == 2)
                PvsC();
        }
    }

}
