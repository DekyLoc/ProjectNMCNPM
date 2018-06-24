using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    class DTO_BaoCaoThang
    {
        private string _mabc;
        private string _loaiphong;
        private string _thang;
        private int _doanhthu;
        private string _tyle;

        public string MaBC
        {
            get { return _mabc; }
            set { _mabc = value; }

        }

        public string Loai_PNG
        {
            get { return _loaiphong; }
            set { _loaiphong = value; }

        }
        public string Thang
        {
            get { return _thang; }
            set { _thang = value; }

        }
        public int DoanhThu
        {
            get { return _doanhthu; }
            set { _doanhthu = value; }

        }

        public string TyLe
        {
            get { return _tyle; }
            set { _tyle = value; }

        }
    }
}
