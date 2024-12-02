namespace GUI
{
    partial class DangKy
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
            this.picBackRegister = new System.Windows.Forms.PictureBox();
            this.lblHeaderRegister = new System.Windows.Forms.Label();
            this.grbRegister = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.comboGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnBackLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackRegister)).BeginInit();
            this.grbRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackRegister
            // 
            this.picBackRegister.BackColor = System.Drawing.Color.PaleTurquoise;
            this.picBackRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackRegister.Location = new System.Drawing.Point(0, 0);
            this.picBackRegister.Name = "picBackRegister";
            this.picBackRegister.Size = new System.Drawing.Size(721, 444);
            this.picBackRegister.TabIndex = 0;
            this.picBackRegister.TabStop = false;
            // 
            // lblHeaderRegister
            // 
            this.lblHeaderRegister.AutoSize = true;
            this.lblHeaderRegister.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblHeaderRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeaderRegister.Location = new System.Drawing.Point(240, 6);
            this.lblHeaderRegister.Name = "lblHeaderRegister";
            this.lblHeaderRegister.Size = new System.Drawing.Size(218, 29);
            this.lblHeaderRegister.TabIndex = 1;
            this.lblHeaderRegister.Text = "Đăng ký tài khoản";
            // 
            // grbRegister
            // 
            this.grbRegister.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grbRegister.Controls.Add(this.dtpNgaySinh);
            this.grbRegister.Controls.Add(this.comboGioiTinh);
            this.grbRegister.Controls.Add(this.btnRegister);
            this.grbRegister.Controls.Add(this.txtSoDienThoai);
            this.grbRegister.Controls.Add(this.lblSoDienThoai);
            this.grbRegister.Controls.Add(this.txtDiaChi);
            this.grbRegister.Controls.Add(this.lblDiaChi);
            this.grbRegister.Controls.Add(this.lblGioiTinh);
            this.grbRegister.Controls.Add(this.lblNamSinh);
            this.grbRegister.Controls.Add(this.txtFullname);
            this.grbRegister.Controls.Add(this.lblFullname);
            this.grbRegister.Controls.Add(this.txtpassword);
            this.grbRegister.Controls.Add(this.lblPassword);
            this.grbRegister.Controls.Add(this.txtUsername);
            this.grbRegister.Controls.Add(this.lblUsername);
            this.grbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbRegister.Location = new System.Drawing.Point(64, 41);
            this.grbRegister.Name = "grbRegister";
            this.grbRegister.Size = new System.Drawing.Size(572, 341);
            this.grbRegister.TabIndex = 2;
            this.grbRegister.TabStop = false;
            this.grbRegister.Text = "Điền Thông Tin Tài Khoản";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpNgaySinh.CustomFormat = "";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(277, 137);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 26);
            this.dtpNgaySinh.TabIndex = 16;
            this.dtpNgaySinh.Value = new System.DateTime(2024, 11, 27, 19, 30, 15, 0);
            // 
            // comboGioiTinh
            // 
            this.comboGioiTinh.BackColor = System.Drawing.SystemColors.Window;
            this.comboGioiTinh.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboGioiTinh.FormattingEnabled = true;
            this.comboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboGioiTinh.Location = new System.Drawing.Point(276, 174);
            this.comboGioiTinh.Name = "comboGioiTinh";
            this.comboGioiTinh.Size = new System.Drawing.Size(200, 28);
            this.comboGioiTinh.TabIndex = 15;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(231, 291);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 31);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoDienThoai.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSoDienThoai.Location = new System.Drawing.Point(277, 248);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 26);
            this.txtSoDienThoai.TabIndex = 13;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(138, 254);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(120, 20);
            this.lblSoDienThoai.TabIndex = 12;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDiaChi.Location = new System.Drawing.Point(277, 212);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 26);
            this.txtDiaChi.TabIndex = 11;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(139, 215);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(74, 20);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(139, 180);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(86, 20);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính :";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamSinh.Location = new System.Drawing.Point(139, 138);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(93, 20);
            this.lblNamSinh.TabIndex = 6;
            this.lblNamSinh.Text = "Năm sinh :";
            // 
            // txtFullname
            // 
            this.txtFullname.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtFullname.Location = new System.Drawing.Point(277, 104);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(200, 26);
            this.txtFullname.TabIndex = 5;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(139, 104);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(96, 20);
            this.lblFullname.TabIndex = 4;
            this.lblFullname.Text = "Họ và tên :";
            // 
            // txtpassword
            // 
            this.txtpassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtpassword.Location = new System.Drawing.Point(277, 69);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(200, 26);
            this.txtpassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(139, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtUsername.Location = new System.Drawing.Point(276, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(138, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username :";
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBackLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackLogin.Location = new System.Drawing.Point(608, 5);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(105, 29);
            this.btnBackLogin.TabIndex = 3;
            this.btnBackLogin.Text = "Trở Lại";
            this.btnBackLogin.UseVisualStyleBackColor = false;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 444);
            this.Controls.Add(this.btnBackLogin);
            this.Controls.Add(this.grbRegister);
            this.Controls.Add(this.lblHeaderRegister);
            this.Controls.Add(this.picBackRegister);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKy";
            ((System.ComponentModel.ISupportInitialize)(this.picBackRegister)).EndInit();
            this.grbRegister.ResumeLayout(false);
            this.grbRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackRegister;
        private System.Windows.Forms.Label lblHeaderRegister;
        private System.Windows.Forms.GroupBox grbRegister;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBackLogin;
        private System.Windows.Forms.ComboBox comboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}