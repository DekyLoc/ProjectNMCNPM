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
    public partial class GUI_PhieuThuePhong : Form
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

        public GUI_PhieuThuePhong()
        {
            InitializeComponent();
            PTP_BUS = new BUS_PhieuThuePhong();
            PTP_DTO= new DTO_PhieuThuePhong();
        }

        private BUS_PhieuThuePhong PTP_BUS;
        private DTO_PhieuThuePhong PTP_DTO;
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
            DataTable dataTable = new DataTable();
            dataTable = PTP_BUS.FindPhieuThue();
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
   
            DataTable dataTable = new DataTable();
            dataTable = PTP_BUS.FindRoom();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][4].ToString() == "False")
                    cmbPhong.Items.Add(dataTable.Rows[i][0].ToString());
            }
            cmbPhong.SelectedIndex = 0;

            if (QLKS.Container.isReturnTraCuu)
            {
                cmbPhong.Text = QLKS.Container.selectedPhong;
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
            catch (Exception)
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
            DataTable dataTable = new DataTable();
            dataTable = PTP_BUS.FindKH();
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

        // Thêm một khách hàng mới.
        void AddKhachHang()
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

            if (lsvPhieuThue.Items.Count == 3)
            {
                MessageBox.Show("Phòng đã nhận đủ 3 khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DTO_KhachHang selectedKhachHang = new DTO_KhachHang(selectedItem.Text, selectedItem.SubItems[1].Text, selectedItem.SubItems[2].Text, selectedItem.SubItems[3].Text, selectedItem.SubItems[4].Text, selectedItem.SubItems[5].Text);
            QLKS.Container.newKhachHang = selectedKhachHang;
            QLKS.Container.indexKhachHang = lsvPhieuThue.SelectedIndices[0];

            GUI_SuaThongTin frmSua = new GUI_SuaThongTin();
            frmSua.FormClosed += FrmSua_FormClosed;
            frmSua.ShowDialog();

            foreach (ListViewItem item in lsvPhieuThue.Items)
            {
                if (item == null)
                    return;
                if (item != selectedItem)
                {
                    if (item.SubItems[4].Text == QLKS.Container.newKhachHang.CMND.ToString())
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
            if (QLKS.Container.newKhachHang != null)
            {
                ListViewItem NewItem = lsvPhieuThue.Items[QLKS.Container.indexKhachHang];
                NewItem.Text = QLKS.Container.newKhachHang.Phong;
                NewItem.SubItems[1].Text = QLKS.Container.newKhachHang.MaKhachHang;
                NewItem.SubItems[2].Text = QLKS.Container.newKhachHang.TenKhachHang;
                NewItem.SubItems[3].Text = QLKS.Container.newKhachHang.LoaiKhach;
                NewItem.SubItems[4].Text = QLKS.Container.newKhachHang.CMND.ToString();
                NewItem.SubItems[5].Text = QLKS.Container.newKhachHang.DiaChi;
            }
        }

        // Cập nhật trạng thái của phòng sau khi cho thuê.
        void UpdateTinhTrangPhong()
        {
            DataTable dataTable = new DataTable();
            dataTable = PTP_BUS.FindRoom();
            PTP_BUS.Open();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                foreach (ListViewItem item in lsvPhieuThue.Items)
                {
                    if (item == null)
                        return;
                    if (item.Text == dataTable.Rows[i][0].ToString())
                    {
                        PTP_BUS.UpdateRoom(item.Text);
                        PTP_BUS.Close();
                        return;
                    }
                }
            }
            PTP_BUS.Close();
        }

        // Lưu thông tin khách hàng.
        void SaveDataKH()
        {
            //ERD
            DataTable dataTablelKH = new DataTable();
            dataTablelKH = PTP_BUS.FindKH();
            PTP_BUS.Open();
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
                            PTP_DTO.MaPNG = item.SubItems[1].Text;
                            PTP_DTO.HoTen = item.SubItems[2].Text;
                            PTP_DTO.LoaiKH = item.SubItems[3].Text;
                            PTP_DTO.CMND= item.SubItems[4].Text;
                            PTP_DTO.DiaChi = item.SubItems[5].Text;
                            PTP_BUS.InsertKH(PTP_DTO);
                        }
                    }
                }
                else
                {
                    PTP_DTO.MaPNG = item.SubItems[1].Text;
                    PTP_DTO.HoTen = item.SubItems[2].Text;
                    PTP_DTO.LoaiKH = item.SubItems[3].Text;
                    PTP_DTO.CMND = item.SubItems[4].Text;
                    PTP_DTO.DiaChi = item.SubItems[5].Text;
                    PTP_BUS.InsertKH(PTP_DTO);
                }

            }
            PTP_BUS.Close();
        }

        // Kiểm tra nếu MaKH đã tồn tại.
        void CheckDataMaKH()
        {
           
            DataTable dataTableKH = new DataTable();
            dataTableKH = PTP_BUS.FindKH();
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

            PTP_BUS.Open();
            if (isForeign)
            {
                PTP_DTO.MaPhieu = txtMaPhieuThue.Text;
                PTP_DTO.NgayThue = dateTime.ToString(dateTimeFormat);
                PTP_DTO.MaKH =  txtMaKhachHang.Text;
                PTP_DTO.MaPNG = cmbPhong.Text;
                PTP_DTO.SoLuong = lsvPhieuThue.Items.Count;
                PTP_DTO.LoaiKH = "1";
                PTP_DTO.ThanhToan = "0";
                PTP_BUS.UpdateKH(PTP_DTO);
            }
            else
            {
                PTP_DTO.MaPhieu = txtMaPhieuThue.Text;
                PTP_DTO.NgayThue = dateTime.ToString(dateTimeFormat);
                PTP_DTO.MaKH = txtMaKhachHang.Text;
                PTP_DTO.MaPNG = cmbPhong.Text;
                PTP_DTO.SoLuong = lsvPhieuThue.Items.Count;
                PTP_DTO.LoaiKH = "0";
                PTP_DTO.ThanhToan = "0";
                PTP_BUS.UpdateKH(PTP_DTO);
            }
            PTP_BUS.Close();
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
            AddKhachHang();
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
            if (QLKS.Container.isReturnMenu)
            {
                QLKS.Container.isReturnMenu = false;
                ReturnMenu(this, new EventArgs());
            }
            else if (QLKS.Container.isReturnTraCuu)
            {
                QLKS.Container.isReturnTraCuu = false;
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
