namespace QuanLyKhachSan
{
    partial class ThayDoiQuyDinh
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabUpgia = new System.Windows.Forms.TabPage();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtGiam = new System.Windows.Forms.TextBox();
            this.txtGiaht = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbpng = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabupsl = new System.Windows.Forms.TabPage();
            this.btnupsl = new System.Windows.Forms.Button();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtslmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabUpgia.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabupsl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.Gray;
            this.btnMenu.Location = new System.Drawing.Point(28, 370);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(106, 35);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Quay Lại";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.Gray;
            this.btnThoat.Location = new System.Drawing.Point(359, 370);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 35);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tabUpgia
            // 
            this.tabUpgia.Controls.Add(this.btnupdate);
            this.tabUpgia.Controls.Add(this.txtGiam);
            this.tabUpgia.Controls.Add(this.txtGiaht);
            this.tabUpgia.Controls.Add(this.label3);
            this.tabUpgia.Controls.Add(this.cmbpng);
            this.tabUpgia.Controls.Add(this.label2);
            this.tabUpgia.Controls.Add(this.label1);
            this.tabUpgia.Location = new System.Drawing.Point(4, 25);
            this.tabUpgia.Name = "tabUpgia";
            this.tabUpgia.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpgia.Size = new System.Drawing.Size(433, 291);
            this.tabUpgia.TabIndex = 0;
            this.tabUpgia.Text = "Sửa Giá Phòng";
            this.tabUpgia.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(192)))), ((int)(((byte)(156)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(161, 191);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(104, 40);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Cập Nhật";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtGiam
            // 
            this.txtGiam.Location = new System.Drawing.Point(161, 123);
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.Size = new System.Drawing.Size(161, 22);
            this.txtGiam.TabIndex = 6;
            // 
            // txtGiaht
            // 
            this.txtGiaht.Location = new System.Drawing.Point(161, 75);
            this.txtGiaht.Name = "txtGiaht";
            this.txtGiaht.ReadOnly = true;
            this.txtGiaht.Size = new System.Drawing.Size(161, 22);
            this.txtGiaht.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá Sửa :";
            // 
            // cmbpng
            // 
            this.cmbpng.FormattingEnabled = true;
            this.cmbpng.Items.AddRange(new object[] {
            "Standard",
            "Superior",
            "Deluxe"});
            this.cmbpng.Location = new System.Drawing.Point(161, 25);
            this.cmbpng.Name = "cmbpng";
            this.cmbpng.Size = new System.Drawing.Size(161, 24);
            this.cmbpng.TabIndex = 4;
            this.cmbpng.SelectedIndexChanged += new System.EventHandler(this.cmbpng_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Hiện Tại :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Phòng :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUpgia);
            this.tabControl1.Controls.Add(this.tabupsl);
            this.tabControl1.Location = new System.Drawing.Point(28, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 320);
            this.tabControl1.TabIndex = 0;
            // 
            // tabupsl
            // 
            this.tabupsl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tabupsl.Controls.Add(this.btnupsl);
            this.tabupsl.Controls.Add(this.txtsl);
            this.tabupsl.Controls.Add(this.txtslmax);
            this.tabupsl.Controls.Add(this.label6);
            this.tabupsl.Controls.Add(this.label5);
            this.tabupsl.Location = new System.Drawing.Point(4, 25);
            this.tabupsl.Name = "tabupsl";
            this.tabupsl.Padding = new System.Windows.Forms.Padding(3);
            this.tabupsl.Size = new System.Drawing.Size(433, 291);
            this.tabupsl.TabIndex = 1;
            this.tabupsl.Text = "Thay Đổi Số Lượng";
            this.tabupsl.UseVisualStyleBackColor = true;
            // 
            // btnupsl
            // 
            this.btnupsl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(192)))), ((int)(((byte)(156)))));
            this.btnupsl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupsl.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnupsl.ForeColor = System.Drawing.SystemColors.Control;
            this.btnupsl.Location = new System.Drawing.Point(192, 140);
            this.btnupsl.Name = "btnupsl";
            this.btnupsl.Size = new System.Drawing.Size(109, 37);
            this.btnupsl.TabIndex = 7;
            this.btnupsl.Text = "Cập Nhật";
            this.btnupsl.UseVisualStyleBackColor = false;
            this.btnupsl.Click += new System.EventHandler(this.btnupsl_Click);
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(192, 86);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(156, 22);
            this.txtsl.TabIndex = 6;
            // 
            // txtslmax
            // 
            this.txtslmax.Location = new System.Drawing.Point(192, 34);
            this.txtslmax.Name = "txtslmax";
            this.txtslmax.ReadOnly = true;
            this.txtslmax.Size = new System.Drawing.Size(156, 22);
            this.txtslmax.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label6.Location = new System.Drawing.Point(31, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thay Đổi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label5.Location = new System.Drawing.Point(31, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Khách Tối Đa :";
            // 
            // ThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 439);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThayDoiQuyDinh";
            this.Text = "Thay Đổi Quy Đinh";
            this.tabUpgia.ResumeLayout(false);
            this.tabUpgia.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabupsl.ResumeLayout(false);
            this.tabupsl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabUpgia;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtGiam;
        private System.Windows.Forms.TextBox txtGiaht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbpng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabupsl;
        private System.Windows.Forms.Button btnupsl;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtslmax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TabControl tabControl1;
    

    }
}