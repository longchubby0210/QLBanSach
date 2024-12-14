namespace GUI.FormMaster
{
    partial class QuanTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanTri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btn_ThongTinTK = new System.Windows.Forms.Button();
            this.btn_QLHoaDon = new System.Windows.Forms.Button();
            this.btn_QLSach = new System.Windows.Forms.Button();
            this.btn_QLNguoiDung = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 85);
            this.panel1.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Thoat.Location = new System.Drawing.Point(661, 0);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(64, 46);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Exit";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(110, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chào mừng bạn đến với BOOK STORE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Controls.Add(this.btn_ThongTinTK);
            this.panel2.Controls.Add(this.btn_QLHoaDon);
            this.panel2.Controls.Add(this.btn_QLSach);
            this.panel2.Controls.Add(this.btn_QLNguoiDung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 360);
            this.panel2.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(197, 4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(289, 29);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Chọn chức năng quản lý";
            // 
            // btn_ThongTinTK
            // 
            this.btn_ThongTinTK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ThongTinTK.Image = global::GUI.Properties.Resources.info_account;
            this.btn_ThongTinTK.Location = new System.Drawing.Point(416, 219);
            this.btn_ThongTinTK.Name = "btn_ThongTinTK";
            this.btn_ThongTinTK.Size = new System.Drawing.Size(158, 105);
            this.btn_ThongTinTK.TabIndex = 7;
            this.btn_ThongTinTK.Text = "Thông Tin Tài Khoản";
            this.btn_ThongTinTK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ThongTinTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ThongTinTK.UseVisualStyleBackColor = false;
            this.btn_ThongTinTK.Click += new System.EventHandler(this.btn_ThongTinTK_Click);
            // 
            // btn_QLHoaDon
            // 
            this.btn_QLHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLHoaDon.Image = global::GUI.Properties.Resources.usermaster;
            this.btn_QLHoaDon.Location = new System.Drawing.Point(98, 219);
            this.btn_QLHoaDon.Name = "btn_QLHoaDon";
            this.btn_QLHoaDon.Size = new System.Drawing.Size(158, 105);
            this.btn_QLHoaDon.TabIndex = 4;
            this.btn_QLHoaDon.Text = "Quản Lý Hóa Đơn";
            this.btn_QLHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_QLHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_QLHoaDon.UseVisualStyleBackColor = false;
            this.btn_QLHoaDon.Click += new System.EventHandler(this.btn_QLHoaDon_Click);
            // 
            // btn_QLSach
            // 
            this.btn_QLSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLSach.Image = global::GUI.Properties.Resources.book_mng;
            this.btn_QLSach.Location = new System.Drawing.Point(416, 57);
            this.btn_QLSach.Name = "btn_QLSach";
            this.btn_QLSach.Size = new System.Drawing.Size(158, 105);
            this.btn_QLSach.TabIndex = 3;
            this.btn_QLSach.Text = "Quản Lý Sách";
            this.btn_QLSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_QLSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_QLSach.UseVisualStyleBackColor = false;
            this.btn_QLSach.Click += new System.EventHandler(this.btn_QLSach_Click);
            // 
            // btn_QLNguoiDung
            // 
            this.btn_QLNguoiDung.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNguoiDung.Image = global::GUI.Properties.Resources.usermaster;
            this.btn_QLNguoiDung.Location = new System.Drawing.Point(98, 57);
            this.btn_QLNguoiDung.Name = "btn_QLNguoiDung";
            this.btn_QLNguoiDung.Size = new System.Drawing.Size(158, 105);
            this.btn_QLNguoiDung.TabIndex = 2;
            this.btn_QLNguoiDung.Text = "Quản Lý Người Dùng";
            this.btn_QLNguoiDung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_QLNguoiDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_QLNguoiDung.UseVisualStyleBackColor = false;
            this.btn_QLNguoiDung.Click += new System.EventHandler(this.btn_QLNguoiDung_Click);
            // 
            // QuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 445);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Trị Hệ Thống";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ThongTinTK;
        private System.Windows.Forms.Button btn_QLHoaDon;
        private System.Windows.Forms.Button btn_QLSach;
        private System.Windows.Forms.Button btn_QLNguoiDung;
        private System.Windows.Forms.Label lblHeader;
    }
}