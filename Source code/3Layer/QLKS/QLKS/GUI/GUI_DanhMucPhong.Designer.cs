namespace QLKS.GUI
{
    partial class GUI_DanhMucPhong
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
            this.Text = "GUI_DanhMucPhong";
            this.clnLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lsvDanhMucPhong = new System.Windows.Forms.ListView();
            this.clnDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.ckb309 = new System.Windows.Forms.CheckBox();
            this.ckb209 = new System.Windows.Forms.CheckBox();
            this.ckb109 = new System.Windows.Forms.CheckBox();
            this.ckb308 = new System.Windows.Forms.CheckBox();
            this.ckb208 = new System.Windows.Forms.CheckBox();
            this.ckb108 = new System.Windows.Forms.CheckBox();
            this.ckb306 = new System.Windows.Forms.CheckBox();
            this.ckb206 = new System.Windows.Forms.CheckBox();
            this.ckb106 = new System.Windows.Forms.CheckBox();
            this.ckb307 = new System.Windows.Forms.CheckBox();
            this.ckb207 = new System.Windows.Forms.CheckBox();
            this.ckb107 = new System.Windows.Forms.CheckBox();
            this.ckb305 = new System.Windows.Forms.CheckBox();
            this.ckb205 = new System.Windows.Forms.CheckBox();
            this.ckb105 = new System.Windows.Forms.CheckBox();
            this.ckb304 = new System.Windows.Forms.CheckBox();
            this.ckb204 = new System.Windows.Forms.CheckBox();
            this.ckb104 = new System.Windows.Forms.CheckBox();
            this.ckb303 = new System.Windows.Forms.CheckBox();
            this.ckb203 = new System.Windows.Forms.CheckBox();
            this.ckb103 = new System.Windows.Forms.CheckBox();
            this.ckb302 = new System.Windows.Forms.CheckBox();
            this.ckb301 = new System.Windows.Forms.CheckBox();
            this.ckb202 = new System.Windows.Forms.CheckBox();
            this.ckb201 = new System.Windows.Forms.CheckBox();
            this.ckb102 = new System.Windows.Forms.CheckBox();
            this.ckb101 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clnLoaiPhong
            // 
            this.clnLoaiPhong.Text = "Loại phòng";
            this.clnLoaiPhong.Width = 120;
            // 
            // clnPhong
            // 
            this.clnPhong.Text = "Phòng";
            this.clnPhong.Width = 120;
            // 
            // btnDatLai
            // 
            this.btnDatLai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDatLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatLai.FlatAppearance.BorderSize = 0;
            this.btnDatLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLai.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLai.ForeColor = System.Drawing.Color.Gray;
            this.btnDatLai.Location = new System.Drawing.Point(827, 393);
            this.btnDatLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(100, 46);
            this.btnDatLai.TabIndex = 2;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = false;
            this.btnDatLai.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(192)))), ((int)(((byte)(156)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(719, 393);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 46);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lsvDanhMucPhong
            // 
            this.lsvDanhMucPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnPhong,
            this.clnLoaiPhong,
            this.clnDonGia,
            this.clnGhiChu});
            this.lsvDanhMucPhong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhMucPhong.FullRowSelect = true;
            this.lsvDanhMucPhong.GridLines = true;
            this.lsvDanhMucPhong.Location = new System.Drawing.Point(56, 446);
            this.lsvDanhMucPhong.Margin = new System.Windows.Forms.Padding(4);
            this.lsvDanhMucPhong.MultiSelect = false;
            this.lsvDanhMucPhong.Name = "lsvDanhMucPhong";
            this.lsvDanhMucPhong.Size = new System.Drawing.Size(871, 221);
            this.lsvDanhMucPhong.TabIndex = 101;
            this.lsvDanhMucPhong.UseCompatibleStateImageBehavior = false;
            this.lsvDanhMucPhong.View = System.Windows.Forms.View.Details;
            // 
            // clnDonGia
            // 
            this.clnDonGia.Text = "Đơn giá";
            this.clnDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clnDonGia.Width = 159;
            // 
            // clnGhiChu
            // 
            this.clnGhiChu.Text = "Ghi chú";
            this.clnGhiChu.Width = 231;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(165, 393);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(267, 27);
            this.txtGhiChu.TabIndex = 0;
            // 
            // ckb309
            // 
            this.ckb309.AutoSize = true;
            this.ckb309.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb309.Location = new System.Drawing.Point(869, 332);
            this.ckb309.Margin = new System.Windows.Forms.Padding(4);
            this.ckb309.Name = "ckb309";
            this.ckb309.Size = new System.Drawing.Size(58, 23);
            this.ckb309.TabIndex = 84;
            this.ckb309.Text = "309";
            this.ckb309.UseVisualStyleBackColor = true;
            // 
            // ckb209
            // 
            this.ckb209.AutoSize = true;
            this.ckb209.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb209.Location = new System.Drawing.Point(869, 305);
            this.ckb209.Margin = new System.Windows.Forms.Padding(4);
            this.ckb209.Name = "ckb209";
            this.ckb209.Size = new System.Drawing.Size(58, 23);
            this.ckb209.TabIndex = 85;
            this.ckb209.Text = "209";
            this.ckb209.UseVisualStyleBackColor = true;
            // 
            // ckb109
            // 
            this.ckb109.AutoSize = true;
            this.ckb109.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb109.Location = new System.Drawing.Point(869, 276);
            this.ckb109.Margin = new System.Windows.Forms.Padding(4);
            this.ckb109.Name = "ckb109";
            this.ckb109.Size = new System.Drawing.Size(58, 23);
            this.ckb109.TabIndex = 86;
            this.ckb109.Text = "109";
            this.ckb109.UseVisualStyleBackColor = true;
            // 
            // ckb308
            // 
            this.ckb308.AutoSize = true;
            this.ckb308.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb308.Location = new System.Drawing.Point(781, 332);
            this.ckb308.Margin = new System.Windows.Forms.Padding(4);
            this.ckb308.Name = "ckb308";
            this.ckb308.Size = new System.Drawing.Size(58, 23);
            this.ckb308.TabIndex = 87;
            this.ckb308.Text = "308";
            this.ckb308.UseVisualStyleBackColor = true;
            // 
            // ckb208
            // 
            this.ckb208.AutoSize = true;
            this.ckb208.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb208.Location = new System.Drawing.Point(781, 305);
            this.ckb208.Margin = new System.Windows.Forms.Padding(4);
            this.ckb208.Name = "ckb208";
            this.ckb208.Size = new System.Drawing.Size(58, 23);
            this.ckb208.TabIndex = 88;
            this.ckb208.Text = "208";
            this.ckb208.UseVisualStyleBackColor = true;
            // 
            // ckb108
            // 
            this.ckb108.AutoSize = true;
            this.ckb108.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb108.Location = new System.Drawing.Point(781, 276);
            this.ckb108.Margin = new System.Windows.Forms.Padding(4);
            this.ckb108.Name = "ckb108";
            this.ckb108.Size = new System.Drawing.Size(58, 23);
            this.ckb108.TabIndex = 91;
            this.ckb108.Text = "108";
            this.ckb108.UseVisualStyleBackColor = true;
            // 
            // ckb306
            // 
            this.ckb306.AutoSize = true;
            this.ckb306.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb306.Location = new System.Drawing.Point(605, 332);
            this.ckb306.Margin = new System.Windows.Forms.Padding(4);
            this.ckb306.Name = "ckb306";
            this.ckb306.Size = new System.Drawing.Size(58, 23);
            this.ckb306.TabIndex = 90;
            this.ckb306.Text = "306";
            this.ckb306.UseVisualStyleBackColor = true;
            // 
            // ckb206
            // 
            this.ckb206.AutoSize = true;
            this.ckb206.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb206.Location = new System.Drawing.Point(605, 305);
            this.ckb206.Margin = new System.Windows.Forms.Padding(4);
            this.ckb206.Name = "ckb206";
            this.ckb206.Size = new System.Drawing.Size(58, 23);
            this.ckb206.TabIndex = 99;
            this.ckb206.Text = "206";
            this.ckb206.UseVisualStyleBackColor = true;
            // 
            // ckb106
            // 
            this.ckb106.AutoSize = true;
            this.ckb106.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb106.Location = new System.Drawing.Point(605, 276);
            this.ckb106.Margin = new System.Windows.Forms.Padding(4);
            this.ckb106.Name = "ckb106";
            this.ckb106.Size = new System.Drawing.Size(58, 23);
            this.ckb106.TabIndex = 92;
            this.ckb106.Text = "106";
            this.ckb106.UseVisualStyleBackColor = true;
            // 
            // ckb307
            // 
            this.ckb307.AutoSize = true;
            this.ckb307.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb307.Location = new System.Drawing.Point(693, 332);
            this.ckb307.Margin = new System.Windows.Forms.Padding(4);
            this.ckb307.Name = "ckb307";
            this.ckb307.Size = new System.Drawing.Size(58, 23);
            this.ckb307.TabIndex = 93;
            this.ckb307.Text = "307";
            this.ckb307.UseVisualStyleBackColor = true;
            // 
            // ckb207
            // 
            this.ckb207.AutoSize = true;
            this.ckb207.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb207.Location = new System.Drawing.Point(693, 305);
            this.ckb207.Margin = new System.Windows.Forms.Padding(4);
            this.ckb207.Name = "ckb207";
            this.ckb207.Size = new System.Drawing.Size(58, 23);
            this.ckb207.TabIndex = 94;
            this.ckb207.Text = "207";
            this.ckb207.UseVisualStyleBackColor = true;
            // 
            // ckb107
            // 
            this.ckb107.AutoSize = true;
            this.ckb107.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb107.Location = new System.Drawing.Point(693, 276);
            this.ckb107.Margin = new System.Windows.Forms.Padding(4);
            this.ckb107.Name = "ckb107";
            this.ckb107.Size = new System.Drawing.Size(58, 23);
            this.ckb107.TabIndex = 95;
            this.ckb107.Text = "107";
            this.ckb107.UseVisualStyleBackColor = true;
            // 
            // ckb305
            // 
            this.ckb305.AutoSize = true;
            this.ckb305.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb305.Location = new System.Drawing.Point(517, 332);
            this.ckb305.Margin = new System.Windows.Forms.Padding(4);
            this.ckb305.Name = "ckb305";
            this.ckb305.Size = new System.Drawing.Size(58, 23);
            this.ckb305.TabIndex = 96;
            this.ckb305.Text = "305";
            this.ckb305.UseVisualStyleBackColor = true;
            // 
            // ckb205
            // 
            this.ckb205.AutoSize = true;
            this.ckb205.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb205.Location = new System.Drawing.Point(517, 305);
            this.ckb205.Margin = new System.Windows.Forms.Padding(4);
            this.ckb205.Name = "ckb205";
            this.ckb205.Size = new System.Drawing.Size(58, 23);
            this.ckb205.TabIndex = 97;
            this.ckb205.Text = "205";
            this.ckb205.UseVisualStyleBackColor = true;
            // 
            // ckb105
            // 
            this.ckb105.AutoSize = true;
            this.ckb105.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb105.Location = new System.Drawing.Point(517, 276);
            this.ckb105.Margin = new System.Windows.Forms.Padding(4);
            this.ckb105.Name = "ckb105";
            this.ckb105.Size = new System.Drawing.Size(58, 23);
            this.ckb105.TabIndex = 98;
            this.ckb105.Text = "105";
            this.ckb105.UseVisualStyleBackColor = true;
            // 
            // ckb304
            // 
            this.ckb304.AutoSize = true;
            this.ckb304.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb304.Location = new System.Drawing.Point(429, 332);
            this.ckb304.Margin = new System.Windows.Forms.Padding(4);
            this.ckb304.Name = "ckb304";
            this.ckb304.Size = new System.Drawing.Size(58, 23);
            this.ckb304.TabIndex = 83;
            this.ckb304.Text = "304";
            this.ckb304.UseVisualStyleBackColor = true;
            // 
            // ckb204
            // 
            this.ckb204.AutoSize = true;
            this.ckb204.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb204.Location = new System.Drawing.Point(429, 305);
            this.ckb204.Margin = new System.Windows.Forms.Padding(4);
            this.ckb204.Name = "ckb204";
            this.ckb204.Size = new System.Drawing.Size(58, 23);
            this.ckb204.TabIndex = 89;
            this.ckb204.Text = "204";
            this.ckb204.UseVisualStyleBackColor = true;
            // 
            // ckb104
            // 
            this.ckb104.AutoSize = true;
            this.ckb104.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb104.Location = new System.Drawing.Point(429, 276);
            this.ckb104.Margin = new System.Windows.Forms.Padding(4);
            this.ckb104.Name = "ckb104";
            this.ckb104.Size = new System.Drawing.Size(58, 23);
            this.ckb104.TabIndex = 82;
            this.ckb104.Text = "104";
            this.ckb104.UseVisualStyleBackColor = true;
            // 
            // ckb303
            // 
            this.ckb303.AutoSize = true;
            this.ckb303.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb303.Location = new System.Drawing.Point(341, 332);
            this.ckb303.Margin = new System.Windows.Forms.Padding(4);
            this.ckb303.Name = "ckb303";
            this.ckb303.Size = new System.Drawing.Size(58, 23);
            this.ckb303.TabIndex = 81;
            this.ckb303.Text = "303";
            this.ckb303.UseVisualStyleBackColor = true;
            // 
            // ckb203
            // 
            this.ckb203.AutoSize = true;
            this.ckb203.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb203.Location = new System.Drawing.Point(341, 305);
            this.ckb203.Margin = new System.Windows.Forms.Padding(4);
            this.ckb203.Name = "ckb203";
            this.ckb203.Size = new System.Drawing.Size(58, 23);
            this.ckb203.TabIndex = 80;
            this.ckb203.Text = "203";
            this.ckb203.UseVisualStyleBackColor = true;
            // 
            // ckb103
            // 
            this.ckb103.AutoSize = true;
            this.ckb103.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb103.Location = new System.Drawing.Point(341, 276);
            this.ckb103.Margin = new System.Windows.Forms.Padding(4);
            this.ckb103.Name = "ckb103";
            this.ckb103.Size = new System.Drawing.Size(58, 23);
            this.ckb103.TabIndex = 79;
            this.ckb103.Text = "103";
            this.ckb103.UseVisualStyleBackColor = true;
            // 
            // ckb302
            // 
            this.ckb302.AutoSize = true;
            this.ckb302.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb302.Location = new System.Drawing.Point(253, 332);
            this.ckb302.Margin = new System.Windows.Forms.Padding(4);
            this.ckb302.Name = "ckb302";
            this.ckb302.Size = new System.Drawing.Size(58, 23);
            this.ckb302.TabIndex = 78;
            this.ckb302.Text = "302";
            this.ckb302.UseVisualStyleBackColor = true;
            // 
            // ckb301
            // 
            this.ckb301.AutoSize = true;
            this.ckb301.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb301.Location = new System.Drawing.Point(165, 332);
            this.ckb301.Margin = new System.Windows.Forms.Padding(4);
            this.ckb301.Name = "ckb301";
            this.ckb301.Size = new System.Drawing.Size(58, 23);
            this.ckb301.TabIndex = 77;
            this.ckb301.Text = "301";
            this.ckb301.UseVisualStyleBackColor = true;
            // 
            // ckb202
            // 
            this.ckb202.AutoSize = true;
            this.ckb202.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb202.Location = new System.Drawing.Point(253, 305);
            this.ckb202.Margin = new System.Windows.Forms.Padding(4);
            this.ckb202.Name = "ckb202";
            this.ckb202.Size = new System.Drawing.Size(58, 23);
            this.ckb202.TabIndex = 76;
            this.ckb202.Text = "202";
            this.ckb202.UseVisualStyleBackColor = true;
            // 
            // ckb201
            // 
            this.ckb201.AutoSize = true;
            this.ckb201.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb201.Location = new System.Drawing.Point(165, 305);
            this.ckb201.Margin = new System.Windows.Forms.Padding(4);
            this.ckb201.Name = "ckb201";
            this.ckb201.Size = new System.Drawing.Size(58, 23);
            this.ckb201.TabIndex = 75;
            this.ckb201.Text = "201";
            this.ckb201.UseVisualStyleBackColor = true;
            // 
            // ckb102
            // 
            this.ckb102.AutoSize = true;
            this.ckb102.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb102.Location = new System.Drawing.Point(253, 276);
            this.ckb102.Margin = new System.Windows.Forms.Padding(4);
            this.ckb102.Name = "ckb102";
            this.ckb102.Size = new System.Drawing.Size(58, 23);
            this.ckb102.TabIndex = 74;
            this.ckb102.Text = "102";
            this.ckb102.UseVisualStyleBackColor = true;
            // 
            // ckb101
            // 
            this.ckb101.AutoSize = true;
            this.ckb101.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb101.Location = new System.Drawing.Point(165, 276);
            this.ckb101.Margin = new System.Windows.Forms.Padding(4);
            this.ckb101.Name = "ckb101";
            this.ckb101.Size = new System.Drawing.Size(58, 23);
            this.ckb101.TabIndex = 73;
            this.ckb101.Text = "101";
            this.ckb101.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(56, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Mã phòng:";
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnC.Location = new System.Drawing.Point(387, 123);
            this.rbtnC.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(79, 23);
            this.rbtnC.TabIndex = 71;
            this.rbtnC.Text = "Deluxe";
            this.rbtnC.UseVisualStyleBackColor = true;
            this.rbtnC.Click += new System.EventHandler(this.rbtnC_CheckedChanged);
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnB.Location = new System.Drawing.Point(276, 123);
            this.rbtnB.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(93, 23);
            this.rbtnB.TabIndex = 70;
            this.rbtnB.Text = "Superior";
            this.rbtnB.UseVisualStyleBackColor = true;
            this.rbtnB.Click += new System.EventHandler(this.rbtnB_CheckedChanged);
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnA.Location = new System.Drawing.Point(165, 125);
            this.rbtnA.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(96, 23);
            this.rbtnA.TabIndex = 69;
            this.rbtnA.Text = "Standard";
            this.rbtnA.UseVisualStyleBackColor = true;
            this.rbtnA.Click += new System.EventHandler(this.rbtnA_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(56, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "Loại phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh mục phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "VND";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Control;
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(168, 182);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(149, 27);
            this.txtDonGia.TabIndex = 65;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Gray;
            this.btnThoat.Location = new System.Drawing.Point(828, 703);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 46);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Gray;
            this.btnMenu.Location = new System.Drawing.Point(57, 703);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(168, 46);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Quay lại ";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(192)))), ((int)(((byte)(156)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(719, 703);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 46);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(56, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 61;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(56, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "Đơn giá:";
            // 
            // DanhMucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 768);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lsvDanhMucPhong);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.ckb309);
            this.Controls.Add(this.ckb209);
            this.Controls.Add(this.ckb109);
            this.Controls.Add(this.ckb308);
            this.Controls.Add(this.ckb208);
            this.Controls.Add(this.ckb108);
            this.Controls.Add(this.ckb306);
            this.Controls.Add(this.ckb206);
            this.Controls.Add(this.ckb106);
            this.Controls.Add(this.ckb307);
            this.Controls.Add(this.ckb207);
            this.Controls.Add(this.ckb107);
            this.Controls.Add(this.ckb305);
            this.Controls.Add(this.ckb205);
            this.Controls.Add(this.ckb105);
            this.Controls.Add(this.ckb304);
            this.Controls.Add(this.ckb204);
            this.Controls.Add(this.ckb104);
            this.Controls.Add(this.ckb303);
            this.Controls.Add(this.ckb203);
            this.Controls.Add(this.ckb103);
            this.Controls.Add(this.ckb302);
            this.Controls.Add(this.ckb301);
            this.Controls.Add(this.ckb202);
            this.Controls.Add(this.ckb201);
            this.Controls.Add(this.ckb102);
            this.Controls.Add(this.ckb101);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnC);
            this.Controls.Add(this.rbtnB);
            this.Controls.Add(this.rbtnA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DanhMucPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DanhMucPhong_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb101;
        private System.Windows.Forms.CheckBox ckb102;
        private System.Windows.Forms.CheckBox ckb103;
        private System.Windows.Forms.CheckBox ckb104;
        private System.Windows.Forms.CheckBox ckb105;
        private System.Windows.Forms.CheckBox ckb106;
        private System.Windows.Forms.CheckBox ckb107;
        private System.Windows.Forms.CheckBox ckb108;
        private System.Windows.Forms.CheckBox ckb109;
        private System.Windows.Forms.CheckBox ckb201;
        private System.Windows.Forms.CheckBox ckb202;
        private System.Windows.Forms.CheckBox ckb203;
        private System.Windows.Forms.CheckBox ckb204;
        private System.Windows.Forms.CheckBox ckb205;
        private System.Windows.Forms.CheckBox ckb207;
        private System.Windows.Forms.CheckBox ckb206;
        private System.Windows.Forms.CheckBox ckb208;
        private System.Windows.Forms.CheckBox ckb209;
        private System.Windows.Forms.CheckBox ckb301;
        private System.Windows.Forms.CheckBox ckb302;
        private System.Windows.Forms.CheckBox ckb303;
        private System.Windows.Forms.CheckBox ckb304;
        private System.Windows.Forms.CheckBox ckb305;
        private System.Windows.Forms.CheckBox ckb307;
        private System.Windows.Forms.CheckBox ckb306;
        private System.Windows.Forms.CheckBox ckb308;
        private System.Windows.Forms.CheckBox ckb309;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ListView lsvDanhMucPhong;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ColumnHeader clnPhong;
        private System.Windows.Forms.ColumnHeader clnLoaiPhong;
        private System.Windows.Forms.ColumnHeader clnDonGia;
        private System.Windows.Forms.ColumnHeader clnGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDatLai;
      
    }
}