using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class DSDoanhThu
    {
        private static volatile DSDoanhThu instance;
        private List<DoanhThu> listDoanhThu;

        internal static DSDoanhThu Instance
        {
            get
            {
                if (instance == null)
                    instance = new DSDoanhThu();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        internal List<DoanhThu> DanhSachDoanhThu
        {
            get
            {
                return listDoanhThu;
            }

            set
            {
                listDoanhThu = value;
            }
        }

        private DSDoanhThu()
        {
            listDoanhThu = new List<DoanhThu>();
        }
    }
}
