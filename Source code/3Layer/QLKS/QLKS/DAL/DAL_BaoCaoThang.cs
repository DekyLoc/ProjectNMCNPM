using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLKS.DAL;
using QLKS.DTO;
namespace QLKS.DAL
{
    class DAL_BaoCaoThang
    {
        public DAL_BaoCaoThang()
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

        public DataTable FindBC()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from BAOCAO", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable FindHD()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from HOADON", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable FindPTP()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHIEUTHUE", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable FindRoom()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHONG", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable FindKH()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from KHACHHANG", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public bool InsertBC(DTO_BaoCaoThang BCT)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into BAOCAO values ('" + BCT.MaBC + "',N'" + BCT.Loai_PNG + "', '" + BCT.Thang + "','" + BCT.DoanhThu + "', '" + BCT.TyLe + "' )", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }
    }
}
