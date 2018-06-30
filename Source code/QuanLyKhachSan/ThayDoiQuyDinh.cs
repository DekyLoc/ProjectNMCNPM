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

namespace QuanLyKhachSan
{
    public partial class ThayDoiQuyDinh : Form
    {
       
        #region Hàm khởi tạo, các biến và event.
        // Event quay lại Menu.
        public event EventHandler ReturnMenu;

        // Quay lại menu hoặc thoát chương trình.
        public bool isExit = true;

        // Kiểm tra phòng đang trống hay kín.
        public bool isEmpty = true;
        #endregion
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
        }
        #region Đóng form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FormClose();
            }
            else
            {
                return;
            }
        }

        private void DanhSachPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClose();
        }

        // Quay lại menu hoặc thoát chương trình.
        void FormClose()
        {
            if (isExit)
            {
                isExit = false;
                Application.Exit();
            }
        }
        #endregion


        #region Xử lí các hàm khi trong các sự kiện click button.

        // tabPhong

        // Tìm các phòng và các thông tin tương ứng.
        int LoadPhong()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=" + QuanLyKhachSan.Container.severName + ";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            int money=0;
            if (cmbpng.Text == "Standard")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from GIA where MAPHONG='A'", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                money = Int32.Parse(dataTable.Rows[0][1].ToString());
            }
            else if (cmbpng.Text == "Supervior")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from GIA where MAPHONG='B'", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                money = Int32.Parse(dataTable.Rows[0][1].ToString());
            }
            else if (cmbpng.Text == "Deluxe")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from GIA where MAPHONG='C'", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                money = Int32.Parse(dataTable.Rows[0][1].ToString());
            }
            return money;
        }

        void UpdateGia()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=" + QuanLyKhachSan.Container.severName + ";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
                if (cmbpng.Text == "Standard")
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("update GIA set GIA='" + Int32.Parse(txtGiam.Text) + "'" + " where MAPHONG='A' ", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                else if (cmbpng.Text == "Supervior")
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("update GIA set GIA='" + Int32.Parse(txtGiam.Text) + "'" + "where MAPHONG='B' ", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                else if (cmbpng.Text == "Deluxe")
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("update GIA set GIA='" + Int32.Parse(txtGiam.Text) + "'" + "where MAPHONG='C' ", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thể Cập Nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Cập Nhật Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
        #endregion

        #region Gọi các sự kiện click button.
        private void cmbpng_SelectedIndexChanged(object sender, EventArgs e)
        {
            int money = LoadPhong();
            txtGiaht.Text = QuanLyKhachSan.Container.FormatMoney(money);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateGia();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            ReturnMenu(this, new EventArgs());
        }
        

        #endregion
       

    }
}
