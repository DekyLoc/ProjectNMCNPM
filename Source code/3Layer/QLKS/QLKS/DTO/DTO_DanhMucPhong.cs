using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class DTO_DanhMucPhong
    {
        private string _MaPNG;
        private string _Loai_PNG;
        private string _Ghi_Chu;
        private string _Tinh_Trang;
        private string _Don_Gia;

        public string MaPNG
        {
            get { return _MaPNG; }
            set { _MaPNG = value; }

        }

        public string Loai_PNG
        {
            get { return _Loai_PNG; }
            set { _Loai_PNG = value; }

        }

        public string Don_Gia
        {
            get { return _Don_Gia; }
            set { _Don_Gia = value; }

        }

        public string Ghi_Chu
        {
            get { return _Ghi_Chu; }
            set { _Ghi_Chu = value; }

        }

        public string Tinh_Trang
        {
            get { return _Tinh_Trang; }
            set { _Tinh_Trang = value; }
        }
    }
}