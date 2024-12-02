using System.Drawing;

namespace GUI
{
    partial class DangNhap
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblHeaderLogin = new System.Windows.Forms.Label();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.llblFogotPass = new System.Windows.Forms.LinkLabel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.picLoginAvt = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginAvt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Location = new System.Drawing.Point(283, 140);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 24);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(283, 189);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 24);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(418, 140);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(168, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(418, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(168, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // btnDegister
            // 
            this.btnDegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDegister.Location = new System.Drawing.Point(307, 275);
            this.btnDegister.Name = "btnDegister";
            this.btnDegister.Size = new System.Drawing.Size(87, 28);
            this.btnDegister.TabIndex = 5;
            this.btnDegister.Text = "Đăng Ký";
            this.btnDegister.UseVisualStyleBackColor = true;
            this.btnDegister.Click += new System.EventHandler(this.btnDegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(456, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 28);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHeaderLogin
            // 
            this.lblHeaderLogin.AutoSize = true;
            this.lblHeaderLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeaderLogin.Location = new System.Drawing.Point(155, 32);
            this.lblHeaderLogin.Name = "lblHeaderLogin";
            this.lblHeaderLogin.Size = new System.Drawing.Size(388, 29);
            this.lblHeaderLogin.TabIndex = 8;
            this.lblHeaderLogin.Text = "Welcome to Book Store Group 4";
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPass.Location = new System.Drawing.Point(418, 233);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(149, 22);
            this.chkShowPass.TabIndex = 9;
            this.chkShowPass.Text = "Show Password";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // llblFogotPass
            // 
            this.llblFogotPass.AutoSize = true;
            this.llblFogotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblFogotPass.LinkColor = System.Drawing.SystemColors.Desktop;
            this.llblFogotPass.Location = new System.Drawing.Point(351, 332);
            this.llblFogotPass.Name = "llblFogotPass";
            this.llblFogotPass.Size = new System.Drawing.Size(161, 22);
            this.llblFogotPass.TabIndex = 10;
            this.llblFogotPass.TabStop = true;
            this.llblFogotPass.Text = "Forgot Password";
            this.llblFogotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblFogotPass_LinkClicked);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.picLoginAvt);
            this.panelLogin.Location = new System.Drawing.Point(21, 150);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(242, 153);
            this.panelLogin.TabIndex = 11;
            // 
            // picLoginAvt
            // 
            this.picLoginAvt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLoginAvt.Image = global::GUI.Properties.Resources.book_login;
            this.picLoginAvt.Location = new System.Drawing.Point(0, 0);
            this.picLoginAvt.Name = "picLoginAvt";
            this.picLoginAvt.Size = new System.Drawing.Size(242, 153);
            this.picLoginAvt.TabIndex = 0;
            this.picLoginAvt.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogin.Image = global::GUI.Properties.Resources.bgr_book1;
            this.picLogin.Location = new System.Drawing.Point(0, 0);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(734, 411);
            this.picLogin.TabIndex = 7;
            this.picLogin.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.llblFogotPass);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.lblHeaderLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnDegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginAvt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Label lblHeaderLogin;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.LinkLabel llblFogotPass;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox picLoginAvt;
    }
}