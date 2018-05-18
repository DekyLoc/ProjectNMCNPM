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
    public partial class HoaDonThanhToan : Form
    {
        #region Hàm khởi tạo, các biến và event.

        // Event quay lại menu.
        public event EventHandler ReturnMenu;

        // Quay lại menu hoặc thoát chương trình.
        public bool isExit = true;

        // Số ngày thuê phòng.
        public int hiringDays;

        // Đơn giá.
        public double unitPrice;

        // Ngày thuê phòng.
        public string beginningDate;      
        public DateTime datetimeBeginningDate;

        // Phụ thu.
        public double extraMoney;

        // Thành tiền.
        public double totalMoney;

        // Thành tiền sau khi format.
        public int formattedTotalAmount;

        // Kiểm tra nếu khách hàng đứng tên phiếu thuê chưa thanh toán (true) thì xuất thông tin KH đó.
        public bool isHiringKH = false;

        public HoaDonThanhToan()
        {
            InitializeComponent();
            txtMaHoaDon.Text = RandomMaHD().ToString();
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

        private void HoaDon_FormClosed(object sender, FormClosedEventArgs e)
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

        // Xuất mã hoá đơn ngẫu nhiên.
        int RandomMaHD()
        {
            Random randomNumber = new Random();
            var listMaHD = new List<int>();
            var maHD = randomNumber.Next(10000, 99999);
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from HOADON", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                listMaHD.Add(Int32.Parse(dataTable.Rows[i][0].ToString()));
            }
            while (listMaHD.Count < 100000)
            { //Nếu list chưa đủ 8 phần tử
                while (listMaHD.Contains(maHD))
                { //Kiểm tra xem nếu phần tử này đã có trong list
                    maHD = randomNumber.Next(10000, 99999); //Nếu có trong list thì lại random ra 1 số khác
                }
                listMaHD.Add(maHD); //Khi đã random được ra 1 số chưa có trong list thì add nó vào list
                break;
            }
            return maHD;
        }
        #endregion

        #region Xử lí các hàm trong các sự kiện click button.

        // Xoá các text box trừ MaHD.
        void ClearBox()
        {
            txtMaPhieuThue.Clear();
            txtPhong.Clear();
            foreach (var item in this.Controls)
            {
                TextBox textBox = item as TextBox;
                if (textBox != null)
                {
                    if (textBox != txtMaHoaDon)
                        textBox.Clear();
                }
            }
            txtPhong.Focus();
        }

        // Load thông tin phiếu thuê và khách thuê phòng.
        void LoadTextBox()
        {
            if (string.IsNullOrEmpty(txtPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtPhong.Focus();
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapterPT = new SqlDataAdapter("select * from PHIEUTHUE", sqlConnection);
            DataTable dataTablePT = new DataTable();
            sqlDataAdapterPT.Fill(dataTablePT);
            SqlDataAdapter sqlDataAdapterPhong = new SqlDataAdapter("select * from PHONG", sqlConnection);
            DataTable dataTablePhong = new DataTable();
            sqlDataAdapterPhong.Fill(dataTablePhong);
            for (int i = 0; i < dataTablePT.Rows.Count; i++)
            {
                if (txtPhong.Text == dataTablePT.Rows[i][3].ToString())
                {
                    for (int k = 0; k < dataTablePhong.Rows.Count; k++)
                    {
                        if (dataTablePT.Rows[i][3].ToString() == dataTablePhong.Rows[k][0].ToString())
                        {
                            if (dataTablePhong.Rows[k][4].ToString() == "True" && dataTablePT.Rows[i][6].ToString() == "False")
                            {
                                txtMaPhieuThue.Text = dataTablePT.Rows[i][0].ToString();
                                txtPhong.Text = dataTablePT.Rows[i][3].ToString();
                                SqlDataAdapter sqlDataAdapterKH = new SqlDataAdapter("select * from KHACHHANG", sqlConnection);
                                DataTable dataTableKH = new DataTable();
                                sqlDataAdapterKH.Fill(dataTableKH);
                                for (int j = 0; j < dataTableKH.Rows.Count; j++)
                                {
                                    if (dataTablePT.Rows[i][2].ToString() == dataTableKH.Rows[j][0].ToString())
                                    {
                                        txtMaKhachHang.Text = dataTableKH.Rows[j][0].ToString();
                                        txtKhachHang.Text = dataTableKH.Rows[j][1].ToString();
                                        txtDiaChi.Text = dataTableKH.Rows[j][4].ToString();
                                        isHiringKH = true;
                                        return;
                                    }
                                }
                            }
                            else if (dataTablePhong.Rows[k][4].ToString() == "False" || dataTablePhong.Rows[k][4].ToString() == "True")
                            {
                                isHiringKH = false;
                                MessageBox.Show("Phiếu thuê đã được thanh toán hoặc phòng đang trống!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtPhong.Focus();
                                ClearBox();
                                return;
                            }
                        }
                    }
                }
                else if (i == dataTablePT.Rows.Count - 1)
                {
                    isHiringKH = false;
                    MessageBox.Show("Phiếu thuê không tồn tại hoặc phòng đang trống!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhong.Focus();
                    ClearBox();
                    return;
                }
            }
        }

        // Load thông tin thuê phòng để lập hoá đơn.
        void LoadListView()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapterPT = new SqlDataAdapter("select * from PHIEUTHUE", sqlConnection);
            DataTable dataTablePT = new DataTable();
            sqlDataAdapterPT.Fill(dataTablePT);
            for (int i = 0; i < dataTablePT.Rows.Count; i++)
            {
                if (txtMaPhieuThue.Text == dataTablePT.Rows[i][0].ToString())
                {
                    ListViewItem item = new ListViewItem(dataTablePT.Rows[i][3].ToString()); //Column 1

                    SqlDataAdapter sqlDataAdapterPhong = new SqlDataAdapter("select * from PHONG", sqlConnection);
                    DataTable dataTablePhong = new DataTable();
                    sqlDataAdapterPhong.Fill(dataTablePhong);
                    for (int j = 0; j < dataTablePhong.Rows.Count; j++)
                    {
                        if (dataTablePT.Rows[i][3].ToString() == dataTablePhong.Rows[j][0].ToString())
                        {
                            unitPrice = double.Parse(dataTablePhong.Rows[j][2].ToString());
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dataTablePhong.Rows[j][1].ToString() }); //Column 2
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTablePhong.Rows[j][2].ToString())) }); //Column 3
                        }
                    }
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Parse(dataTablePT.Rows[i][1].ToString()).ToString("dd/MM/yyyy") }); //Column 4
                    beginningDate = dataTablePT.Rows[i][1].ToString();
                    datetimeBeginningDate = DateTime.Parse(beginningDate);
                    hiringDays = (DateTime.Now.Date - datetimeBeginningDate.Date).Days; // Chú ý
                    if (hiringDays == 0)
                        hiringDays = 1;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = hiringDays.ToString() }); //Column 5

                    if (dataTablePT.Rows[i][4].ToString() == "3" && dataTablePT.Rows[i][5].ToString() == "False")
                    {
                        totalMoney = hiringDays * unitPrice * 1.25;
                        extraMoney = totalMoney - (hiringDays * unitPrice);
                    }
                    else if (dataTablePT.Rows[i][4].ToString() != "3" && dataTablePT.Rows[i][5].ToString() == "True")
                    {
                        totalMoney = hiringDays * unitPrice * 1.5;
                        extraMoney = totalMoney - (hiringDays * unitPrice);
                    }
                    else if (dataTablePT.Rows[i][4].ToString() == "3" && dataTablePT.Rows[i][5].ToString() == "True")
                    {
                        totalMoney = hiringDays * unitPrice * 1.25 * 1.5;
                        extraMoney = totalMoney - (hiringDays * unitPrice);
                    }
                    else
                    {
                        totalMoney = hiringDays * unitPrice;
                        extraMoney = 0;
                    }
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(totalMoney.ToString())) }); //Column 6
                    lsvHoaDon.Items.Add(item);
                    txtTriGia.Text = QuanLyKhachSan.Container.FormatMoney(Int32.Parse(totalMoney.ToString()));
                    btnThanhToan.Enabled = true;
                }
            }
        }

        // Xuất thông tin hoá đơn.
        void ShowDataHD()
        {
            if (lsvHoaDon.Items.Count == 0)
            {
                LoadTextBox();
                if (isHiringKH)
                    LoadListView();
                else
                {
                    btnThanhToan.Enabled = false;
                    return;
                }
            }
            else
            {
                foreach (ListViewItem item in lsvHoaDon.Items)
                {
                    if (item == null)
                        return;
                    if (item.Text != txtPhong.Text)
                    {
                        lsvHoaDon.Items.Remove(item);
                        LoadTextBox();
                        if (isHiringKH)
                            LoadListView();
                        else
                        {
                            btnThanhToan.Enabled = false;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng này đang được xuất hoá đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPhong.Focus();
                        return;
                    }
                }
            }

        }

        // Thanh toán hoá đơn.
        void PayHD()
        {
            // Cập nhật tình trạng phòng
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapterPhong = new SqlDataAdapter("select * from PHONG", sqlConnection);
            DataTable dataTablePhong = new DataTable();
            sqlDataAdapterPhong.Fill(dataTablePhong);
            SqlDataAdapter sqlDataAdapterPT = new SqlDataAdapter("select * from PHIEUTHUE", sqlConnection);
            DataTable dataTablePT = new DataTable();
            sqlDataAdapterPT.Fill(dataTablePT);
            sqlConnection.Open();
            for (int i = 0; i < dataTablePhong.Rows.Count; i++)
            {
                foreach (ListViewItem item in lsvHoaDon.Items)
                {
                    if (item == null)
                        return;
                    if (item.Text == dataTablePhong.Rows[i][0].ToString())
                    {
                        SqlCommand cmdP = new SqlCommand("update PHONG set TINH_TRANG='" + 0 + "' where MAPNG='" + item.Text + "'", sqlConnection);
                        cmdP.ExecuteNonQuery();
                    }
                }
            }

            for (int j = 0; j < dataTablePT.Rows.Count; j++)
            {
                if (txtMaPhieuThue.Text == dataTablePT.Rows[j][0].ToString())
                {
                    SqlCommand sqlCommandPT = new SqlCommand("update PHIEUTHUE set THANH_TOAN='" + 1 + "' where MAPHIEU='" + txtMaPhieuThue.Text + "'", sqlConnection);
                    sqlCommandPT.ExecuteNonQuery();
                }
            }
            sqlConnection.Close();

            foreach (ListViewItem item in lsvHoaDon.Items)
            {
                if (item == null)
                    return;
                formattedTotalAmount += QuanLyKhachSan.Container.FormatMoney(item.SubItems[5].Text);
            }
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Lưu hoá đơn.
        void SaveHD()
        {
            DateTime dateTime = DateTime.Now;
            string formatDateTime = "dd-MM-yyyy";
            int tempHiringDays = 0;
            int tempTotalAmount = 0;
            foreach (ListViewItem item in lsvHoaDon.Items)
            {
                if (item == null)
                    return;
                tempHiringDays = Int32.Parse(item.SubItems[4].Text);
                tempTotalAmount = QuanLyKhachSan.Container.FormatMoney(item.SubItems[5].Text);
            }
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into HOADON values (@mahd,@maphieu,@ngaytra,@songaythue,@phuthu,@thanhtien,@trigia)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@mahd", txtMaHoaDon.Text);
            sqlCommand.Parameters.AddWithValue("@maphieu", txtMaPhieuThue.Text);
            sqlCommand.Parameters.AddWithValue("@ngaytra", dateTime.ToString(formatDateTime));
            sqlCommand.Parameters.AddWithValue("@songaythue", tempHiringDays);
            sqlCommand.Parameters.AddWithValue("@phuthu", Int32.Parse(extraMoney.ToString()));
            sqlCommand.Parameters.AddWithValue("@thanhtien", tempTotalAmount);
            sqlCommand.Parameters.AddWithValue("@trigia",'1');
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion

        #region Gọi các sự kiện click button.
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            ShowDataHD();
        }

        private void txtNhanTuKhach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int iTriGia = QuanLyKhachSan.Container.FormatMoney(txtTriGia.Text);
                int iNhanTuKhach = QuanLyKhachSan.Container.FormatMoney(txtNhanTuKhach.Text);
                int iDuaLaiKhach = QuanLyKhachSan.Container.FormatMoney(txtDuaLaiKhach.Text);
                try
                {
                    iDuaLaiKhach = iNhanTuKhach - iTriGia;
                    if (iDuaLaiKhach <= 0)
                    {
                        txtDuaLaiKhach.Text = "0";
                        return;
                    }
                    txtDuaLaiKhach.Text = iDuaLaiKhach.ToString("N0");
                }
                catch (Exception)
                {
                    txtDuaLaiKhach.Text = "0";
                }
            }
            catch
            {
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                SaveHD();
                PayHD();
                btnMenu_Click(this, new EventArgs());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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
            SolidBrush sBrush = new SolidBrush(Color.FromArgb(216, 126, 117));
            g.FillRectangle(sBrush, 0, 0, this.Width, 90);
        }

        #endregion
    }
}
