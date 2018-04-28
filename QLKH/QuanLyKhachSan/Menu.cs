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
    public partial class Menu : Form
    {
        #region Hàm khởi tạo, các biến và event.

        // Quay lại menu hoặc thoát chương trình.
        public bool isExit = true;      

        public Menu()
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

        // Quay lại menu hoặc thoát chương trình.
        void FormClose()
        {
            if(isExit)
            {
                isExit = false;
                Application.Exit();
            }
        }
        #endregion      

        #region Đóng mở 6 forms
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DanhMucPhong frmDanhMucPhong = new DanhMucPhong();
            frmDanhMucPhong.ReturnMenu += FrmDanhMucPhong_Menu;
            frmDanhMucPhong.Show();
        }

        private void FrmDanhMucPhong_Menu(object sender, EventArgs e)
        {
            (sender as DanhMucPhong).isExit = false;
            (sender as DanhMucPhong).Close();
            this.Show();
        }
       
        private void btnPhieuThue_Click(object sender, EventArgs e)
        {
            QuanLyKhachSan.Container.isReturnMenu = true;
            this.Visible = false;
            PhieuThuePhong frmPhieuThue = new PhieuThuePhong();
            frmPhieuThue.ReturnMenu += FrmPhieuThue_Menu;
            frmPhieuThue.Show();
        }

        private void FrmPhieuThue_Menu(object sender, EventArgs e)
        {
            (sender as PhieuThuePhong).isExit = false;
            (sender as PhieuThuePhong).Close();
            this.Show();
        }

        private void btnDanhSachPhong_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TraCuu frmDanhSachPhong = new TraCuu();
            frmDanhSachPhong.ReturnMenu += FrmDanhSachPhong_Menu;
            frmDanhSachPhong.Show();
        }

        private void FrmDanhSachPhong_Menu(object sender, EventArgs e)
        {
            (sender as TraCuu).isExit = false;
            (sender as TraCuu).Close();
            this.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HoaDonThanhToan frmHoaDon = new HoaDonThanhToan();
            frmHoaDon.ReturnMenu += FrmHoaDon_Menu;
            frmHoaDon.Show();
        }

        private void FrmHoaDon_Menu(object sender, EventArgs e)
        {
            (sender as HoaDonThanhToan).isExit = false;
            (sender as HoaDonThanhToan).Close();
            this.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BaoCaoThang frmBaoCao = new BaoCaoThang();
            frmBaoCao.ReturnMenu += FrmBaoCao_Menu;
            frmBaoCao.Show();
        }

        private void FrmBaoCao_Menu(object sender, EventArgs e)
        {
            (sender as BaoCaoThang).isExit = false;
            (sender as BaoCaoThang).Close();
            this.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TroGiup frmTroGiup = new TroGiup();
            frmTroGiup.ReturnMenu += FrmTroGiup_Menu;
            frmTroGiup.Show();
        }

        private void FrmTroGiup_Menu(object sender, EventArgs e)
        {
            (sender as TroGiup).isExit = false;
            (sender as TroGiup).Close();
            this.Show();
        }

        #endregion


    }
}
