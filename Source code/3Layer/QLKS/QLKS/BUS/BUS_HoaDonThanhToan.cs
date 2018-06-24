using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKS.DAL;
using QLKS.DTO;
namespace QLKS.BUS
{
    class BUS_HoaDonThanhToan
    {
        public BUS_HoaDonThanhToan()
        {
            HDTT = new DAL_HoaDonThanhToan();
        }

        private DAL_HoaDonThanhToan HDTT;

        public DataTable FindHD()
        {
            return HDTT.FindHD();
        }
        public DataTable FindPTP()
        {
            return HDTT.FindPTP();
        }
        public DataTable FindRoom()
        {
            return HDTT.FindRoom();
        }
        public DataTable FindKH()
        {
            return HDTT.FindKH();
        }
        public bool UpdateStatusRoom(string MaPNG)
        {
            return HDTT.UpdateStatusRoom(MaPNG);
        }
        public bool UpdateStatusPTP(string MaPTP)
        {
            return HDTT.UpdateStatusPTP(MaPTP);
        }
        public bool SaveHD(DTO_HoaDonThanhToan data)
        {
            return HDTT.SaveHD(data);
        }
        public bool Open()
        {
            return HDTT.Open();
        }
        public bool Close()
        {
            return HDTT.Close();
        }
    }
}
