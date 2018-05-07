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
    public partial class TroGiup : Form
    {
        #region Hàm khởi tạo, các biến và event.

        // Event quay lại menu.
        public event EventHandler ReturnMenu;

        // Quay lại menu hoặc thoát chương trình.
        public bool isExit = true;
        public TroGiup()
        {
            InitializeComponent();
        }
        #endregion

        #region Đóng form
        private void TroGiup_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClose();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {   
            //Show dialog thông báo!
            DialogResult dr = MessageBox.Show("Bạn có chắc là muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FormClose();
            }
            else
            {
                return;
            }
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

        #region Graphics
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush sBrush = new SolidBrush(Color.FromArgb(109, 142, 161));
            g.FillRectangle(sBrush, 0, 0, this.Width, 90);
        }


        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ReturnMenu(this, new EventArgs());
        }
    }
}
