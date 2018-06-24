using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class GUI_Menu : Form
    {
    
        #region Hàm khởi tạo, các biến và event.

        // Quay lại menu hoặc thoát chương trình.
        public bool isExit = true;

        public GUI_Menu()
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
            GUI_DanhMucPhong frmDanhMucPhong = new GUI_DanhMucPhong();
            frmDanhMucPhong.ReturnMenu += FrmDanhMucPhong_Menu;
            frmDanhMucPhong.Show();
        }

        private void FrmDanhMucPhong_Menu(object sender, EventArgs e)
        {
            (sender as GUI_DanhMucPhong).isExit = false;
            (sender as GUI_DanhMucPhong).Close();
            this.Show();
        }
        private void btnPhieuThue_Click(object sender, EventArgs e)
        {
            QLKS.Container.isReturnMenu = true;
            this.Visible = false;
            GUI_PhieuThuePhong frmPhieuThue = new GUI_PhieuThuePhong();
            frmPhieuThue.ReturnMenu += FrmPhieuThue_Menu;
            frmPhieuThue.Show();
        }

        private void FrmPhieuThue_Menu(object sender, EventArgs e)
        {
            (sender as GUI_PhieuThuePhong).isExit = false;
            (sender as GUI_PhieuThuePhong).Close();
            this.Show();
        }


        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GUI_TraCuu frmTraCuu= new GUI_TraCuu();
            frmTraCuu.ReturnMenu += FrmbtnTraCuu_Menu;
            frmTraCuu.Show();
        }

        private void FrmbtnTraCuu_Menu(object sender, EventArgs e)
        {
            (sender as GUI_TraCuu).isExit = false;
            (sender as GUI_TraCuu).Close();
            this.Show();
        }
        //}

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GUI_HoaDonThanhToan frmHoaDon = new GUI_HoaDonThanhToan();
            frmHoaDon.ReturnMenu += FrmHoaDon_Menu;
            frmHoaDon.Show();
        }

        private void FrmHoaDon_Menu(object sender, EventArgs e)
        {
            (sender as GUI_HoaDonThanhToan).isExit = false;
            (sender as GUI_HoaDonThanhToan).Close();
            this.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GUI_BaoCaoThang frmBaoCao = new GUI_BaoCaoThang();
            frmBaoCao.ReturnMenu += FrmBaoCao_Menu;
            frmBaoCao.Show();
        }

        private void FrmBaoCao_Menu(object sender, EventArgs e)
        {
            (sender as GUI_BaoCaoThang).isExit = false;
            (sender as GUI_BaoCaoThang).Close();
            this.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GUI_TroGiup frmTroGiup = new GUI_TroGiup();
            frmTroGiup.ReturnMenu += FrmTroGiup_Menu;
            frmTroGiup.Show();
        }

        private void FrmTroGiup_Menu(object sender, EventArgs e)
        {
            (sender as GUI_TroGiup).isExit = false;
            (sender as GUI_TroGiup).Close();
            this.Show();
        }

        #endregion
    }
}
