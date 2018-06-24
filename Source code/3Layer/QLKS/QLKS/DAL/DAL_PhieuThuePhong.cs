using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLKS.DTO;
namespace QLKS.DAL
{
    class DAL_PhieuThuePhong
    {
        public DAL_PhieuThuePhong()
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
        public DataTable FindPhieuThue()
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
        public bool UpdateRoom(string MaPNG)
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("update PHONG set TINH_TRANG='" + 1 + "' where MAPNG='" + MaPNG + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
            
        }

        public bool UpdateKH(DTO_PhieuThuePhong PTP)
        {
            SqlCommand sqlCommandPT = new SqlCommand("insert into PHIEUTHUE values (@maphieu,@ngaythue,@makh,@mapng,@soluong,@loaikh,@thanhtoan)", sqlConnection);
            sqlCommandPT.Parameters.AddWithValue("@maphieu", PTP.MaPhieu);
            sqlCommandPT.Parameters.AddWithValue("@ngaythue", PTP.NgayThue);
            sqlCommandPT.Parameters.AddWithValue("@makh", PTP.MaKH);
            sqlCommandPT.Parameters.AddWithValue("@mapng", PTP.MaPNG);
            sqlCommandPT.Parameters.AddWithValue("@soluong", PTP.SoLuong);
            sqlCommandPT.Parameters.AddWithValue("@loaikh",PTP.LoaiKH);
            sqlCommandPT.Parameters.AddWithValue("@thanhtoan",PTP.ThanhToan);
            sqlCommandPT.ExecuteNonQuery();
            return true;
        }
        public bool InsertKH(DTO_PhieuThuePhong PTP)
        {
            SqlCommand cmdKH = new SqlCommand("insert into KHACHHANG values ('" + PTP.MaPNG + "',N'" + PTP.HoTen + "', N'" + PTP.LoaiKH + "','" + PTP.CMND + "', N'" + PTP.DiaChi + "' )", sqlConnection);
            cmdKH.ExecuteNonQuery();
            return true;
        }
    }
}
