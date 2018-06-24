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
using QLKS.BUS;
using QLKS.DTO;

namespace QLKS.GUI
{
    public partial class GUI_BaoCaoThang : Form
    {
         #region Hàm khởi tạo, các biến và event.



        public GUI_BaoCaoThang()
        {
            InitializeComponent();
            BCT_BUS = new BUS_BaoCaoThang();
            BCT_DTO= new DTO_BaoCaoThang();
            txtMaBaoCao.Text = RandomMaBC().ToString();
        }

        // Event quay lại menu.
        public event EventHandler ReturnMenu;

        // Quay lại menu hoặc thoát chương trình.
        public bool isExit = true;

        // Ngày thanh toán.
        public string endingDate;
        public DateTime datetimeEndingDate;

        // Ngày thuê phòng.
        public string beginningDate;
        
        // Doanh thu của từng loại phòng.
        public double sales = 0;

        // Doanh thu tổng của tháng.
        public double totalSales = 0;

        // Tỷ lệ doanh thu.
        public double percentage = 0;

        // Tạo một đối tượng chứa doanh thu từng loại phòng.
        private DTO_DoanhThu newDoanhThu;
        private DTO_BaoCaoThang BCT_DTO;
        private BUS_BaoCaoThang BCT_BUS;
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

        private void BaoCao_FormClosed(object sender, FormClosedEventArgs e)
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

        #region Load dữ liệu

        // Xuất mã báo cáo ngẫu nhiên.
        int RandomMaBC()
        {
            Random randomNumber = new Random();
            var listMaBC = new List<int>();
            var maBC = randomNumber.Next(10000, 99999);
            DataTable dataTable = new DataTable();
            dataTable = BCT_BUS.FindBC();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                listMaBC.Add(Int32.Parse(dataTable.Rows[i][0].ToString()));
            }
            while (listMaBC.Count < 100000)
            { //Nếu list chưa đủ 8 phần tử
                while (listMaBC.Contains(maBC))
                { //Kiểm tra xem nếu phần tử này đã có trong list
                    maBC = randomNumber.Next(10000, 99999); //Nếu có trong list thì lại random ra 1 số khác
                }
                listMaBC.Add(maBC); //Khi đã random được ra 1 số chưa có trong list thì add nó vào list
                break;
            }
            return maBC;
        }
        #endregion

        #region Xử lí các hàm trong các sự kiện click button.

