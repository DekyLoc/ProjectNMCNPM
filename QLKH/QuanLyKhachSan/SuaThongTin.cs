using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class SuaThongTin : Form
    {
        public SuaThongTin()
        {
            InitializeComponent();
            LoadData();
            LoadMaKH();
        }

        void LoadData()
        {
            cmbPhong.Text = QuanLyKhachSan.Container.newKhachHang.Phong;
            txtMaKH.Text = QuanLyKhachSan.Container.newKhachHang.MaKhachHang;
            txtTenKH.Text = QuanLyKhachSan.Container.newKhachHang.TenKhachHang;
            cmbLoaiKhach.Text = QuanLyKhachSan.Container.newKhachHang.LoaiKhach;
            txtCMND.Text = QuanLyKhachSan.Container.newKhachHang.CMND.ToString();
            txtDiaChi.Text = QuanLyKhachSan.Container.newKhachHang.DiaChi;
        }

        void LoadMaKH()
        {
            Binding _DataBinding = new Binding("Text", txtCMND, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMaKH.DataBindings.Add(_DataBinding);
        }

        bool CheckCMND()
        {
            int temp = 0;
            foreach (char i in txtCMND.Text.ToCharArray())
            {
                if (i < 48 || i > 57)
                {
                    temp++;
                }
            }
            if (temp == 0)
                return false;
            else
                return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            string loaiKH = cmbLoaiKhach.Text;
            string diaChi = txtDiaChi.Text;

            if (string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }

            while (CheckCMND())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMND.Focus();
                return;
            }

            KhachHang NewKhachHang = new KhachHang(cmbPhong.Text, maKH, tenKH, loaiKH, txtCMND.Text, diaChi);
            QuanLyKhachSan.Container.newKhachHang = NewKhachHang;
            MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
        
    }
}
