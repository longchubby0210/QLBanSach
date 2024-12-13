﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DTO;
using GUI.FormCustomer;
using GUI.FormMaster;
namespace GUI
{
    public partial class DangNhap : Form
    {
        private NguoiDung taiKhoan;
        private TaiKhoanBLL taiKhoanBLL;
        public DangNhap()
        {
            InitializeComponent();
            //Làm mất backgroud của lbl
            lblHeaderLogin.Parent = picLogin;
            lblHeaderLogin.BackColor = Color.Transparent;
            lblPassword.Parent = picLogin;
            lblPassword.BackColor = Color.Transparent;
            lblUsername.Parent = picLogin;
            lblUsername.BackColor = Color.Transparent;
            chkShowPass.Parent = picLogin;
            chkShowPass.BackColor = Color.Transparent;
            llblFogotPass.Parent = picLogin;
            llblFogotPass.BackColor = Color.Transparent;
            
        }

        // sự kiện nuts đâng ký
        private void btnDegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
           this.Show();
            
        }

        // sự kiện đăng nhập
        NguoiDung user = new NguoiDung();
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        Info_Account_MngBLL info_Account = new Info_Account_MngBLL();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            user.Username = txtUsername.Text;
            user.Pass = txtPassword.Text;
            string checkUser = tkBLL.CheckLogin(user);
            
            // check các sự kiện đăng nhập lấy từ BLL-TaiKhoanBLL
            switch (checkUser)
            {
                case "sukien_taikhoan":
                    {
                        MessageBox.Show("Tài khoản không được để trống!");
                        return;
                    }
                case "sukien_matkhau":
                    {
                        MessageBox.Show("Mật khẩu không được để trống!");
                        return;
                    }
                case "taikhoan_fail":
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                        return;
                    }
            }

            MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công");

            this.Hide();
            int maQuyen = user.getMaQuyen();  // Lấy giá trị MaQuyen từ đối tượng user

            if (maQuyen == 0)
            {
                // Nếu MaQuyen = 0, người dùng sẽ vào Trang Chủ
                TrangChu trangChu = new TrangChu();
                trangChu.Show();  
                this.Hide();       
            }
            else if (maQuyen == 1)
            {
                // Nếu MaQuyen = 1, người dùng sẽ vào trang Quản Trị
                QuanTri quanTri = new QuanTri(user);
                quanTri.Show();  
                this.Hide();     
            }
            else
            {
                // Kiểm tra với các mã quyền khác nếu có
                MessageBox.Show("Mã quyền không hợp lệ.");
            }
        }
        // Hiển thị password khi click vào sự kiện hiện mật khẩu
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked == true || txtPassword.PasswordChar == '*') 
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void llblFogotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chúc mừng bạn đã quay vào ô mất tài khoản -.-\n XIN CHIA BUỒN");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
