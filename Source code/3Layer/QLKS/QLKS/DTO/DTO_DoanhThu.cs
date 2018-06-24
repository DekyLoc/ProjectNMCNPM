using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    class DTO_DoanhThu
    {
        private string loaiPhong;
        private string doanhThuLoaiPhong;
        private string tyLe;

        public string LoaiPhong
        {
            get
            {
                return loaiPhong;
            }

            set
            {
                loaiPhong = value;
            }
        }

        public string DoanhThuLoaiPhong
        {
            get
            {
                return doanhThuLoaiPhong;
            }

            set
            {
                doanhThuLoaiPhong = value;
            }
        }

        public string TyLe
        {
            get
            {
                return tyLe;
            }

            set
            {
                tyLe = value;
            }
        }

        public DTO_DoanhThu(string loaiphong, string doanhthu, string tyle)
        {
            loaiPhong = loaiphong;
            doanhThuLoaiPhong = doanhthu;
            tyLe = tyle;
        }
    }
}
