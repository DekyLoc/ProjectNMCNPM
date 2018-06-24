using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    class DTO_PhieuThuePhong
    {
        private string _maphieu;
        private string _ngaythue;
        private string _makh;
        private string _mapng;
        private int _soluong;
        private string _loaikh;
        private string _thanhtoan;
        private string _hoten;
        private string _cmnd;
        private string _diachi;



        public string HoTen
        {
            get { return _hoten; }
            set { _hoten = value; }

        }
        public string CMND
        {
            get { return _cmnd; }
            set { _cmnd = value; }

        }
        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }

        }
        public string MaPhieu
        {
            get { return _maphieu; }
            set { _maphieu = value; }

        }

        public string NgayThue
        {
            get { return _ngaythue; }
            set { _ngaythue = value; }

        }

        public string MaKH
        {
            get { return _makh; }
            set { _makh = value; }

        }

        public string MaPNG
        {
            get { return _mapng; }
            set { _mapng = value; }

        }

        public int SoLuong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public string LoaiKH
        {
            get { return _loaikh; }
            set { _loaikh = value; }
        }
        public string ThanhToan
        {
            get { return _thanhtoan; }
            set { _thanhtoan = value; }
        }
    }
}
