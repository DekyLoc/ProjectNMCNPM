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
    public partial class DanhMucPhong : Form
    {
        #region Hàm khởi tạo, các biến và event.
        // Event quay lại Menu.
        public event EventHandler ReturnMenu;

        // Quay lại menu hoặc thoát chương trình.
        public bool isExit = true; 

        public DanhMucPhong()
        {
            InitializeComponent();
            LoadData();
            LoadCheckBox();
            rbtnA.Checked = true;
            rbtnA_CheckedChanged(this, new EventArgs());
        }
        #endregion 

        #region Đóng form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Show dialog notify
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                FormClose();
            }
            else
            {
                return;
            }
        }

        private void DanhMucPhong_FormClosed(object sender, FormClosedEventArgs e) 
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
        
        // Load dữ liệu của bảng phòng từ csdl.
        void LoadData()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=" + QuanLyKhachSan.Container.severName + ";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHONG", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            lsvDanhMucPhong.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string temp = dataTable.Rows[i][2].ToString();
                ListViewItem Item = new ListViewItem(dataTable.Rows[i][0].ToString());
                Item.SubItems.Add(dataTable.Rows[i][1].ToString());
                Item.SubItems.Add(QuanLyKhachSan.Container.FormatMoney(Int32.Parse(dataTable.Rows[i][2].ToString())));
                Item.SubItems.Add(dataTable.Rows[i][3].ToString());
                lsvDanhMucPhong.Items.Add(Item);
            }
        }

        // Load dữ liệu của các check box tương ứng với mỗi radio button.
        void LoadCheckBox()
        {
            foreach (ListViewItem item in lsvDanhMucPhong.Items)
            {
                if (item == null)
                {
                    return;
                }
                foreach (var ck in this.Controls)
                {
                    CheckBox checkBox = ck as CheckBox;
                    if (checkBox != null)
                    {
                        if(checkBox.Text=="Trống" && item.Text=="Trống")
                        {
                            continue;
                        }
                        else
                        {
                            if (checkBox.Text == item.Text)
                            {
                                checkBox.Checked = true;
                                checkBox.Enabled = false;
                            }
                        }
                       
                    }
                }
            }
        }

        #endregion

        #region Xử lí các hàm trong các sự kiện click button.

        // Xử lí thêm phòng khi click button Them
        void AddPhong() 
        {
            foreach (var item in this.Controls)
            {
                CheckBox checkBox = item as CheckBox;
                if (checkBox != null)
                {
                    if (checkBox.Checked == true && checkBox.Enabled == true)
                    {
                        if (rbtnA.Checked == true)
                        {
                            ListViewItem NewItem = new ListViewItem(checkBox.Text);
                            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = rbtnA.Text });
                            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtDonGia.Text });
                            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtGhiChu.Text });
                            lsvDanhMucPhong.Items.Add(NewItem);
                        }
                        else if (rbtnB.Checked == true)
                        {
                            ListViewItem NewItem = new ListViewItem(checkBox.Text);
                            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = rbtnB.Text });
                            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtDonGia.Text });
                            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtGhiChu.Text });
                            lsvDanhMucPhong.Items.Add(NewItem);
                        }
                        else if (rbtnC.Checked == true)
                        {
                            ListViewItem NewItem = new ListViewItem(checkBox.Text);
                            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = rbtnC.Text });
                            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtDonGia.Text });
                            NewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtGhiChu.Text });
                            lsvDanhMucPhong.Items.Add(NewItem);
                        }
                        else
                            return;
                    }
                }
            }
        }

        // Cập nhật khi bỏ check các phòng.
        void RemovePhong() 
        {
            if (rbtnA.Checked == true)
                RemoveItem("Standard");
            else if (rbtnB.Checked == true)
                RemoveItem("Superior");
            else if (rbtnC.Checked == true)
                RemoveItem("Deluxe");
        }

        // Hàm được gọi bởi RemovePhong
        void RemoveItem(string loaiphong) 
        {
            foreach (ListViewItem item in lsvDanhMucPhong.Items)
            {
                if (item == null)
                    return;
                if (loaiphong == item.SubItems[1].Text)
                    lsvDanhMucPhong.Items.Remove(item);
            }
        }

        // Cập nhật trạng thái của các check box của những radio button không được check.
        void CheckPhong() 
        {
            if (rbtnA.Checked == true)
            {
                CheckItem("Superior");
                CheckItem("Deluxe");
            }
            else if (rbtnB.Checked == true)
            {
                CheckItem("Standard");
                CheckItem("Deluxe");
            }
            else if (rbtnC.Checked == true)
            {
                CheckItem("Standard");
                CheckItem("Superior");
            }
            else
                return;
        }

        // Hàm được gọi bởi CheckPhong.
        void CheckItem(string loaiphong) 
        {
            foreach (ListViewItem item in lsvDanhMucPhong.Items)
            {
                if (item == null)
                    return;
                if (loaiphong == item.SubItems[1].Text)
                {
                    foreach (var ck in this.Controls)
                    {
                        CheckBox checkBox = ck as CheckBox;
                        if(checkBox != null)
                        {
                            if(checkBox.Text == item.Text)
                            {
                                checkBox.Checked = true;
                                checkBox.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        // Cập nhật trạng thái các check box của radio button được chọn.
        void ChangeLoaiPhong(string loaiphong) 
        {
            foreach (var ck in this.Controls)
            {
                CheckBox checkBox = ck as CheckBox;
                if (checkBox != null)
                {
                    foreach (ListViewItem item in lsvDanhMucPhong.Items)
                    {
                        if (item == null)
                            return;
                        if (item.Text == checkBox.Text && item.SubItems[1].Text == loaiphong)
                        {
                            checkBox.Enabled = true;
                        }
                        else if (item.Text == checkBox.Text)
                        {
                            checkBox.Enabled = false;
                        }
                    }
                }
            }
        }
        // Cập nhật tình trạng phòng
        //int CheckState()
        //{
        //    if(ckbtt.Checked==true)
        //    {
        //        return 1;
        //    }
        //    return 0;
        //}
        // Lưu dữ liệu khi nhấn button Luu.
        void SaveData() 
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source="+QuanLyKhachSan.Container.severName+";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PHONG", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (lsvDanhMucPhong.Items.Count == 0)
            {
                SqlCommand sqlCommand = new SqlCommand("delete from PHONG ", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return;
            }

            sqlConnection.Open();
            if (dataTable.Rows.Count == 0)
            {
                foreach (ListViewItem item in lsvDanhMucPhong.Items)
                {
                    string temp = item.SubItems[2].Text;
                    item.SubItems[2].Text = QuanLyKhachSan.Container.FormatMoney(item.SubItems[2].Text).ToString();
                    //int tt = CheckState();
                      SqlCommand sqlCommand = new SqlCommand("insert into PHONG values ('" + item.Text + "','" + item.SubItems[1].Text + "', '" + item.SubItems[2].Text + "',N'" + item.SubItems[3].Text + "' , '" + 0 + "'  )", sqlConnection);
                      sqlCommand.ExecuteNonQuery();
                      item.SubItems[2].Text = temp;
                }
            }
            else
            {
                //Thêm phòng hoặc update loại phòng.
                foreach (ListViewItem item in lsvDanhMucPhong.Items)
                {
                    if (item == null)
                        return;
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (item.Text == dataTable.Rows[i][0].ToString() && item.SubItems[1].Text == dataTable.Rows[i][1].ToString())
                            break;
                        else if (item.Text == dataTable.Rows[i][0].ToString() && item.SubItems[1].Text != dataTable.Rows[i][1].ToString())
                        {
                            SqlCommand sqlCommand = new SqlCommand("update PHONG set LOAI_PNG='" + item.SubItems[1].Text + "', DON_GIA='" + QuanLyKhachSan.Container.FormatMoney(item.SubItems[2].Text).ToString()
                            +"', GHI_CHU=N'" + item.SubItems[3].Text + "' where MAPNG='" + item.Text + "'", sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            break;
                        }
                        else if (i == dataTable.Rows.Count - 1)
                        {
                            SqlCommand sqlCommand = new SqlCommand("insert into PHONG values ('" + item.Text + "','" + item.SubItems[1].Text + "', '" + QuanLyKhachSan.Container.FormatMoney(item.SubItems[2].Text).ToString() + "',N'" + item.SubItems[3].Text + "' , '" + 0 + "'  )", sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                }
                //Delete phòng
                try
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        foreach (ListViewItem item in lsvDanhMucPhong.Items)
                        {
                            if (item == null)
                                return;
                            if (item.Text == dataTable.Rows[i][0].ToString())
                                break;
                            else if (item.Text == lsvDanhMucPhong.Items[lsvDanhMucPhong.Items.Count - 1].Text)
                            {
                                SqlCommand sqlCommand = new SqlCommand("delete from PHONG where MAPNG='" + dataTable.Rows[i][0].ToString() + "'", sqlConnection);
                                sqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Phòng đã thuê không được phép chỉnh sửa!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
            }
            sqlConnection.Close();
            MessageBox.Show("Lưu Danh Mục Phòng Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int GetMoney(string maphong)
        {
            int money = '0';
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=" + QuanLyKhachSan.Container.severName + ";Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from GIA where MAPHONG='" + maphong + "'", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                money = Int32.Parse(dataTable.Rows[0][1].ToString());
                MessageBox.Show("Cập Nhật Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thể Cập Nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return money;
        }
        #endregion

        #region Gọi các sự kiện click button.
        private void btnThem_Click(object sender, EventArgs e)
        {
            RemovePhong();
            AddPhong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnReset_Click(object sender, EventArgs e) 
        {
            foreach (var ck in this.Controls)
            {
                CheckBox checkBox = ck as CheckBox;
                if (checkBox != null)
                {
                    if (rbtnA.Checked == true && checkBox.Checked == true && checkBox.Enabled == true)
                        checkBox.Checked = false;
                    if (rbtnB.Checked == true && checkBox.Checked == true && checkBox.Enabled == true)
                        checkBox.Checked = false;
                    if (rbtnC.Checked == true && checkBox.Checked == true && checkBox.Enabled == true)
                        checkBox.Checked = false;

                }
            }
        }

        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            int money = GetMoney("A");
            txtDonGia.Text = QuanLyKhachSan.Container.FormatMoney(money);
            CheckPhong();
            ChangeLoaiPhong("Standard");
            txtGhiChu.Clear();
        }

        private void rbtnB_CheckedChanged(object sender, EventArgs e)
        {
            int money = GetMoney("B");
            txtDonGia.Text = QuanLyKhachSan.Container.FormatMoney(money);
            CheckPhong();
            ChangeLoaiPhong("Superior");
            txtGhiChu.Clear();
        }

        private void rbtnC_CheckedChanged(object sender, EventArgs e)
        {
            int money = GetMoney("C");
            txtDonGia.Text = QuanLyKhachSan.Container.FormatMoney(money);
            CheckPhong();
            ChangeLoaiPhong("Deluxe");
            txtGhiChu.Clear();
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
            SolidBrush sBrush = new SolidBrush(Color.FromArgb(132, 192, 156));
            g.FillRectangle(sBrush, 0, 0, this.Width, 90);
        }

        #endregion







    }
}
