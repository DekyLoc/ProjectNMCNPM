using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.DTO;

namespace QLKS.DAL
{
    public class DAL_DanhMucPhong
    {
        public DAL_DanhMucPhong()
        {
            Connect_DB();
        }

        private SqlConnection sqlConnection;

        public bool Open()
        {
            sqlConnection.Open();
            return true;
        }
        public bool Close()
        {
            sqlConnection.Close();
            return true;
        }
        void Connect_DB()
        {
             sqlConnection = new SqlConnection(@"Data Source=" + QLKS.Container.severName + ";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
        }

        public DataTable Load()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHONG", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public bool Insert(DTO_DanhMucPhong DMP)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into PHONG values ('" + DMP.MaPNG + "','" + DMP.Loai_PNG + "', '" + QLKS.Container.FormatMoney(DMP.Don_Gia).ToString() + "',N'" + DMP.Ghi_Chu + "' , '" + DMP.Tinh_Trang + "'  )", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }
        public bool Update(DTO_DanhMucPhong DMP)
        {
            SqlCommand sqlCommand = new SqlCommand("update PHONG set LOAI_PNG='" + DMP.Loai_PNG + "', DON_GIA='" + QLKS.Container.FormatMoney(DMP.Don_Gia).ToString()
                                                     + "', GHI_CHU=N'" + DMP.Ghi_Chu + "' where MAPNG='" + DMP.MaPNG + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }
        public bool Delete(string MAPNG)
        {
            SqlCommand sqlCommand = new SqlCommand("delete from PHONG where MAPNG='" + MAPNG + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }
        public bool Delete_NoRequire()
        {
            SqlCommand sqlCommand = new SqlCommand("delete from PHONG", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }
    }
}
