using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    class DTO_DSDoanhThu
    {
        private static volatile DTO_DSDoanhThu instance;
        private List<DTO_DoanhThu> listDoanhThu;

        internal static DTO_DSDoanhThu Instance
        {
            get
            {
                if (instance == null)
                    instance = new DTO_DSDoanhThu();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        internal List<DTO_DoanhThu> DanhSachDoanhThu
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

        private DTO_DSDoanhThu()
        {
            listDoanhThu = new List<DTO_DoanhThu>();
        }
    }
}
