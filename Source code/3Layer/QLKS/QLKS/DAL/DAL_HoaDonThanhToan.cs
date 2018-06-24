using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLKS.DTO;

namespace QLKS.DAL
{
    class DAL_HoaDonThanhToan
    {
        public DAL_HoaDonThanhToan()
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
        public bool UpdateStatusRoom(string MaPNG)
        {
            SqlCommand cmdP = new SqlCommand("update PHONG set TINH_TRANG='" + 0 + "' where MAPNG='" + MaPNG + "'", sqlConnection);
            cmdP.ExecuteNonQuery();
            return true;
        }
        public bool UpdateStatusPTP(string MaPTP)
        {
            SqlCommand sqlCommandPT = new SqlCommand("update PHIEUTHUE set THANH_TOAN='" + 1 + "' where MAPHIEU='" + MaPTP + "'", sqlConnection);
            sqlCommandPT.ExecuteNonQuery();
            return true;
        }
        public bool SaveHD(DTO_HoaDonThanhToan HD)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into HOADON values (@mahd,@maphieu,@ngaytra,@songaythue,@phuthu,@thanhtien,@trigia)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@mahd", HD.MaHD);
            sqlCommand.Parameters.AddWithValue("@maphieu", HD.MaPhieu);
            sqlCommand.Parameters.AddWithValue("@ngaytra", HD.NgayTra);
            //sqlCommand.Parameters.AddWithValue("@ngaytra", DateTime.Now.ToString("dd/MM/yyyy"));
            sqlCommand.Parameters.AddWithValue("@songaythue", HD.SoNgayThue);
            sqlCommand.Parameters.AddWithValue("@phuthu", HD.PhuThu);
            sqlCommand.Parameters.AddWithValue("@thanhtien", HD.ThanhTien);
            sqlCommand.Parameters.AddWithValue("@trigia", HD.TriGia);
            sqlCommand.ExecuteNonQuery();
            return true;
        }
    }
}
