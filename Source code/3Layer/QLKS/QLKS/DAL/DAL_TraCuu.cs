using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLKS.DTO;

namespace QLKS.DAL
{
    class DAL_TraCuu
    {
        public DAL_TraCuu()
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
        public DataTable FindRoom()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHONG", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable FindPhieuThue()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHIEUTHUE", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable FindHoaDon()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from HOADON", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable FindBC()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from BAOCAO", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        
        
    }
}
