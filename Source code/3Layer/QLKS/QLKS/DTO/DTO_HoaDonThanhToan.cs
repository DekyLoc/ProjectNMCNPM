using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    class DTO_HoaDonThanhToan
    {
        private string _maphieu;
        private string _mahd;
        private string _ngaytra;
        private int _songaythue;
        private string _trigia;
        private int _thanhtien;
        private int _phuthu;




        public string MaPhieu
        {
            get { return _maphieu; }
            set { _maphieu = value; }

        }
        public string MaHD
        {
            get { return _mahd; }
            set { _mahd = value; }

        }
        public string NgayTra
        {
            get { return _ngaytra; }
            set { _ngaytra = value; }

        }
        public int SoNgayThue
        {
            get { return _songaythue; }
            set { _songaythue = value; }

        }

        public string TriGia
        {
            get { return _trigia; }
            set { _trigia = value; }

        }

        public int ThanhTien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }

        }

        public int PhuThu
        {
            get { return _phuthu; }
            set { _phuthu = value; }

        }
    }
}
