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
    public partial class ThongTinTaiKhoan : Form
    {
        private NguoiDung taiKhoan;
        NguoiDung tk = new NguoiDung();
        Info_Account_MngBLL info_Account = new Info_Account_MngBLL();
        
        public ThongTinTaiKhoan(NguoiDung user)
        {
            InitializeComponent();
            this.taiKhoan = user;
            LoadThongTin();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có trở về trang quản trị không?",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                Close();
                QuanTri quanTri = new QuanTri(this.taiKhoan);
                quanTri.Show();
            }
        }
        
        private void LoadThongTin()
        {
            
            if (taiKhoan != null)
            {
                
                txtMaND.Text = taiKhoan.MaND.ToString();
                txtUser.Text = taiKhoan.Username;
                txtPass.Text = taiKhoan.Pass;
                txtHoTen.Text = taiKhoan.HoVaTen;
                txtQuyenHan.Text = taiKhoan.MaQuyen.ToString();
                // Gán giá trị cho ComboBox Giới Tính
                cbGioiTinh.SelectedItem = taiKhoan.GioiTinh; // Sử dụng SelectedItem thay vì Text

                // Gán ngày sinh vào DateTimePicker
                if (taiKhoan.NamSinh != DateTime.MinValue)
                {
                    try
                    {
                        dtpNamSinh.Value = taiKhoan.NamSinh;
                    }
                    catch
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                txtDiaChi.Text = taiKhoan.DiaChi;
                txtSoDienThoai.Text = taiKhoan.SoDienThoai;
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể hiển thị thông tin tài khoản!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btn_SuaTT_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
    }
}
