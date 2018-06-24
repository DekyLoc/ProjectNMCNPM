using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKS.DAL;
using QLKS.DTO;
using  System.Data;

namespace QLKS.BUS
{
    class BUS_TraCuu
    {
        public BUS_TraCuu()
        {
            TraCuu = new DAL_TraCuu();
        }

        DAL_TraCuu TraCuu;

        public bool Open()
        {
            return TraCuu.Open();
        }
        public bool Close()
        {

            return TraCuu.Open(); ;
        }
        public DataTable FindRoom()
        {
            return TraCuu.FindRoom();
        }
        public DataTable FindPhieuThue()
        {
            return TraCuu.FindPhieuThue();
        }
        public DataTable FindHoaDon()
        {
            return TraCuu.FindHoaDon();
        }
        public DataTable FindBC()
        {
            return TraCuu.FindBC();
        }
    }
}
