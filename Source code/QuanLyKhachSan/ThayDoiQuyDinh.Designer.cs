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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUpgia = new System.Windows.Forms.TabPage();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtGiam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbpng = new System.Windows.Forms.ComboBox();
            this.txtGiaht = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabUpgia.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUpgia);
            this.tabControl1.Location = new System.Drawing.Point(24, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUpgia
            // 
            this.tabUpgia.Controls.Add(this.btnMenu);
            this.tabUpgia.Controls.Add(this.btnThoat);
            this.tabUpgia.Controls.Add(this.btnupdate);
            this.tabUpgia.Controls.Add(this.txtGiam);
            this.tabUpgia.Controls.Add(this.label3);
            this.tabUpgia.Controls.Add(this.cmbpng);
            this.tabUpgia.Controls.Add(this.txtGiaht);
            this.tabUpgia.Controls.Add(this.label2);
            this.tabUpgia.Controls.Add(this.label1);
            this.tabUpgia.Location = new System.Drawing.Point(4, 25);
            this.tabUpgia.Name = "tabUpgia";
            this.tabUpgia.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpgia.Size = new System.Drawing.Size(480, 366);
            this.tabUpgia.TabIndex = 0;
            this.tabUpgia.Text = "Sửa Giá Phòng";
            this.tabUpgia.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.Gray;
            this.btnMenu.Location = new System.Drawing.Point(37, 276);
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
            this.btnThoat.Location = new System.Drawing.Point(329, 276);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 35);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(192)))), ((int)(((byte)(156)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(196, 185);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(104, 40);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Cập Nhật";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // textBox1
            // 
            this.txtGiam.Location = new System.Drawing.Point(161, 123);
            this.txtGiam.Name = "textBox1";
            this.txtGiam.Size = new System.Drawing.Size(208, 22);
            this.txtGiam.TabIndex = 6;
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
            "Supervior",
            "Deluxe"});
            this.cmbpng.Location = new System.Drawing.Point(161, 25);
            this.cmbpng.Name = "cmbpng";
            this.cmbpng.Size = new System.Drawing.Size(208, 24);
            this.cmbpng.TabIndex = 4;
            this.cmbpng.SelectedIndexChanged += new System.EventHandler(this.cmbpng_SelectedIndexChanged);
            // 
            // txtGiaht
            // 
            this.txtGiaht.Location = new System.Drawing.Point(161, 75);
            this.txtGiaht.Name = "txtGiaht";
            this.txtGiaht.Size = new System.Drawing.Size(208, 22);
            this.txtGiaht.TabIndex = 3;
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
            // ThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 464);
            this.Controls.Add(this.tabControl1);
            this.Name = "Thay Đổi Quy Đinh";
            this.Text = "Thay Đổi Quy Đinh";
            this.tabControl1.ResumeLayout(false);
            this.tabUpgia.ResumeLayout(false);
            this.tabUpgia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUpgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaht;
        private System.Windows.Forms.TextBox txtGiam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbpng;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}