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
    class BUS_BaoCaoThang
    {
        public BUS_BaoCaoThang()
        {
            BCT = new DAL_BaoCaoThang();
        }

        private DAL_BaoCaoThang BCT;

        public DataTable FindBC()
        {
            return BCT.FindBC();
        }
        public DataTable FindHD()
        {
            return BCT.FindHD();
        }
        public DataTable FindPTP()
        {
            return BCT.FindPTP();
        }
        public DataTable FindRoom()
        {
            return BCT.FindRoom();
        }
        public DataTable FindKH()
        {
            return BCT.FindKH();
        }
        public bool InsertBC(DTO_BaoCaoThang MaPNG)
        {
            return BCT.InsertBC(MaPNG);
        }
        public bool Open()
        {
            return BCT.Open();
        }
        public bool Close()
        {
            return BCT.Close();
        }
    }
}
