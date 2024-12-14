namespace GUI.FormMaster
{
    partial class QuanLyNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNguoiDung));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grbThongTinNguoiDung = new System.Windows.Forms.GroupBox();
            this.dgvThongTinNguoiDung = new System.Windows.Forms.DataGridView();
            this.MaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txtTKHoTen = new System.Windows.Forms.TextBox();
            this.lblTKHoTen = new System.Windows.Forms.Label();
            this.txtTKUser = new System.Windows.Forms.TextBox();
            this.lblTKUser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaQuyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grbThongTinNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNguoiDung)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbThongTinChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 519);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Thoat);
            this.panel6.Controls.Add(this.btn_Xoa);
            this.panel6.Controls.Add(this.btn_Sua);
            this.panel6.Controls.Add(this.btn_Them);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 439);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(777, 80);
            this.panel6.TabIndex = 3;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Thoat.Image = global::GUI.Properties.Resources.log_out;
            this.btn_Thoat.Location = new System.Drawing.Point(662, 16);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(86, 52);
            this.btn_Thoat.TabIndex = 19;
            this.btn_Thoat.Text = "Exit";
            this.btn_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Xoa.Image = global::GUI.Properties.Resources.delete;
            this.btn_Xoa.Location = new System.Drawing.Point(493, 16);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 52);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Sua.Image = global::GUI.Properties.Resources.edit;
            this.btn_Sua.Location = new System.Drawing.Point(257, 16);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(91, 52);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Them.Image = global::GUI.Properties.Resources.user;
            this.btn_Them.Location = new System.Drawing.Point(40, 16);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 52);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grbThongTinNguoiDung);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(777, 330);
            this.panel5.TabIndex = 2;
            // 
            // grbThongTinNguoiDung
            // 
            this.grbThongTinNguoiDung.Controls.Add(this.dgvThongTinNguoiDung);
            this.grbThongTinNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinNguoiDung.Name = "grbThongTinNguoiDung";
            this.grbThongTinNguoiDung.Size = new System.Drawing.Size(777, 330);
            this.grbThongTinNguoiDung.TabIndex = 0;
            this.grbThongTinNguoiDung.TabStop = false;
            this.grbThongTinNguoiDung.Text = "Thông Tin Người Dùng";
            // 
            // dgvThongTinNguoiDung
            // 
            this.dgvThongTinNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaND,
            this.Username,
            this.Pass,
            this.MaQuyen,
            this.HoVaTen,
            this.NamSinh,
            this.GioiTinh,
            this.DiaChi,
            this.SoDienThoai});
            this.dgvThongTinNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinNguoiDung.Location = new System.Drawing.Point(3, 19);
            this.dgvThongTinNguoiDung.Name = "dgvThongTinNguoiDung";
            this.dgvThongTinNguoiDung.Size = new System.Drawing.Size(771, 308);
            this.dgvThongTinNguoiDung.TabIndex = 0;
            this.dgvThongTinNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNguoiDung_CellContentClick);
            // 
            // MaND
            // 
            this.MaND.DataPropertyName = "MaND";
            this.MaND.HeaderText = "Mã ND";
            this.MaND.Name = "MaND";
            this.MaND.Width = 40;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 80;
            // 
            // Pass
            // 
            this.Pass.DataPropertyName = "Pass";
            this.Pass.HeaderText = "Password";
            this.Pass.Name = "Pass";
            this.Pass.Width = 80;
            // 
            // MaQuyen
            // 
            this.MaQuyen.DataPropertyName = "MaQuyen";
            this.MaQuyen.HeaderText = "Mã Quyền";
            this.MaQuyen.Name = "MaQuyen";
            this.MaQuyen.Width = 60;
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Họ Tên";
            this.HoVaTen.Name = "HoVaTen";
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm Sinh";
            this.NamSinh.Name = "NamSinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 90;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 80;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_TimKiem);
            this.panel4.Controls.Add(this.txtTKHoTen);
            this.panel4.Controls.Add(this.lblTKHoTen);
            this.panel4.Controls.Add(this.txtTKUser);
            this.panel4.Controls.Add(this.lblTKUser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(777, 51);
            this.panel4.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(533, 9);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 32);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txtTKHoTen
            // 
            this.txtTKHoTen.Location = new System.Drawing.Point(342, 14);
            this.txtTKHoTen.Name = "txtTKHoTen";
            this.txtTKHoTen.Size = new System.Drawing.Size(133, 23);
            this.txtTKHoTen.TabIndex = 3;
            // 
            // lblTKHoTen
            // 
            this.lblTKHoTen.AutoSize = true;
            this.lblTKHoTen.Location = new System.Drawing.Point(254, 17);
            this.lblTKHoTen.Name = "lblTKHoTen";
            this.lblTKHoTen.Size = new System.Drawing.Size(63, 17);
            this.lblTKHoTen.TabIndex = 2;
            this.lblTKHoTen.Text = "Họ Tên :";
            // 
            // txtTKUser
            // 
            this.txtTKUser.Location = new System.Drawing.Point(103, 14);
            this.txtTKUser.Name = "txtTKUser";
            this.txtTKUser.Size = new System.Drawing.Size(133, 23);
            this.txtTKUser.TabIndex = 1;
            // 
            // lblTKUser
            // 
            this.lblTKUser.AutoSize = true;
            this.lblTKUser.Location = new System.Drawing.Point(16, 15);
            this.lblTKUser.Name = "lblTKUser";
            this.lblTKUser.Size = new System.Drawing.Size(81, 17);
            this.lblTKUser.TabIndex = 0;
            this.lblTKUser.Text = "Username :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 58);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(279, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Người Dùng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grbThongTinChiTiet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(777, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 519);
            this.panel2.TabIndex = 1;
            // 
            // grbThongTinChiTiet
            // 
            this.grbThongTinChiTiet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbThongTinChiTiet.Controls.Add(this.btn_Huy);
            this.grbThongTinChiTiet.Controls.Add(this.btn_Luu);
            this.grbThongTinChiTiet.Controls.Add(this.cbGioiTinh);
            this.grbThongTinChiTiet.Controls.Add(this.dtpNamSinh);
            this.grbThongTinChiTiet.Controls.Add(this.label9);
            this.grbThongTinChiTiet.Controls.Add(this.txtSoDienThoai);
            this.grbThongTinChiTiet.Controls.Add(this.label8);
            this.grbThongTinChiTiet.Controls.Add(this.txtDiaChi);
            this.grbThongTinChiTiet.Controls.Add(this.label7);
            this.grbThongTinChiTiet.Controls.Add(this.label6);
            this.grbThongTinChiTiet.Controls.Add(this.txtMaQuyen);
            this.grbThongTinChiTiet.Controls.Add(this.label5);
            this.grbThongTinChiTiet.Controls.Add(this.txtHoTen);
            this.grbThongTinChiTiet.Controls.Add(this.label4);
            this.grbThongTinChiTiet.Controls.Add(this.txtPass);
            this.grbThongTinChiTiet.Controls.Add(this.label3);
            this.grbThongTinChiTiet.Controls.Add(this.txtUser);
            this.grbThongTinChiTiet.Controls.Add(this.label2);
            this.grbThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinChiTiet.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinChiTiet.Name = "grbThongTinChiTiet";
            this.grbThongTinChiTiet.Size = new System.Drawing.Size(291, 519);
            this.grbThongTinChiTiet.TabIndex = 0;
            this.grbThongTinChiTiet.TabStop = false;
            this.grbThongTinChiTiet.Text = "Thông Tin Chi Tiết";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Image = global::GUI.Properties.Resources.multiply__1_;
            this.btn_Huy.Location = new System.Drawing.Point(176, 439);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(84, 51);
            this.btn_Huy.TabIndex = 18;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Image = global::GUI.Properties.Resources.diskette;
            this.btn_Luu.Location = new System.Drawing.Point(43, 439);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(82, 51);
            this.btn_Luu.TabIndex = 17;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(136, 291);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 24);
            this.cbGioiTinh.TabIndex = 16;
            // 
            // dtpNamSinh
            // 
            this.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNamSinh.Location = new System.Drawing.Point(136, 250);
            this.dtpNamSinh.Name = "dtpNamSinh";
            this.dtpNamSinh.Size = new System.Drawing.Size(124, 23);
            this.dtpNamSinh.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Năm Sinh : ";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(136, 378);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(124, 23);
            this.txtSoDienThoai.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số Điện Thoại : ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(136, 334);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(124, 23);
            this.txtDiaChi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Địa Chỉ : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giới Tính : ";
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.Location = new System.Drawing.Point(136, 161);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Size = new System.Drawing.Size(124, 23);
            this.txtMaQuyen.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã Quyền : ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(136, 206);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(124, 23);
            this.txtHoTen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ Tên : ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(136, 116);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(124, 23);
            this.txtPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(136, 68);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(124, 23);
            this.txtUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username : ";
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản Người Dùng";
            this.Load += new System.EventHandler(this.QuanLyNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.grbThongTinNguoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNguoiDung)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.grbThongTinChiTiet.ResumeLayout(false);
            this.grbThongTinChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grbThongTinNguoiDung;
        private System.Windows.Forms.DataGridView dgvThongTinNguoiDung;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txtTKHoTen;
        private System.Windows.Forms.Label lblTKHoTen;
        private System.Windows.Forms.TextBox txtTKUser;
        private System.Windows.Forms.Label lblTKUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox grbThongTinChiTiet;
        private System.Windows.Forms.TextBox txtMaQuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNamSinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
    }
}