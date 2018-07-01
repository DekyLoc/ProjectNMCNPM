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
    public partial class PhieuThuePhong : Form
    {
        #region Hàm khởi tạo, các biến và event.
        // Event quay lại Menu.
        public event EventHandler ReturnMenu;

        // Event quay lại tra cứu.
        public event EventHandler ReturnTraCuu;

        // Quay lại menu hoặc thoát chương trình.
        public bool isExit = true;
        
        // Kiểm tra loại khách.
        public bool isForeign = false;

        // Kiểm tra phụ thu.
        public bool isExtraMoney = false;

        // Kiểm tra nếu là khách hàng mới thì lưu xuống DB, ngược lại không lưu.
        public bool isExisted = true;

        // Kiểm tra nếu mã KH đã tồn tại thì được lập phiếu thuê, ngược lại không lập.
        public bool isMember= false; 

        public PhieuThuePhong()
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

        private void PhieuThuePhong_FormClosed(object sender, FormClosedEventArgs e)
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

        // Xuất mã phiếu thuê ngẫu nhiên.
        int RandomMaPT() 
        {
            Random randomNumber = new Random();
            var listMaPT = new List<int>();
            var maPT = randomNumber.Next(10000, 99999);
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHIEUTHUE", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                listMaPT.Add(Int32.Parse(dataTable.Rows[i][0].ToString()));
            }
            while (listMaPT.Count < 100000)
            { //Nếu list chưa đủ 8 phần tử
                while (listMaPT.Contains(maPT))
                { //Kiểm tra xem nếu phần tử này đã có trong list
                    maPT = randomNumber.Next(10000, 99999); //Nếu có trong list thì lại random ra 1 số khác
                }
                listMaPT.Add(maPT); //Khi đã random được ra 1 số chưa có trong list thì add nó vào list
                break;
            }
            return maPT;
        }

        // Load dữ liệu các phòng đang trống.
        void LoadPhong()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHONG", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][4].ToString() == "False")
                    cmbPhong.Items.Add(dataTable.Rows[i][0].ToString());
            }
            cmbPhong.SelectedIndex = 0;

            if (QuanLyKhachSan.Container.isReturnTraCuu)
            {
                cmbPhong.Text = QuanLyKhachSan.Container.selectedPhong;
                return;
            }
        }

        // Lấy MaKH là CMND
        void LoadMaKH()
        {
            Binding dataBinding = new Binding("Text", txtCMND, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMaKH.DataBindings.Add(dataBinding);
        }

        // Load dữ liệu của phiếu thuê trong trường hợp đã lập danh mục phòng, ngược lại hiện thông báo lỗi.
        private void PhieuThuePhong_Load(object sender, EventArgs e)
        {
            cmbLoaiKhach.SelectedIndex = 0;
            txtMaPhieuThue.Text = RandomMaPT().ToString();
            LoadMaKH();
            try
            {
                LoadPhong();
            }
            catch(Exception)
            {
                MessageBox.Show("Vui lòng lập danh mục phòng trước khi cho thuê phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnMenu_Click(this, new EventArgs());
            }
            
        }
        #endregion

        #region Xử lí các hàm trong các sự kiện click button.

        // Kiểm tra MaKH là các chữ số.
        bool CheckMaKH()
        {
            int temp = 0;
            foreach (char i in txtMaKhachHang.Text.ToCharArray())
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

        // Kiểm tra CMND là các chữ số.
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

        // Xoá các text box trừ MaPT và MaKH.
        void ClearBox()
        {
            foreach (var item in this.Controls)
            {
                TextBox textBox = item as TextBox;
                if (textBox != null)
                {
                    if (textBox != txtMaPhieuThue && textBox != txtMaKhachHang)
                        textBox.Clear();
                }
            }
            txtCMND.Focus();
        }

        // Xuất thông tin khách hàng nếu MaKH đã tồn tại.
        void ShowDataKH()
        {
            if (string.IsNullOrEmpty(txtCMND.Text))
            {
                MessageBox.Show("Vui lòng nhập CMND!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from KHACHHANG", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (txtCMND.Text == dataTable.Rows[i][0].ToString())
                {
                    txtTenKH.Text = dataTable.Rows[i][1].ToString();
                    cmbLoaiKhach.Text = dataTable.Rows[i][2].ToString();
                    txtDiaChi.Text = dataTable.Rows[i][4].ToString();
                    return;
                }
                if (i == dataTable.Rows.Count - 1 || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKH.Focus();
                    return;
                }
            }
        }
        // Lấy số lương tối đa của phòng
        int GetSL()
        {
            int sl = '0';
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=" + QuanLyKhachSan.Container.severName + ";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from THAYDOIQUYDINH where MAPHONG='A'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sl = Int32.Parse(dataTable.Rows[0][2].ToString());
            return sl;

        }
        // Thêm một khách hàng mới.
        void AddKhachHang(int sl)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            string loaiKH = cmbLoaiKhach.Text;
            string diaChi = txtDiaChi.Text;

            while (CheckCMND())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMND.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }

            foreach (ListViewItem item in lsvPhieuThue.Items)
            {
                if (item == null)
                    return;
                if (item.SubItems[4].Text == txtCMND.Text)
                {
                    MessageBox.Show("CMND đã bị trùng lặp. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCMND.Focus();
                    return;
                }
            }

            ListViewItem NewItem = new ListViewItem(cmbPhong.Text);
            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = maKH });
            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tenKH });
            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = loaiKH });
            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtCMND.Text });
            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = diaChi });
            lsvPhieuThue.Items.Add(NewItem);
            ClearBox();

            if (!string.IsNullOrEmpty(cmbPhong.Text))
                cmbPhong.Enabled = false;

            if (lsvPhieuThue.Items.Count == sl)
            {
                MessageBox.Show("Phòng đã nhận đủ khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnXuatThongTin.Enabled = btnThem.Enabled = txtMaKH.Enabled = txtTenKH.Enabled = txtCMND.Enabled = cmbLoaiKhach.Enabled = txtDiaChi.Enabled = false;
            }
        }

        // Xoá một khách hàng đã chọn.
        void RemoveKhachHang()
        {
            if (lsvPhieuThue.SelectedItems.Count == 0)
            {
                //Thêm dinalogBox thông báo khi xóa
                MessageBox.Show("Vui lòng chọn thông tin cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ListViewItem _SelectedItem = lsvPhieuThue.SelectedItems[0];
            if (_SelectedItem == null)
                return;
            lsvPhieuThue.Items.RemoveAt(lsvPhieuThue.SelectedIndices[0]);
            if (lsvPhieuThue.Items.Count < 3)
                btnXuatThongTin.Enabled = btnThem.Enabled = txtMaKH.Enabled = txtTenKH.Enabled = txtCMND.Enabled = cmbLoaiKhach.Enabled = txtDiaChi.Enabled = true;
            if (lsvPhieuThue.Items.Count == 0)
                cmbPhong.Enabled = true;
        }

        // Sửa thông tin khách hàng đã chọn.
        void EditDataKH()
        {
            if (lsvPhieuThue.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ListViewItem selectedItem = lsvPhieuThue.SelectedItems[0];
            if (selectedItem == null)
                return;
            KhachHang selectedKhachHang = new KhachHang(selectedItem.Text, selectedItem.SubItems[1].Text, selectedItem.SubItems[2].Text, selectedItem.SubItems[3].Text, selectedItem.SubItems[4].Text, selectedItem.SubItems[5].Text);
            QuanLyKhachSan.Container.newKhachHang = selectedKhachHang;
            QuanLyKhachSan.Container.indexKhachHang = lsvPhieuThue.SelectedIndices[0];

            SuaThongTin frmSua = new SuaThongTin();
            frmSua.FormClosed += FrmSua_FormClosed;
            frmSua.ShowDialog();

            foreach (ListViewItem item in lsvPhieuThue.Items)
            {
                if (item == null)
                    return;
                if (item != selectedItem)
                {
                    if (item.SubItems[4].Text == QuanLyKhachSan.Container.newKhachHang.CMND.ToString())
                    {
                        MessageBox.Show("CMND đã bị trùng lặp. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSua_Click(this, new EventArgs());
                        return;
                    }
                }
            }
        }

        // Đóng form sửa thông tin và quay lại form phiếu thuê.
        private void FrmSua_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (QuanLyKhachSan.Container.newKhachHang != null)
            {
                ListViewItem NewItem = lsvPhieuThue.Items[QuanLyKhachSan.Container.indexKhachHang];
                NewItem.Text = QuanLyKhachSan.Container.newKhachHang.Phong;
                NewItem.SubItems[1].Text = QuanLyKhachSan.Container.newKhachHang.MaKhachHang;
                NewItem.SubItems[2].Text = QuanLyKhachSan.Container.newKhachHang.TenKhachHang;
                NewItem.SubItems[3].Text = QuanLyKhachSan.Container.newKhachHang.LoaiKhach;
                NewItem.SubItems[4].Text = QuanLyKhachSan.Container.newKhachHang.CMND.ToString();
                NewItem.SubItems[5].Text = QuanLyKhachSan.Container.newKhachHang.DiaChi;
            }
        }

        // Cập nhật trạng thái của phòng sau khi cho thuê.
        void UpdateTinhTrangPhong()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHONG", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Open();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                foreach (ListViewItem item in lsvPhieuThue.Items)
                {
                    if (item == null)
                        return;
                    if (item.Text == dataTable.Rows[i][0].ToString())
                    {
                        SqlCommand sqlCommand = new SqlCommand("update PHONG set TINH_TRANG='" + 1 + "' where MAPNG='" + item.Text + "'", sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        return;
                    }
                }
            }
            sqlConnection.Close();
        }

        // Lưu thông tin khách hàng.
        void SaveDataKH()
        {
            //ERD
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapterKH = new SqlDataAdapter("select * from KHACHHANG", sqlConnection);
            DataTable dataTablelKH = new DataTable();
            sqlDataAdapterKH.Fill(dataTablelKH);
            sqlConnection.Open();
            foreach (ListViewItem item in lsvPhieuThue.Items)
            {
                if (item == null)
                    return;
                if (dataTablelKH.Rows.Count != 0)
                {
                    for (int i = 0; i < dataTablelKH.Rows.Count; i++)
                    {
                        isExisted = true;
                        if (item.SubItems[1].Text == dataTablelKH.Rows[i][0].ToString())
                        {
                            isExisted = false;
                            break;
                        }
                        if (isExisted && i == dataTablelKH.Rows.Count - 1)
                        {
                            SqlCommand cmdKH = new SqlCommand("insert into KHACHHANG values ('" + item.SubItems[1].Text + "',N'" + item.SubItems[2].Text + "', N'" + item.SubItems[3].Text + "','" + item.SubItems[4].Text + "', N'" + item.SubItems[5].Text + "' )", sqlConnection);
                            cmdKH.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    SqlCommand cmdKH = new SqlCommand("insert into KHACHHANG values ('" + item.SubItems[1].Text + "',N'" + item.SubItems[2].Text + "', N'" + item.SubItems[3].Text + "','" + item.SubItems[4].Text + "', N'" + item.SubItems[5].Text + "' )", sqlConnection);
                    cmdKH.ExecuteNonQuery();
                }

            }
            sqlConnection.Close();
        }

        // Kiểm tra nếu MaKH đã tồn tại.
        void CheckDataMaKH()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapterKH = new SqlDataAdapter("select * from KHACHHANG", sqlConnection);
            DataTable dataTableKH = new DataTable();
            sqlDataAdapterKH.Fill(dataTableKH);
            if (dataTableKH.Rows.Count != 0)
            {
                for (int i = 0; i < dataTableKH.Rows.Count; i++)
                {
                    if (txtMaKhachHang.Text == dataTableKH.Rows[i][0].ToString())
                    {
                        isMember = true;
                        break;
                    }
                }
            }
        }

        // Lưu thông tin phiếu thuê.
        void SaveDataPT()
        {
            //Ngày thuê phòng
            DateTime dateTime = DateTime.Now;
            string dateTimeFormat = "yyyy-MM-dd";
            foreach (ListViewItem item in lsvPhieuThue.Items)
            {
                if (item == null)
                    return;
                if (lsvPhieuThue.Items.Count == 3)
                    isExtraMoney = true;
                if (item.SubItems[3].Text == "Nước ngoài")
                    isForeign = true;
            }
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            sqlConnection.Open();
            if (isForeign)
            {
                SqlCommand sqlCommandPT = new SqlCommand("insert into PHIEUTHUE values (@maphieu,@ngaythue,@makh,@mapng,@soluong,@loaikh,@thanhtoan)", sqlConnection);
                sqlCommandPT.Parameters.AddWithValue("@maphieu", txtMaPhieuThue.Text);
                sqlCommandPT.Parameters.AddWithValue("@ngaythue", dateTime.ToString(dateTimeFormat));
                sqlCommandPT.Parameters.AddWithValue("@makh", txtMaKhachHang.Text);
                sqlCommandPT.Parameters.AddWithValue("@mapng", cmbPhong.Text);
                sqlCommandPT.Parameters.AddWithValue("@soluong", lsvPhieuThue.Items.Count);
                sqlCommandPT.Parameters.AddWithValue("@loaikh", 1);
                sqlCommandPT.Parameters.AddWithValue("@thanhtoan", 0);
                sqlCommandPT.ExecuteNonQuery();
            }
            else
            {
                SqlCommand sqlCommandPT = new SqlCommand("insert into PHIEUTHUE values (@maphieu,@ngaythue,@makh,@mapng,@soluong,@loaikh,@thanhtoan)", sqlConnection);
                sqlCommandPT.Parameters.AddWithValue("@maphieu", txtMaPhieuThue.Text);
                sqlCommandPT.Parameters.AddWithValue("@ngaythue", dateTime.ToString(dateTimeFormat));
                sqlCommandPT.Parameters.AddWithValue("@makh", txtMaKhachHang.Text);
                sqlCommandPT.Parameters.AddWithValue("@mapng", cmbPhong.Text);
                sqlCommandPT.Parameters.AddWithValue("@soluong", lsvPhieuThue.Items.Count);
                sqlCommandPT.Parameters.AddWithValue("@loaikh", 0);
                sqlCommandPT.Parameters.AddWithValue("@thanhtoan", 0);
                sqlCommandPT.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }

        // Kiểm tra các điều kiện trước khi lưu phiếu thuê.
        void CheckAndSavePT()
        {
            while (CheckMaKH())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return;
            }
            if (lsvPhieuThue.Items.Count == 0 || string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return;
            }
            SaveDataKH();
            CheckDataMaKH();
            if (isMember)
            {
                UpdateTinhTrangPhong();
                SaveDataPT();
                MessageBox.Show("Lập phiếu thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnMenu_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Mã khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
            }
        }
        #endregion

        #region Gọi các sự kiện click button.
        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            ShowDataKH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int sl = GetSL();
            AddKhachHang(sl);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            RemoveKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EditDataKH();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CheckAndSavePT();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (QuanLyKhachSan.Container.isReturnMenu)
            {
                QuanLyKhachSan.Container.isReturnMenu = false;
                ReturnMenu(this, new EventArgs());
            }
            else if (QuanLyKhachSan.Container.isReturnTraCuu)
            {
                QuanLyKhachSan.Container.isReturnTraCuu = false;
                ReturnTraCuu(this, new EventArgs());
            }
        }
        #endregion        

        #region Graphics
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush sBrush = new SolidBrush(Color.FromArgb(63, 170, 162));
            g.FillRectangle(sBrush, 0, 0, this.Width, 90);
        }

        #endregion
    }
}