        // Load dữ liệu cần lập báo cáo của tháng được chọn.
        void LoadBaoCao()
        {
            DataTable dataTable = new DataTable();
            dataTable = BCT_BUS.FindBC();
            if (dataTable.Rows.Count == 0)
                return;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][2].ToString() == cmbThang.Text)
                {
                    ListViewItem item = new ListViewItem(dataTable.Rows[i][1].ToString());
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QLKS.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][3].ToString())) });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][4].ToString() });
                    lsvBaoCao.Items.Add(item);
                }
            }
            if (lsvBaoCao.Items.Count != 0)
            {
                MessageBox.Show("Tháng " + cmbThang.Text + "đã được lập báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLuuDoanhThu.Enabled = false;
                btnLuu.Enabled = false;
            }
        }        

        // Xoá dữ liệu đang có trong listview báo cáo.
        void ClearListViewBC()
        {
            if (lsvBaoCao.Items.Count == 0)
                return;
            foreach (ListViewItem item in lsvBaoCao.Items)
            {
                if (item == null)
                    return;
                lsvBaoCao.Items.Remove(item);
            }
        }

        // Xoá dữ liệu đang có trong listview doanh thu.
        void ClearListViewDT()
        {
            txtDoanhThu.Clear();
            if (lsvDoanhThu.Items.Count == 0)
                return;
            foreach (ListViewItem item in lsvDoanhThu.Items)
            {
                if (item == null)
                    return;
                lsvDoanhThu.Items.Remove(item);
            }
        }

        // Tính tổng doanh thu tháng.
        void CalculateSales()
        {
            DataTable dataTablePT = new DataTable();
            dataTablePT = BCT_BUS.FindPTP();
            DataTable dataTableHD = new DataTable();
            dataTableHD = BCT_BUS.FindHD();
            for (int i = 0; i < dataTablePT.Rows.Count; i++)
            {
                if (dataTablePT.Rows[i][6].ToString() == "True")
                {
                    for (int j = 0; j < dataTableHD.Rows.Count; j++)
                    {
                        if (dataTableHD.Rows[j][1].ToString() == dataTablePT.Rows[i][0].ToString())
                        {
                            endingDate = dataTableHD.Rows[j][2].ToString();
                            datetimeEndingDate = DateTime.Parse(endingDate);
                            if (datetimeEndingDate.Month.ToString() == cmbThang.Text)
                            {
                                totalSales += Double.Parse(dataTableHD.Rows[j][5].ToString());
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Xuất dữ liệu hoá đơn trong tháng.
        void ShowDataHoaDon(string loaiphong)
        {
            bool isBreakFor = false;
            bool isDTThang = false;
            DataTable dataTablePT = new DataTable();
            dataTablePT = BCT_BUS.FindPTP();
            DataTable dataTableHD = new DataTable();
            dataTableHD = BCT_BUS.FindHD();
            DataTable dataTablePhong = new DataTable();
            dataTablePhong=BCT_BUS.FindRoom();
            if (dataTableHD.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có hoá đơn nào được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnMenu_Click(this, new EventArgs());
                return;
            }
            for (int i = 0; i < dataTablePT.Rows.Count; i++)
            {
                beginningDate = DateTime.Parse(dataTablePT.Rows[i][1].ToString()).ToString("dd/MM/yyyy");
                if (dataTablePT.Rows[i][6].ToString() == "True")
                {
                    for (int j = 0; j < dataTableHD.Rows.Count; j++)
                    {
                        if (dataTableHD.Rows[j][1].ToString() == dataTablePT.Rows[i][0].ToString())
                        {
                            endingDate = DateTime.Parse(dataTableHD.Rows[j][2].ToString()).ToString("dd/MM/yyyy");
                            datetimeEndingDate = DateTime.Parse(endingDate);
                            if (datetimeEndingDate.Month.ToString() == cmbThang.Text)
                            {
                                isDTThang = true; //Xác nhận tháng này có hóa đơn
                                for (int k = 0; k < dataTablePhong.Rows.Count; k++)
                                {
                                    if (dataTablePT.Rows[i][3].ToString() == dataTablePhong.Rows[k][0].ToString() && dataTablePhong.Rows[k][1].ToString() == loaiphong)
                                    {
                                        ListViewItem item = new ListViewItem(dataTablePhong.Rows[k][0].ToString());
                                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePhong.Rows[k][1].ToString() });
                                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = beginningDate });
                                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = endingDate });
                                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QLKS.Container.FormatMoney(Int32.Parse(dataTableHD.Rows[j][5].ToString())) });
                                        lsvDoanhThu.Items.Add(item);
                                        isBreakFor = true;
                                        break;
                                    }
                                    else if (dataTablePT.Rows[i][3].ToString() == dataTablePhong.Rows[k][0].ToString() && dataTablePhong.Rows[k][1].ToString() != loaiphong)
                                    {
                                        isBreakFor = true;
                                        break;
                                    }
                                }
                            }
                            else if (j == dataTableHD.Rows.Count - 1 && !isDTThang)
                            {
                                MessageBox.Show("Tháng " + cmbThang.Text + " chưa có hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                btnLuuDoanhThu.Enabled = false;
                                return;
                            }

                            if (isBreakFor)
                            {
                                isBreakFor = false;
                                break;
                            }
                        }
                    }
                }
            }

            foreach (ListViewItem item in lsvDoanhThu.Items)
            {
                if (item == null)
                    return;
                sales += double.Parse(QLKS.Container.FormatMoney(item.SubItems[4].Text).ToString());
            }
            txtDoanhThu.Text = sales.ToString("N0");
        }

        // Tính tỷ lệ doanh thu.
        double TakePercentage()
        {
            percentage = double.Parse(txtDoanhThu.Text) / totalSales * 100;
            return percentage;
        }

        // Xuất thông tin hoá đơn dựa trên loại phòng được chọn.
        void ShowHoaDon()
        {
            if(string.IsNullOrEmpty(cmbThang.Text))
            {
                MessageBox.Show("Vui lòng chọn tháng lập báo cáo và loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sales = 0;
            if (rbtnA.Checked == true)
            {
                ClearListViewDT();
                ShowDataHoaDon("Standard");
            }
            else if (rbtnB.Checked == true)
            {
                ClearListViewDT();
                ShowDataHoaDon("Superior");
            }
            else if (rbtnC.Checked == true)
            {
                ClearListViewDT();
                ShowDataHoaDon("Deluxe");
            }
        }

        // Lưu doanh thu.
        void SaveSales()
        {
            if (string.IsNullOrEmpty(cmbThang.Text) || (rbtnA.Checked == false && rbtnB.Checked == false && rbtnC.Checked == false))
            {
                MessageBox.Show("Vui lòng chọn tháng lập báo cáo và loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            percentage = 0;

            // Thông Báo Đã Lưu Tất Cả Và KT Text Doanh Thu

            if (DTO_DSDoanhThu.Instance.DanhSachDoanhThu.Count == 3)
            {
                MessageBox.Show("Đã lưu tất cả loại phòng. Vui lòng xuất báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }            

            // Lưu Item Vào Object DoanhThu 

            if (lsvDoanhThu.Items.Count != 0)
            {
                foreach (ListViewItem item in lsvDoanhThu.Items)
                {
                    if (item == null)
                        return;
                    newDoanhThu = new DTO_DoanhThu(item.SubItems[1].Text, txtDoanhThu.Text, TakePercentage().ToString("N2") + "%");
                    break;
                }
            }
            else
            {
                if (rbtnA.Checked == true)
                {
                    newDoanhThu = new DTO_DoanhThu("Standard", txtDoanhThu.Text, percentage.ToString("N2") + "%");
                }
                else if (rbtnB.Checked == true)
                {
                    newDoanhThu = new DTO_DoanhThu("Superior", txtDoanhThu.Text, percentage.ToString("N2") + "%");
                }
                else if (rbtnC.Checked == true)
                {
                    newDoanhThu = new DTO_DoanhThu("Deluxe", txtDoanhThu.Text, percentage.ToString("N2") + "%");
                }
            }
            

            // Lưu Oject DoanhThu Vào DSDoanhThu

            if (DTO_DSDoanhThu.Instance.DanhSachDoanhThu.Count == 0)
            {
                DTO_DSDoanhThu.Instance.DanhSachDoanhThu.Add(newDoanhThu);
            }
            else
            {
                foreach (DTO_DoanhThu doanhthu1 in DTO_DSDoanhThu.Instance.DanhSachDoanhThu)
                {
                    if (doanhthu1 == null)
                        return;
                    foreach (DTO_DoanhThu doanhthu2 in DTO_DSDoanhThu.Instance.DanhSachDoanhThu)
                    {
                        if (doanhthu2 == null)
                            return;
                        if (doanhthu2.LoaiPhong == newDoanhThu.LoaiPhong)
                        {
                            MessageBox.Show("Loại phòng này đã được lưu. Vui lòng chọn phòng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    DTO_DSDoanhThu.Instance.DanhSachDoanhThu.Add(newDoanhThu);
                    return;
                }
            }
        }
        
        // Xuất báo cáo.
        void ShowBaoCao()
        {
            if (DTO_DSDoanhThu.Instance.DanhSachDoanhThu.Count != 3)
            {
                MessageBox.Show("Vui lòng lưu doanh thu tất cả loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClearListViewBC();
            foreach (DTO_DoanhThu doanhthu in DTO_DSDoanhThu.Instance.DanhSachDoanhThu)
            {
                if (doanhthu == null)
                    return;
                ListViewItem item = new ListViewItem(doanhthu.LoaiPhong);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = doanhthu.DoanhThuLoaiPhong });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = doanhthu.TyLe });
                lsvBaoCao.Items.Add(item);
            }
            DTO_DSDoanhThu.Instance.DanhSachDoanhThu.Clear();
        }

        // Lưu báo cáo.
        void SaveBaoCao()
        {
            if(lsvBaoCao.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng xuất báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BCT_BUS.Open();
            foreach (ListViewItem item in lsvBaoCao.Items)
            {
                BCT_DTO.MaBC = txtMaBaoCao.Text;
                BCT_DTO.Loai_PNG = item.Text;
                BCT_DTO.Thang = cmbThang.Text;
                BCT_DTO.DoanhThu = QLKS.Container.FormatMoney(item.SubItems[1].Text);
                BCT_DTO.TyLe = item.SubItems[2].Text;
                BCT_BUS.InsertBC(BCT_DTO);
            }
            BCT_BUS.Close();
            MessageBox.Show("Lưu báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnMenu_Click(this, new EventArgs());
        }
        #endregion

        #region Gọi các sự kiện click button.
        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLuuDoanhThu.Enabled = true;
            btnLuu.Enabled = true;
            ClearListViewDT();
            ClearListViewBC();
            rbtnA.Checked = rbtnB.Checked = rbtnC.Checked = false;
            totalSales = 0; // Trả doanh thu tổng về 0
            CalculateSales(); // Tính doanh thu tổng
            LoadBaoCao();
        }

        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnA.Checked == true)
            {
                ShowHoaDon();
            }
        }

        private void rbtnB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnB.Checked == true)
            {
                ShowHoaDon();
            }
        }

        private void rbtnC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnC.Checked == true)
            {
                ShowHoaDon();
            }
        }

        private void btnLuuDoanhThu_Click(object sender, EventArgs e)
        {
            SaveSales();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            ShowBaoCao();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveBaoCao();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ReturnMenu(this, new EventArgs());
        }
        #endregion
       
        #region Graphics
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush sBrush = new SolidBrush(Color.FromArgb(222, 152, 100));
            g.FillRectangle(sBrush, 0, 0, this.Width, 90);
        }
        #endregion
    }
}
