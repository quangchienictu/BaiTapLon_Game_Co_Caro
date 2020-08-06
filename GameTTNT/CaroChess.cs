using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTTNT
{
    public enum KETTHUC
    {
        HoaCo,
        player,
        player1,
        player2,
        COM

    }
    class CaroChess
    {
        public static Pen pen;
        public static SolidBrush sbWhite;
        public static SolidBrush sbBlack;
        public static SolidBrush sbGreen;
        private BanCo _BanCo;
        private Oco[,] _MangOco;
        private int _LuotDi;
        private bool _SanSang;
        private Stack<Oco> stkCacNuocDaDi;
        private Stack<Oco> stkCacNuocUndo;
        private KETTHUC _ketthuc;
        private int _CheDoChoi;
        public bool SanSang{
            get { return _SanSang; }
            }
        public int CheDoChoi
        {
            get { return _CheDoChoi; }
        }
        public CaroChess()
        {
            pen = new Pen(Color.Red);
            sbWhite = new SolidBrush(Color.White);
            sbBlack = new SolidBrush(Color.Black);
            // sbBlack = new SolidBrush(Color.FromArgb();Teal
            sbGreen = new SolidBrush(Color.Teal);
            _BanCo = new BanCo(30, 30);
            _MangOco = new Oco[_BanCo.SoDong, _BanCo.SoCot];
            stkCacNuocDaDi = new Stack<Oco>();
            stkCacNuocUndo = new Stack<Oco>();
            _LuotDi = 1;
        }
        public void VeBanCo(Graphics g)
        {
            _BanCo.VeBanCo(g);
        }
        public void KhoiTaoMangOCo()
        {
            for(int i = 0; i < _BanCo.SoDong;i++)
            {
                for(int j = 0; j < _BanCo.SoCot; j++)
                {
                    _MangOco[i,j] = new Oco(i,j,new Point (j*Oco.ChieuRong,i*Oco.ChieuCao),0);
                }
            }
        }

        public bool DanhCo(int MouseX ,int MouseY, Graphics g)
        {
            if(MouseX % Oco.ChieuRong == 0 || MouseY%Oco.ChieuCao ==0)
                return false;
       
            int Cot = MouseX / Oco.ChieuRong;
            int Dong = MouseY / Oco.ChieuCao;
            if (_MangOco[Dong, Cot].SoHuu != 0)
                return false;
            switch (_LuotDi)
            {
                case 1:
                    _MangOco[Dong, Cot].SoHuu = 1;
                    _BanCo.VeQuanCo(g, _MangOco[Dong, Cot].Vitri, sbBlack);
                    _LuotDi = 2;
                    break;
                case 2:
                    _MangOco[Dong, Cot].SoHuu = 2;
                    _BanCo.VeQuanCo(g, _MangOco[Dong, Cot].Vitri, sbWhite);
                    _LuotDi = 1;
                    break;
                default:
                    
                    break;
            }
            stkCacNuocUndo = new Stack<Oco>();
            Oco oco = new Oco(_MangOco[Dong, Cot].Dong, _MangOco[Dong, Cot].Cot, _MangOco[Dong, Cot].Vitri, _MangOco[Dong, Cot].SoHuu);
            stkCacNuocDaDi.Push(oco);
            return true;
        }

        public void VeLaiQuanCo(Graphics g)
        {
            foreach(Oco oco in stkCacNuocDaDi)
            {
                if(oco.SoHuu ==1)
                _BanCo.VeQuanCo(g, oco.Vitri, sbBlack);
                else if (oco.SoHuu == 2)
                {
                    _BanCo.VeQuanCo(g, oco.Vitri, sbWhite);

                }

            }
        }

        public void StartPlayrvsPlayer(Graphics g)
        {
            _SanSang = true;
            stkCacNuocDaDi = new Stack<Oco>();
            stkCacNuocUndo = new Stack<Oco>();
            KhoiTaoMangOCo();
            _CheDoChoi = 1;
            _LuotDi = 1;
            VeBanCo(g);
        }
        public void StartPlayervsCom(Graphics g)
        {
            _SanSang = true;
            stkCacNuocDaDi = new Stack<Oco>();
            stkCacNuocUndo = new Stack<Oco>();
            KhoiTaoMangOCo();
            _CheDoChoi = 2;
            _LuotDi = 1;
            VeBanCo(g);
            KhoiDongCom(g);
            
        }


        public void Undo(Graphics g)
        {
            if (stkCacNuocDaDi.Count != 0)
            {
                Oco oco = stkCacNuocDaDi.Pop();
                stkCacNuocUndo.Push(new Oco(oco.Dong,oco.Cot,oco.Vitri,oco.SoHuu));
                _MangOco[oco.Dong, oco.Cot].SoHuu = 0;
                _BanCo.XoaQuanCo(g, oco.Vitri, sbGreen);
                if (_LuotDi == 1)
                {
                    _LuotDi = 2;
                }else
                    _LuotDi = 1;
            }
          //  VeBanCo(g);
            //VeLaiQuanCo(g); 
        }

        public void Redo(Graphics g)
        {
            if (stkCacNuocUndo.Count != 0)
            {
                Oco oco = stkCacNuocUndo.Pop();
                stkCacNuocDaDi.Push(new Oco(oco.Dong, oco.Cot, oco.Vitri, oco.SoHuu));
                _MangOco[oco.Dong, oco.Cot].SoHuu = oco.SoHuu;
                _BanCo.VeQuanCo(g, oco.Vitri, oco.SoHuu == 1 ? sbBlack : sbWhite);
            }
            if (_LuotDi == 1)
            {
                _LuotDi = 2;
            }
            else
                _LuotDi = 1;

        }


        #region Duyệt chiến thắng
            public bool KiemTraChienThang()
        {
            if(stkCacNuocDaDi.Count ==_BanCo.SoCot * _BanCo.SoDong)
            {
                _ketthuc = KETTHUC.HoaCo;
                return true;
            }

            foreach(Oco oco in stkCacNuocDaDi) {
                if (DuyetDoc(oco.Dong, oco.Cot, oco.SoHuu) || DuyetNgang(oco.Dong, oco.Cot, oco.SoHuu) || DuyetCheoXuoi(oco.Dong, oco.Cot, oco.SoHuu) || DuyetCheoNguoc(oco.Dong, oco.Cot, oco.SoHuu))
                {
                   if(_CheDoChoi == 1)
                    {
                        _ketthuc = oco.SoHuu == 1 ? KETTHUC.player1 : KETTHUC.player2;
                        
                        return true;
                    }else
                        _ketthuc = oco.SoHuu == 1 ? KETTHUC.COM : KETTHUC.player;
                    return true;
                }
            } 
            return false;
        }
        private bool DuyetDoc(int currDong,int currCot, int currSoHuu)
        {
            if (currDong > _BanCo.SoDong - 5)
            {
                return false;
            }
            int Dem;
            for(Dem = 1; Dem < 5; Dem++)
            {
                if(_MangOco[currDong+Dem, currCot].SoHuu != currSoHuu)
                {
                    return false;
                }
                

            }
            
            if (currDong == 0 || currDong + Dem == _BanCo.SoDong) { return true; }
            if (_MangOco[currDong - 1, currCot].SoHuu == 0 || _MangOco[currDong+Dem ,currCot].SoHuu==0) { return true; }
            return false;
        }


        private bool DuyetNgang(int currDong, int currCot, int currSoHuu)
        {
            if (currCot > _BanCo.SoCot - 5)
            {
                return false;
            }
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOco[currDong, currCot + Dem].SoHuu != currSoHuu)
                {
                    return false;
                }


            }

            if (currCot == 0 || currCot + Dem == _BanCo.SoCot) { return true; }
            if (_MangOco[currDong, currCot - 1].SoHuu == 0 || _MangOco[currDong , currCot + Dem].SoHuu == 0) { return true; }
            return false;
        }


        private bool DuyetCheoXuoi(int currDong, int currCot, int currSoHuu)
        {
            if (currDong > _BanCo.SoDong - 5 || currCot >_BanCo.SoCot -5)
            {
                return false;
            }
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOco[currDong+Dem, currCot + Dem].SoHuu != currSoHuu)
                {
                    return false;
                }


            }

            if (currDong==0 || currDong+Dem == _BanCo.SoDong|| currCot == 0 || currCot + Dem == _BanCo.SoDong) { return true; }
            if (_MangOco[currDong -1, currCot - 1].SoHuu == 0 || _MangOco[currDong + Dem, currCot + Dem].SoHuu == 0) { return true; }
            return false;
        }



        private bool DuyetCheoNguoc(int currDong, int currCot, int currSoHuu)
        {
            if (currDong<4 || currCot > _BanCo.SoCot - 5)
            {
                return false;
            }
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOco[currDong - Dem, currCot + Dem].SoHuu != currSoHuu)
                {
                    return false;
                }


            }

            if (currDong ==4 || currDong == _BanCo.SoDong -1 || currCot==0 || currCot+Dem == _BanCo.SoCot) { return true; }
            if (_MangOco[currDong + 1, currCot - 1].SoHuu == 0 || _MangOco[currDong- Dem, currCot + Dem].SoHuu == 0) { return true; }
            return false;
        }

        #endregion

        #region Kết thúc trò chơi
        public void KetThucTroChoi()
        {
            switch (_ketthuc)
            {
                case KETTHUC.HoaCo:
                    MessageBox.Show("Hòa !","Thông Báo");
                    break;
                case KETTHUC.player1:
                    MessageBox.Show("Người chơi 1 thắng !", "Thông Báo");
                    break;
                case KETTHUC.player2:
                    MessageBox.Show("Người chơi 2 thắng !", "Thông Báo");
                    break;
                case KETTHUC.COM:
                    MessageBox.Show("Máy thắng !", "Thông Báo");
                    break;
                case KETTHUC.player:
                    MessageBox.Show("Bạn thắng !", "Thông Báo");
                    break;
            }
            _SanSang = false;
        }
        #endregion

        #region AI
        private long[] MangDiemTanCong = new long[7] {0,3,24,192,1536,12288,98304};
        private long[] MangDiemPhongNgu = new long[7] { 0,1,9, 81, 729, 6561,59049 };
        public void KhoiDongCom(Graphics g)
        {
            if (stkCacNuocDaDi.Count == 0)
            {
                DanhCo(_BanCo.SoDong / 2 * Oco.ChieuCao + 1, _BanCo.SoCot / 2 * Oco.ChieuRong + 1, g);
            }else
            {
                Oco oco = TimKiemNuocDi();
                DanhCo(oco.Vitri.X + 1, oco.Vitri.Y + 1, g);
            }
        } 
        public Oco TimKiemNuocDi()
        {
            Oco ocoResult = new Oco();
            long DiemMax = 0;
            for(int i =0; i < _BanCo.SoDong; i++)
            {
                for(int j =0; j< _BanCo.SoCot; j++)
                {
                    if (_MangOco[i, j].SoHuu == 0)
                    {
                        long DiemTanCong = DiemTC_DuyetDoc(i,j) + DiemTC_DuyetNgang(i, j) + DiemTC_DuyetCheoXuoi(i, j) + DiemTC_DuyetCheoNguoc(i, j);
                        long DiemPhongNgu = DiemPN_DuyetDoc(i, j) + DiemPN_DuyetNgang(i, j) + DiemPN_DuyetCheoXuoi(i, j) + DiemPN_DuyetCheoNguoc(i, j);
                        long DiemTam = DiemTanCong > DiemPhongNgu ? DiemTanCong : DiemPhongNgu;
                        if (DiemMax < DiemTam)
                        {
                            DiemMax = DiemTam;
                            ocoResult = new Oco(_MangOco[i, j].Dong, _MangOco[i, j].Cot, _MangOco[i, j].Vitri, _MangOco[i, j].SoHuu);
                        }
                    }
                }
            }
            return ocoResult;
        }

        #region Diem TC
        private long DiemTC_DuyetDoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for(int dem = 1; dem >6 && currDong+dem < _BanCo.SoDong;dem++) // duyet xuoi
            {
                if (_MangOco[currDong + dem, currCot].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                }
                else if (_MangOco[currDong + dem, currCot].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                    break;
                }
                else // o trong
                    break;
            }

            for (int dem = 1; dem < 6 && currDong - dem >=0 ; dem++) // duyet nguoc , lui lai
            {
                if (_MangOco[currDong - dem, currCot].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                }
                else if (_MangOco[currDong - dem, currCot].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                    break;
                }
                else // o trong
                    break;
            }

            if(SoQuanDich == 2) { return 0; } // bị chặn 2 đầu
            DiemTong -= MangDiemPhongNgu[SoQuanDich +1];
            DiemTong += MangDiemTanCong[SoQuanTa];

            return DiemTong;
        }
        private long DiemTC_DuyetNgang(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem > 6 && currCot + dem < _BanCo.SoCot; dem++) // duyet xuoi
            {
                if (_MangOco[currDong , currCot + dem].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                }
                else if (_MangOco[currDong, currCot + dem].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                    break;
                }
                else // o trong
                    break;
            }

            for (int dem = 1; dem < 6 && currCot - dem >= 0; dem++) // duyet nguoc , lui lai
            {
                if (_MangOco[currDong, currCot - dem].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                }
                else if (_MangOco[currDong , currCot - dem].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                    break;
                }
                else // o trong
                    break;
            }

            if (SoQuanDich == 2) { return 0; } // bị chặn 2 đầu
            DiemTong -= MangDiemPhongNgu[SoQuanDich + 1];
            DiemTong += MangDiemTanCong[SoQuanTa];

            return DiemTong;
        }
        private long DiemTC_DuyetCheoNguoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && currCot + dem < _BanCo.SoCot && currDong-dem >=0; dem++) // duyet xuoi
            {
                if (_MangOco[currDong -dem, currCot + dem].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                }
                else if (_MangOco[currDong-dem , currCot + dem].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                    break;
                }
                else // o trong
                    break;
            }

            for (int dem = 1; dem < 6 && currDong - dem >= 0 && currDong+dem <_BanCo.SoDong; dem++) // duyet nguoc , lui lai
            {
                if (_MangOco[currDong + dem, currCot].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                }
                else if (_MangOco[currDong + dem, currCot].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                    break;
                }
                else // o trong
                    break;
            }

            if (SoQuanDich == 2) { return 0; } // bị chặn 2 đầu
            DiemTong -= MangDiemPhongNgu[SoQuanDich + 1];
            DiemTong += MangDiemTanCong[SoQuanTa];

            return DiemTong;
        }
        private long DiemTC_DuyetCheoXuoi(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && currCot + dem < _BanCo.SoCot && currDong + dem < _BanCo.SoDong; dem++) // duyet xuoi
            {
                if (_MangOco[currDong + dem, currCot + dem].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                }
                else if (_MangOco[currDong + dem, currCot + dem].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                    break;
                }
                else // o trong
                    break;
            }

            for (int dem = 1; dem < 6 && currDong - dem >= 0 && currDong - dem >=0; dem++) // duyet nguoc , lui lai
            {
                if (_MangOco[currDong - dem, currCot].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                }
                else if (_MangOco[currDong - dem, currCot].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                    break;
                }
                else // o trong
                    break;
            }

            if (SoQuanDich == 2) { return 0; } // bị chặn 2 đầu
            DiemTong -= MangDiemPhongNgu[SoQuanDich + 1];
            DiemTong += MangDiemTanCong[SoQuanTa];

            return DiemTong;
        }
        #endregion


        private long DiemPN_DuyetDoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem > 6 && currDong + dem < _BanCo.SoDong; dem++) // duyet xuoi
            {
                if (_MangOco[currDong + dem, currCot].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOco[currDong + dem, currCot].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                
                }
                else // o trong
                    break;
            }

            for (int dem = 1; dem < 6 && currDong - dem >= 0; dem++) // duyet nguoc , lui lai
            {
                if (_MangOco[currDong - dem, currCot].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOco[currDong - dem, currCot].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                  
                }
                else // o trong
                    break;
            }

            if (SoQuanTa == 2) { return 0; } // chặn 2 đầu kẻ địch
           
            DiemTong += MangDiemPhongNgu[SoQuanDich];

            return DiemTong;
        }
        private long DiemPN_DuyetNgang(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem > 6 && currCot + dem < _BanCo.SoCot; dem++) // duyet xuoi
            {
                if (_MangOco[currDong, currCot + dem].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOco[currDong, currCot + dem].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                   
                }
                else // o trong
                    break;
            }

            for (int dem = 1; dem < 6 && currCot - dem >= 0; dem++) // duyet nguoc , lui lai
            {
                if (_MangOco[currDong, currCot - dem].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOco[currDong, currCot - dem].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
         
                }
                else // o trong
                    break;
            }

            if (SoQuanTa == 2) { return 0; } // bị chặn 2 đầu
           
            DiemTong += MangDiemPhongNgu[SoQuanDich];

            return DiemTong;
        }
        private long DiemPN_DuyetCheoNguoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && currCot + dem < _BanCo.SoCot && currDong - dem >= 0; dem++) // duyet xuoi
            {
                if (_MangOco[currDong - dem, currCot + dem].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOco[currDong - dem, currCot + dem].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
           
                }
                else // o trong
                    break;
            }

            for (int dem = 1; dem < 6 && currDong - dem >= 0 && currDong + dem < _BanCo.SoDong; dem++) // duyet nguoc , lui lai
            {
                if (_MangOco[currDong + dem, currCot].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOco[currDong + dem, currCot].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
                 
                }
                else // o trong
                    break;
            }

            if (SoQuanTa == 2) { return 0; } // chặn 2 đầu địch
    
            DiemTong += MangDiemPhongNgu[SoQuanDich];

            return DiemTong;
        }
        private long DiemPN_DuyetCheoXuoi(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && currCot + dem < _BanCo.SoCot && currDong + dem < _BanCo.SoDong; dem++) // duyet xuoi
            {
                if (_MangOco[currDong + dem, currCot + dem].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOco[currDong + dem, currCot + dem].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
         
                }
                else // o trong
                    break;
            }

            for (int dem = 1; dem < 6 && currDong - dem >= 0 && currDong - dem >= 0; dem++) // duyet nguoc , lui lai
            {
                if (_MangOco[currDong - dem, currCot].SoHuu == 1) // dem so quan ta
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOco[currDong - dem, currCot].SoHuu == 2) //dem so quan dich
                {
                    SoQuanDich++;
               
                }
                else // o trong
                    break;
            }

            if (SoQuanDich == 2) { return 0; } // bị chặn 2 đầu
       
            DiemTong += MangDiemPhongNgu[SoQuanDich];

            return DiemTong;
        }
        #endregion
    }
}
