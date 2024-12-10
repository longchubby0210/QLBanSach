using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormMaster
{
    public partial class QuanTri : Form
    {
        private NguoiDung taiKhoan;
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        
        public QuanTri(NguoiDung user)
        {
            InitializeComponent();
            taiKhoan = user;
        }
        
        private void btn_QLNguoiDung_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNguoiDung quanLyNguoiDung = new QuanLyNguoiDung();
            quanLyNguoiDung.Show();
        }
        
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát khỏi trang quản trị không?",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
            }
        }

        private void btn_QLSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySach quanLySach = new QuanLySach();
            quanLySach.Show();
        }

        private void btn_QLHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon quanLyHoaDon = new QuanLyHoaDon();
            quanLyHoaDon.Show();
        }

        private void btn_ThongTinTK_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ThongTinTaiKhoan thongTinTaiKhoan = new ThongTinTaiKhoan(this.taiKhoan);
            thongTinTaiKhoan.Show();
        }
    }
}
