using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class Container
    {
        #region Danh sách các biến.
        // Chuyển thông tin khách hàng giữa phiếu thuê và sửa thông tin.
        public static KhachHang newKhachHang = null;

        // Lưu vị trí của newKhachHang
        public static int indexKhachHang = 0;
        
        // Quay lại menu hoặc thoát chương trình ở phiếu thuê.
        public static bool isReturnMenu = false;

        // Quay lại tra cứu hoặc quay lại menu.
        public static bool isReturnTraCuu = false;

        // Chuyển thông tin phòng thuê giữa tra cứu và phiếu thuê.
        public static string selectedPhong;

        // Lưu tên sever
        public static string severName = System.Windows.Forms.SystemInformation.ComputerName + "\\SQLEXPRESS";
        #endregion

        #region Chuyển đổi định dạng tiền.
        public static string FormatMoney(int money)
        {
            string formattedMoney = money.ToString("N0");
            return formattedMoney;
        }
        public static int FormatMoney(string money)
        {
            int formattedMoney = Int32.Parse(money.Replace(",",""));
            return formattedMoney;
        }
        #endregion
    }
}
