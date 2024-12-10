using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            //làm mất backgroud của các lbl
            lblHeaderRegister.Parent = picBackRegister;
            lblHeaderRegister.BackColor = Color.Transparent;
            grbRegister.Parent = picBackRegister;
            grbRegister.BackColor = Color.Transparent;
       
        }
        NguoiDung user = new NguoiDung();
        RegisterBLL DKBLL = new RegisterBLL();
        // sự kiện đăng ký tài khoản
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string tentk = txtUsername.Text;
            string pass = txtpassword.Text;
            
            if(comboGioiTinh.Text == "Nam")
                comboGioiTinh.SelectedIndex = 0;
            else
                comboGioiTinh.SelectedIndex = 1;
            string CheckRegister = DKBLL.CheckRegister(user);
            CheckRegister = CheckRegister.Trim();
            string ngaySinh = dtpNgaySinh.Value.Year + "-" + dtpNgaySinh.Value.Month +"-"+dtpNgaySinh.Value.Day;
            //string[] ns = dtpNgaySinh.Text.Split('/');
            //dtpNgaySinh.Value = new DateTime(int.Parse(ns[2]), int.Parse(ns[0]), int.Parse(ns[1]));---
            user.Username = txtUsername.Text;
            user.Pass = txtpassword.Text;
            user.HoVaTen = txtFullname.Text;
            user.NamSinh = DateTime.Parse(ngaySinh);
            user.GioiTinh = comboGioiTinh.Text;
            user.DiaChi = txtDiaChi.Text;
            user.SoDienThoai = txtSoDienThoai.Text;

            // Sự kiện yêu cầu người dùng nhập đúng định dạng tài khoản và mật khẩu
            if (!CheckAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản có độ dài 6-24 ký tự, với các ký tự và chữ số,chữ hoa và chữ thường!");
            }
            else if (!CheckAccount(pass))
            {
                MessageBox.Show("Vui lòng mật khẩu có độ dài 6-24 ký tự, với các ký tự và chữ số,chữ hoa và chữ thường!");
            }
            else { 
            switch (CheckRegister)
            {
                
                case "register_access":
                    {
                            XoaDuLieu();
                       DialogResult result = MessageBox.Show("Đăng ký tài khoản thành công!");
                        MessageBox.Show("Bạn có muốn trở lại trang đăng nhập không",
                            "Hỏi Thoát",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                            if(result == DialogResult.Yes)
                            {
                                Close();
                                DangNhap dangNhap = new DangNhap();
                                dangNhap.Show();
                            }
                                
                        return;
                    }
                case "register_retail":
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!");
                        return;
                    }
                case "error":
                    {
                        MessageBox.Show("Đăng ký tài khoản không thành công ");
                        return;
                    }
            }
            }
        }
        // sự kiện check xem tài khoản và mật khẩu nhập đúng định dạng chưa
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sự kiện xóa dữ liệu khi người dùng đăng ký tài khoản thành công
        private void XoaDuLieu()
        {
            txtUsername.Clear();
            txtpassword.Clear();
            txtFullname.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
        }
    }
}
