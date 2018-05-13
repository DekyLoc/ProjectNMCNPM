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
    public partial class Login : Form
    {
        #region Hàm khởi tạo, các biến và event.
        // Load chương trình
        public bool isExit = true;    
        public Login()
        {
            InitializeComponent();
        }
        #endregion
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

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClose();
        }
        void FormClose()
        {
            if (isExit)
            {
                isExit = false;
                Application.Exit();
            }
        }
        #endregion


        #region Đăng Nhập

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=" + QuanLyKhachSan.Container.severName + ";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapterLogin = new SqlDataAdapter("select * from DANGNHAP", sqlConnection);
            DataTable dataTablePT = new DataTable();
            sqlDataAdapterLogin.Fill(dataTablePT);
            if (txtuser.Text == dataTablePT.Rows[0][0].ToString() && txtpass.Text==dataTablePT.Rows[0][1].ToString())
            {
                    MessageBox.Show("Đăng Nhập Thành Công!");
                    this.Hide();
                    Menu frmMenu= new Menu();
                    frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Tài Khoản Mật Khẩu Sai!");
            }
           

        }

        #endregion
    }
}
