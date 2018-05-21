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
    public partial class TraCuu : Form
    {
        #region Hàm khởi tạo, các biến và event.
        // Event quay lại Menu.
        public event EventHandler ReturnMenu;

        // Quay lại menu hoặc thoát chương trình.
        public bool isExit = true;

        // Kiểm tra phòng đang trống hay kín.
        public bool isEmpty = true;

        public TraCuu()
        {
            InitializeComponent();
            cmbTinhTrang.SelectedIndex = 0;
            cmbLoaiPhong.SelectedIndex = 3;
            rbtnNgayThue.Checked = true;
            rbtnNgayTra.Checked = true;
            rbtnThangBaoCao.Checked = true;
            cmbNamPT.SelectedIndex = 0;
            cmbNamHD.SelectedIndex = 0;
            cmbNamBC.SelectedIndex = 0;
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
        void FindPhong() 
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHONG", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            lsvDanhSachPhong.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if((String.IsNullOrEmpty(cmbLoaiPhong.Text) || cmbLoaiPhong.Text == cmbLoaiPhong.Items[3].ToString()) && cmbTinhTrang.Text == cmbTinhTrang.Items[0].ToString())
                {
                    if(dataTable.Rows[i][4].ToString() == "False")
                    {
                        ListViewItem Item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        Item.SubItems.Add(dataTable.Rows[i][1].ToString());
                        Item.SubItems.Add(QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][2].ToString())));
                        Item.SubItems.Add("Phòng trống");
                        lsvDanhSachPhong.Items.Add(Item);
                    }
                }
                else if ((String.IsNullOrEmpty(cmbLoaiPhong.Text) || cmbLoaiPhong.Text == cmbLoaiPhong.Items[3].ToString()) && cmbTinhTrang.Text == cmbTinhTrang.Items[1].ToString())
                {
                    if (dataTable.Rows[i][4].ToString() == "True")
                    {
                        ListViewItem Item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        Item.SubItems.Add(dataTable.Rows[i][1].ToString());
                        Item.SubItems.Add(QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][2].ToString())));
                        Item.SubItems.Add("Phòng kín");
                        lsvDanhSachPhong.Items.Add(Item);
                    }
                }
                else if ((String.IsNullOrEmpty(cmbLoaiPhong.Text) || cmbLoaiPhong.Text == cmbLoaiPhong.Items[3].ToString()) && cmbTinhTrang.Text == cmbTinhTrang.Items[2].ToString())
                {
                    if (dataTable.Rows[i][4].ToString() == "True")
                    {
                        ListViewItem Item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        Item.SubItems.Add(dataTable.Rows[i][1].ToString());
                        Item.SubItems.Add(QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][2].ToString())));
                        Item.SubItems.Add("Phòng kín");
                        lsvDanhSachPhong.Items.Add(Item);
                    }
                    else if (dataTable.Rows[i][4].ToString() == "False")
                    {
                        ListViewItem Item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        Item.SubItems.Add(dataTable.Rows[i][1].ToString());
                        Item.SubItems.Add(QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][2].ToString())));
                        Item.SubItems.Add("Phòng trống");
                        lsvDanhSachPhong.Items.Add(Item);
                    }
                }
                else if (cmbLoaiPhong.Text == dataTable.Rows[i][1].ToString() && cmbTinhTrang.Text == cmbTinhTrang.Items[0].ToString())
                {
                    if (dataTable.Rows[i][4].ToString() == "False")
                    {
                        ListViewItem Item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        Item.SubItems.Add(dataTable.Rows[i][1].ToString());
                        Item.SubItems.Add(QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][2].ToString())));
                        Item.SubItems.Add("Phòng trống");
                        lsvDanhSachPhong.Items.Add(Item);
                    }
                }
                else if (cmbLoaiPhong.Text == dataTable.Rows[i][1].ToString() && cmbTinhTrang.Text == cmbTinhTrang.Items[1].ToString())
                {
                    if (dataTable.Rows[i][4].ToString() == "True")
                    {
                        ListViewItem Item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        Item.SubItems.Add(dataTable.Rows[i][1].ToString());
                        Item.SubItems.Add(QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][2].ToString())));
                        Item.SubItems.Add("Phòng kín");
                        lsvDanhSachPhong.Items.Add(Item);
                    }
                }
                else if (cmbLoaiPhong.Text == dataTable.Rows[i][1].ToString() && cmbTinhTrang.Text == cmbTinhTrang.Items[2].ToString())
                {
                    if (dataTable.Rows[i][4].ToString() == "True")
                    {
                        ListViewItem Item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        Item.SubItems.Add(dataTable.Rows[i][1].ToString());
                        Item.SubItems.Add(QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][2].ToString())));
                        Item.SubItems.Add("Phòng kín");
                        lsvDanhSachPhong.Items.Add(Item);
                    }
                    else if (dataTable.Rows[i][4].ToString() == "False")
                    {
                        ListViewItem Item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        Item.SubItems.Add(dataTable.Rows[i][1].ToString());
                        Item.SubItems.Add(QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][2].ToString())));
                        Item.SubItems.Add("Phòng trống");
                        lsvDanhSachPhong.Items.Add(Item);
                    }
                }
            }
        }

        // Thuê phòng đã chọn.
        void HirePhong() 
        {
            isEmpty = true;
            if (lsvDanhSachPhong.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng tìm và chọn phòng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            QuanLyKhachSan.Container.isReturnTraCuu = true;

            if (lsvDanhSachPhong.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ChoosePhongToHire();
            if(isEmpty)
            {
                this.Visible = false;
                PhieuThuePhong frmPhieuThue = new PhieuThuePhong();
                frmPhieuThue.ReturnTraCuu += FrmPhieuThue_TraCuu;
                frmPhieuThue.Show();
                return;
            }
            MessageBox.Show("Phòng đang được thuê. Vui lòng chọn phòng khác!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        // Chọn phòng để thuê.
        void ChoosePhongToHire()
        {
            ListViewItem selectedItem = lsvDanhSachPhong.SelectedItems[0];
            if (selectedItem == null)
                return;
            if (selectedItem.SubItems[3].Text == "Phòng kín")
            {
                isEmpty = false;
                return;
            }
            QuanLyKhachSan.Container.selectedPhong = selectedItem.Text;
        }

        // tabPhieuThue

        // Tìm phiếu thuê và các thông tin tương ứng.
        void FindPhieuThue()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHIEUTHUE", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            lsvDanhSachPhieuThue.Items.Clear();
            if (rbtnNgayThue.Checked == true)
            {
                if (cmbNamPT.Text != "2018")
                {
                    MessageBox.Show("Hệ thống không tìm thấy phiếu thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime datetimeNgayThue;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    datetimeNgayThue = DateTime.Parse(dataTable.Rows[i][1].ToString());
                    if (datetimeNgayThue.Day.ToString() == cmbNgayPT.Text && string.IsNullOrEmpty(cmbThangPT.Text))
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTable.Rows[i][1].ToString()).ToString("dd/MM/yyyy") });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][2].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][3].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][4].ToString() });
                        if(dataTable.Rows[i][5].ToString() == "True")
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text =  "Có"});
                        else
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Không" });
                        lsvDanhSachPhieuThue.Items.Add(item);
                    }
                    else if ((string.IsNullOrEmpty(cmbNgayPT.Text) || cmbNgayPT.Text == "--") && datetimeNgayThue.Month.ToString() == cmbThangPT.Text)
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTable.Rows[i][1].ToString()).ToString("dd/MM/yyyy") });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][2].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][3].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][4].ToString() });
                        if (dataTable.Rows[i][5].ToString() == "True")
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Có" });
                        else
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Không" });
                        lsvDanhSachPhieuThue.Items.Add(item);
                    }
                    else if (datetimeNgayThue.Day.ToString() == cmbNgayPT.Text && datetimeNgayThue.Month.ToString() == cmbThangPT.Text)
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTable.Rows[i][1].ToString()).ToString("dd/MM/yyyy") });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][2].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][3].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][4].ToString() });
                        if (dataTable.Rows[i][5].ToString() == "True")
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Có" });
                        else
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Không" });
                        lsvDanhSachPhieuThue.Items.Add(item);
                    }
                    else if ((string.IsNullOrEmpty(cmbNgayPT.Text) || cmbNgayPT.Text == "--") && string.IsNullOrEmpty(cmbThangPT.Text))
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTable.Rows[i][1].ToString()).ToString("dd/MM/yyyy") });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][2].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][3].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][4].ToString() });
                        if (dataTable.Rows[i][5].ToString() == "True")
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Có" });
                        else
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Không" });
                        lsvDanhSachPhieuThue.Items.Add(item);
                    }
                }
                if (lsvDanhSachPhieuThue.Items.Count == 0)
                    MessageBox.Show("Hệ thống không tìm thấy phiếu thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rbtnMaPhieuThue.Checked == true)
            {
                if (string.IsNullOrEmpty(txtMaPhieuThue.Text))
                {
                    MessageBox.Show("Vui lòng nhập chính xác mã phiếu thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhieuThue.Focus();
                    return;
                }
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (txtMaPhieuThue.Text == dataTable.Rows[i][0].ToString())
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTable.Rows[i][1].ToString()).ToString("dd/MM/yyyy") });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][2].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][3].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][4].ToString() });
                        if (dataTable.Rows[i][5].ToString() == "True")
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Có" });
                        else
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Không" });
                        lsvDanhSachPhieuThue.Items.Add(item);
                    }
                }
                if (lsvDanhSachPhieuThue.Items.Count == 0)
                {
                    MessageBox.Show("Mã phiếu thuê không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhieuThue.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày thuê hoặc mã phiếu thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // tabHoaDon

        // Tìm hoá đơn và các thông tin tương ứng.
        void FindHoaDon()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapterHD = new SqlDataAdapter("select * from HOADON", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapterHD.Fill(dataTable);
            SqlDataAdapter sqlDataAdapterPT = new SqlDataAdapter("select * from PHIEUTHUE", sqlConnection);
            DataTable dataTablePT = new DataTable();
            sqlDataAdapterPT.Fill(dataTablePT);
            lsvDanhSachHoaDon.Items.Clear();
            if (rbtnNgayTra.Checked == true)
            {
                if (cmbNamHD.Text != "2018")
                {
                    MessageBox.Show("Hệ thống không tìm thấy hoá đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime datetimeNgayTra;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    datetimeNgayTra = DateTime.Parse(dataTable.Rows[i][2].ToString());
                    if (datetimeNgayTra.Day.ToString() == cmbNgayHD.Text && string.IsNullOrEmpty(cmbThangHD.Text))
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTable.Rows[i][2].ToString()).ToString("dd/MM/yyyy") });
                        for (int j = 0; j < dataTablePT.Rows.Count; j++)
                        {
                            if (dataTable.Rows[i][1].ToString() == dataTablePT.Rows[j][0].ToString())
                            {
                                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePT.Rows[j][2].ToString() });
                                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePT.Rows[j][3].ToString() });
                                break;
                            }
                        }
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][5].ToString())) });
                        lsvDanhSachHoaDon.Items.Add(item);
                    }
                    else if ((string.IsNullOrEmpty(cmbNgayHD.Text) || cmbNgayHD.Text == "--") && datetimeNgayTra.Month.ToString() == cmbThangHD.Text)
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTable.Rows[i][2].ToString()).ToString("dd/MM/yyyy") });
                        for (int j = 0; j < dataTablePT.Rows.Count; j++)
                        {
                            if (dataTable.Rows[i][1].ToString() == dataTablePT.Rows[j][0].ToString())
                            {
                                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePT.Rows[j][2].ToString() });
                                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePT.Rows[j][3].ToString() });
                                break;
                            }
                        }
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][5].ToString())) });
                        lsvDanhSachHoaDon.Items.Add(item);
                    }
                    else if (datetimeNgayTra.Day.ToString() == cmbNgayHD.Text && datetimeNgayTra.Month.ToString() == cmbThangHD.Text)
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTable.Rows[i][2].ToString()).ToString("dd/MM/yyyy") });
                        for (int j = 0; j < dataTablePT.Rows.Count; j++)
                        {
                            if (dataTable.Rows[i][1].ToString() == dataTablePT.Rows[j][0].ToString())
                            {
                                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePT.Rows[j][2].ToString() });
                                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePT.Rows[j][3].ToString() });
                                break;
                            }
                        }
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][5].ToString())) });
                        lsvDanhSachHoaDon.Items.Add(item);
                    }
                    else if ((string.IsNullOrEmpty(cmbNgayHD.Text) || cmbNgayHD.Text == "--") && string.IsNullOrEmpty(cmbThangHD.Text))
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTable.Rows[i][2].ToString()).ToString("dd/MM/yyyy") });
                        for (int j = 0; j < dataTablePT.Rows.Count; j++)
                        {
                            if (dataTable.Rows[i][1].ToString() == dataTablePT.Rows[j][0].ToString())
                            {
                                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePT.Rows[j][2].ToString() });
                                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePT.Rows[j][3].ToString() });
                                break;
                            }
                        }
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][5].ToString())) });
                        lsvDanhSachHoaDon.Items.Add(item);
                    }
                }
                if (lsvDanhSachHoaDon.Items.Count == 0)
                    MessageBox.Show("Hệ thống không tìm thấy hoá đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rbtnMaHoaDon.Checked == true)
            {
                if (string.IsNullOrEmpty(txtMaHoaDon.Text))
                {
                    MessageBox.Show("Vui lòng nhập chính xác mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHoaDon.Focus();
                    return;
                }
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (txtMaHoaDon.Text == dataTable.Rows[i][0].ToString())
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTable.Rows[i][2].ToString()).ToString("dd/MM/yyyy") });
                        for (int j = 0; j < dataTablePT.Rows.Count; j++)
                        {
                            if (dataTable.Rows[i][1].ToString() == dataTablePT.Rows[j][0].ToString())
                            {
                                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePT.Rows[j][2].ToString() });
                                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePT.Rows[j][3].ToString() });
                                break;
                            }
                        }
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][5].ToString())) });
                        lsvDanhSachHoaDon.Items.Add(item);
                    }
                }
                if (lsvDanhSachHoaDon.Items.Count == 0)
                {
                    MessageBox.Show("Mã hóa đơn không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHoaDon.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày thanh toán hoặc mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // tabBaoCao

        // Tìm báo cáo và các thông tin tương ứng.
        void FindBaoCao()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from BAOCAO", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            lsvDanhSachBaoCao.Items.Clear();
            txtTongDoanhThu.Clear();
            double tongDoanhThu = 0;
            if (rbtnThangBaoCao.Checked == true)
            {
                if (cmbNamBC.Text != "2018")
                {
                    MessageBox.Show("Hệ thống không tìm thấy báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (cmbThangBC.Text == dataTable.Rows[i][2].ToString())
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][1].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][2].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][3].ToString())) });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][4].ToString() });
                        lsvDanhSachBaoCao.Items.Add(item);
                        tongDoanhThu += double.Parse(dataTable.Rows[i][3].ToString());
                    }
                    else if (string.IsNullOrEmpty(cmbThangBC.Text))
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][1].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][2].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][3].ToString())) });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][4].ToString() });
                        lsvDanhSachBaoCao.Items.Add(item);
                        tongDoanhThu += double.Parse(dataTable.Rows[i][3].ToString());
                    }
                }
                if (lsvDanhSachBaoCao.Items.Count == 0)
                    MessageBox.Show("Hệ thống không tìm thấy báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rbtnMaBaoCao.Checked == true)
            {
                if (string.IsNullOrEmpty(txtMaBaoCao.Text))
                {
                    MessageBox.Show("Vui lòng nhập chính xác mã báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaBaoCao.Focus();
                    return;
                }
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (txtMaBaoCao.Text == dataTable.Rows[i][0].ToString())
                    {
                        ListViewItem item = new ListViewItem(dataTable.Rows[i][0].ToString());
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][1].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][2].ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][3].ToString())) });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTable.Rows[i][4].ToString() });
                        lsvDanhSachBaoCao.Items.Add(item);
                        tongDoanhThu += double.Parse(dataTable.Rows[i][3].ToString());
                    }
                }
                if (lsvDanhSachBaoCao.Items.Count == 0)
                {
                    MessageBox.Show("Mã báo cáo không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaBaoCao.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày thuê hoặc mã phiếu thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtTongDoanhThu.Text = tongDoanhThu.ToString("N0");
        }

        #endregion

        #region Gọi các sự kiện click button.
        
        private void btnTimPhong_Click(object sender, EventArgs e)
        {
            FindPhong();
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            HirePhong();
        }

        private void FrmPhieuThue_TraCuu(object sender, EventArgs e)
        {
            (sender as PhieuThuePhong).isExit = false;
            (sender as PhieuThuePhong).Close();
            this.Show();
            btnTimPhong_Click(this, new EventArgs());
        }

        private void btnTimPhieuThue_Click(object sender, EventArgs e)
        {
            FindPhieuThue();
        }

       
        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {
            FindHoaDon();
        }

        
        private void btnTimBaoCao_Click(object sender, EventArgs e)
        {
            FindBaoCao();
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
            SolidBrush sBrush = new SolidBrush(Color.FromArgb(134, 161, 130));
            g.FillRectangle(sBrush, 0, 0, this.Width, 90);
        }


        #endregion

    }
}
