using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLKS.DAL;
using QLKS.DTO;
namespace QLKS.BUS
{
    class BUS_PhieuThuePhong
    {
        public BUS_PhieuThuePhong()
        {
            PTP = new DAL_PhieuThuePhong();
        }

        private DAL_PhieuThuePhong PTP;

        public DataTable FindPhieuThue()
        {
            return PTP.FindPhieuThue();
        }
        public DataTable FindRoom()
        {
            return PTP.FindRoom();
        }
        public DataTable FindKH()
        {
            return PTP.FindKH();
        }
        public bool UpdateRoom(string cs)
        {
            return PTP.UpdateRoom(cs);
        }
        public bool UpdateKH(DTO_PhieuThuePhong cs)
        {
            return PTP.UpdateKH(cs);
        }
        public bool InsertKH(DTO_PhieuThuePhong cs)
        {
            return PTP.InsertKH(cs);
        }
        public bool Open()
        {
            return PTP.Open();
        }
        public bool Close()
        {
            return PTP.Close();
        }
    }
}
