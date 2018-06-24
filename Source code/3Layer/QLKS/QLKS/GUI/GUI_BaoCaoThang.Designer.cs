namespace QLKS.GUI
{
    partial class GUI_BaoCaoThang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "GUI_BaoCaoThang";
             this.cmbThang = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvBaoCao = new System.Windows.Forms.ListView();
            this.clnLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDoanhThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTyLe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMaBaoCao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.btnLuuDoanhThu = new System.Windows.Forms.Button();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lsvDoanhThu = new System.Windows.Forms.ListView();
            this.clnPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNgayThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNgayTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbThang
            // 
            this.cmbThang.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(165, 134);
            this.cmbThang.Margin = new System.Windows.Forms.Padding(4);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(233, 27);
            this.cmbThang.TabIndex = 0;
            this.cmbThang.SelectedIndexChanged += new System.EventHandler(this.cmbThang_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Gray;
            this.btnThoat.Location = new System.Drawing.Point(851, 703);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 46);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(152)))), ((int)(((byte)(100)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(753, 703);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 46);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Gray;
            this.btnMenu.Location = new System.Drawing.Point(37, 703);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(168, 46);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Quay lại";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Báo cáo tháng";
            // 
            // lsvBaoCao
            // 
            this.lsvBaoCao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnLoaiPhong,
            this.clnDoanhThu,
            this.clnTyLe});
            this.lsvBaoCao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBaoCao.FullRowSelect = true;
            this.lsvBaoCao.GridLines = true;
            this.lsvBaoCao.Location = new System.Drawing.Point(37, 546);
            this.lsvBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.lsvBaoCao.MultiSelect = false;
            this.lsvBaoCao.Name = "lsvBaoCao";
            this.lsvBaoCao.Size = new System.Drawing.Size(903, 132);
            this.lsvBaoCao.TabIndex = 14;
            this.lsvBaoCao.UseCompatibleStateImageBehavior = false;
            this.lsvBaoCao.View = System.Windows.Forms.View.Details;
            // 
            // clnLoaiPhong
            // 
            this.clnLoaiPhong.Text = "Loại phòng";
            this.clnLoaiPhong.Width = 150;
            // 
            // clnDoanhThu
            // 
            this.clnDoanhThu.Text = "Doanh thu";
            this.clnDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clnDoanhThu.Width = 297;
            // 
            // clnTyLe
            // 
            this.clnTyLe.Text = "Tỷ lệ";
            this.clnTyLe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clnTyLe.Width = 156;
            // 
            // txtMaBaoCao
            // 
            this.txtMaBaoCao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBaoCao.Location = new System.Drawing.Point(715, 134);
            this.txtMaBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBaoCao.Name = "txtMaBaoCao";
            this.txtMaBaoCao.ReadOnly = true;
            this.txtMaBaoCao.Size = new System.Drawing.Size(228, 27);
            this.txtMaBaoCao.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(557, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mã báo cáo";
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(152)))), ((int)(((byte)(100)))));
            this.btnXuatBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXuatBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(561, 481);
            this.btnXuatBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(187, 46);
            this.btnXuatBaoCao.TabIndex = 4;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = false;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // btnLuuDoanhThu
            // 
            this.btnLuuDoanhThu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLuuDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnLuuDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuDoanhThu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDoanhThu.ForeColor = System.Drawing.Color.Gray;
            this.btnLuuDoanhThu.Location = new System.Drawing.Point(755, 481);
            this.btnLuuDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuDoanhThu.Name = "btnLuuDoanhThu";
            this.btnLuuDoanhThu.Size = new System.Drawing.Size(187, 46);
            this.btnLuuDoanhThu.TabIndex = 5;
            this.btnLuuDoanhThu.Text = "Lưu doanh thu";
            this.btnLuuDoanhThu.UseVisualStyleBackColor = false;
            this.btnLuuDoanhThu.Click += new System.EventHandler(this.btnLuuDoanhThu_Click);
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.Location = new System.Drawing.Point(715, 434);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.ReadOnly = true;
            this.txtDoanhThu.Size = new System.Drawing.Size(171, 27);
            this.txtDoanhThu.TabIndex = 80;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 439);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 79;
            this.label4.Text = "Doanh thu tháng";
            // 
            // lsvDoanhThu
            // 
            this.lsvDoanhThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnPhong,
            this.columnHeader1,
            this.clnNgayThue,
            this.clnNgayTra,
            this.clnThanhTien});
            this.lsvDoanhThu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDoanhThu.FullRowSelect = true;
            this.lsvDoanhThu.GridLines = true;
            this.lsvDoanhThu.Location = new System.Drawing.Point(37, 246);
            this.lsvDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.lsvDoanhThu.MultiSelect = false;
            this.lsvDoanhThu.Name = "lsvDoanhThu";
            this.lsvDoanhThu.Size = new System.Drawing.Size(903, 176);
            this.lsvDoanhThu.TabIndex = 78;
            this.lsvDoanhThu.UseCompatibleStateImageBehavior = false;
            this.lsvDoanhThu.View = System.Windows.Forms.View.Details;
            // 
            // clnPhong
            // 
            this.clnPhong.Text = "Phòng";
            this.clnPhong.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Loại phòng";
            this.columnHeader1.Width = 110;
            // 
            // clnNgayThue
            // 
            this.clnNgayThue.Text = "Ngày thuê";
            this.clnNgayThue.Width = 110;
            // 
            // clnNgayTra
            // 
            this.clnNgayTra.Text = "Ngày trả";
            this.clnNgayTra.Width = 110;
            // 
            // clnThanhTien
            // 
            this.clnThanhTien.Text = "Thành tiền";
            this.clnThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clnThanhTien.Width = 163;
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnC.Location = new System.Drawing.Point(399, 192);
            this.rbtnC.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(79, 23);
            this.rbtnC.TabIndex = 3;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "Deluxe";
            this.rbtnC.UseVisualStyleBackColor = true;
            this.rbtnC.CheckedChanged += new System.EventHandler(this.rbtnC_CheckedChanged);
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnB.Location = new System.Drawing.Point(285, 192);
            this.rbtnB.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(93, 23);
            this.rbtnB.TabIndex = 2;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "Superior";
            this.rbtnB.UseVisualStyleBackColor = true;
            this.rbtnB.CheckedChanged += new System.EventHandler(this.rbtnB_CheckedChanged);
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnA.Location = new System.Drawing.Point(165, 192);
            this.rbtnA.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(96, 23);
            this.rbtnA.TabIndex = 1;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "Standard";
            this.rbtnA.UseVisualStyleBackColor = true;
            this.rbtnA.CheckedChanged += new System.EventHandler(this.rbtnA_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Loại phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(893, 439);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 134;
            this.label6.Text = "VND";
            // 
            // BaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 768);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnLuuDoanhThu);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsvDoanhThu);
            this.Controls.Add(this.rbtnC);
            this.Controls.Add(this.rbtnB);
            this.Controls.Add(this.rbtnA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaBaoCao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvBaoCao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BaoCaoThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tháng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaoCao_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvBaoCao;
        private System.Windows.Forms.ColumnHeader clnLoaiPhong;
        private System.Windows.Forms.ColumnHeader clnDoanhThu;
        private System.Windows.Forms.ColumnHeader clnTyLe;
        private System.Windows.Forms.TextBox txtMaBaoCao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Button btnLuuDoanhThu;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsvDoanhThu;
        private System.Windows.Forms.ColumnHeader clnPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader clnNgayThue;
        private System.Windows.Forms.ColumnHeader clnNgayTra;
        private System.Windows.Forms.ColumnHeader clnThanhTien;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}