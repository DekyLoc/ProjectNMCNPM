using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QLKS.DAL;
using QLKS.DTO;

namespace QLKS.BUS
{
    class BUS_DanhMucPhong
    {
        public BUS_DanhMucPhong ()
        {
            DMP = new DAL_DanhMucPhong();
        }

        DAL_DanhMucPhong DMP;

        public DataTable Load()
        {
            return DMP.Load();
        }

        public bool Insert(DTO_DanhMucPhong cs)
        {
            return DMP.Insert(cs);
        }

        public bool Delete(string cs)
        {
            return DMP.Delete(cs);
        }

        public bool Update(DTO_DanhMucPhong cs)
        {
            return DMP.Update(cs);
        }
        public bool Delete_NoRequire()
        {
            return DMP.Delete_NoRequire();
        }
        public bool Open()
        {
            return DMP.Open();
        }
        public bool Close()
        {
            return DMP.Close();
        }
    }
}
