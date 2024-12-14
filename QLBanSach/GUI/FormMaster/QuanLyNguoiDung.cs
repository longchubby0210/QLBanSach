using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormMaster
{
    public partial class QuanLyNguoiDung : Form
    {
        private NguoiDung taiKhoan;
        private DataTable dtNguoiDung;
        private NguoiDungBLL taiKhoanBLL;
        private NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
        NguoiDung users = new NguoiDung();
        public QuanLyNguoiDung()
        {
            // Khởi tạo BLL
            taiKhoanBLL = new NguoiDungBLL();
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có trở về trang quản trị không?",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
                QuanTri quanTri = new QuanTri(this.taiKhoan);
                quanTri.Show();
            }
        }
        //sự kiện xóa thông tin chi tiết
        private void XoaThongTin()
        {
            txtUser.Clear();
            txtPass.Clear();
            txtHoTen.Clear();
            txtMaQuyen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
        }

        
        //sự kiện hiển thị thông tin người dùng bằng datatable
        public void HienThiThongTin()
        {
            dtNguoiDung = nguoiDungBLL.HienThiDuLieuUser();
            dgvThongTinNguoiDung.DataSource = dtNguoiDung;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            grbThongTinChiTiet.Enabled = true;
            chucNang = 1; 
            XoaThongTin();
            txtUser.ReadOnly = false;
        }
        private void ThemSinhVien()
        {
            NguoiDungBLL tkBLL = new NguoiDungBLL();
            // Khởi tạo đối tượng users
            NguoiDung users = new NguoiDung();
            users.Username = txtUser.Text;
            users.Pass = txtPass.Text;
            users.HoVaTen = txtHoTen.Text;
            users.MaQuyen = int.Parse(txtMaQuyen.Text);
            users.DiaChi = txtDiaChi.Text;
            users.SoDienThoai = txtSoDienThoai.Text;

            // Kiểm tra giới tính
            if (cbGioiTinh.SelectedIndex == 0)
                users.GioiTinh = "Nam";
            else if (cbGioiTinh.SelectedIndex == 1)
                users.GioiTinh = "Nữ";
            users.NamSinh = dtpNamSinh.Value;
            // sự kiện thêm người dùng
            string add_OK = tkBLL.ThemNguoiDung(users);
            // sự kiện cái giá trị rỗng thì trả về k xác định
            if (add_OK == null)
            {
                MessageBox.Show("Lỗi không xác định");
                return;
            }

            // Xử lý kết quả
            switch (add_OK)
            {
                case "name_error":
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin người dùng.Mời bạn kiểm tra lại thông tin!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                case "add_Success":
                    MessageBox.Show("Chúc mừng bạn thêm thành công người dùng!");
                    HienThiThongTin();
                    XoaThongTin();
                    return;
                case "error_Add_Success":
                    MessageBox.Show("Lỗi khi thêm người dùng!");
                    return;
                default:
                    MessageBox.Show("Kết quả không xác định: " + add_OK);
                    return;
            }
        }
        private void SuaTTSinhVien()
        {
            NguoiDungBLL tkBLL = new NguoiDungBLL();
            // Khởi tạo đối tượng users
            NguoiDung users = new NguoiDung();
            users.Username = txtUser.Text;
            users.Pass = txtPass.Text;
            users.HoVaTen = txtHoTen.Text;
            users.MaQuyen = int.Parse(txtMaQuyen.Text);
            users.DiaChi = txtDiaChi.Text;
            users.SoDienThoai = txtSoDienThoai.Text;

            // Kiểm tra giới tính
            if (cbGioiTinh.SelectedIndex == 0)
                users.GioiTinh = "Nam";
            else if (cbGioiTinh.SelectedIndex == 1)
                users.GioiTinh = "Nữ";

            users.NamSinh = dtpNamSinh.Value;
            // sự kiện chỉnh sửa thông tin người dùng

            string Edit_OK = tkBLL.SuaTTNguoiDung(users);
            if (Edit_OK == null)
            {
                MessageBox.Show("Lỗi không xác định");
            }
            switch (Edit_OK)
            {
                case "edit_Success":
                    {
                        MessageBox.Show("Chỉnh sửa thông tin người dùng thành công!");
                        XoaThongTin();
                        HienThiThongTin();

                        grbThongTinChiTiet.Enabled = false;
                        btn_Sua.Enabled = false;
                        btn_Xoa.Enabled = false;
                        return;
                    }
                case "error_Edit_Success":
                    {
                        MessageBox.Show("Lỗi khi chỉnh sửa người dùng!");
                        return;
                    }
                case "editUser_error_null":
                    {
                        MessageBox.Show("Rỗng");
                        return;
                    }
                default:
                    MessageBox.Show("Lỗi không xác định được: " + Edit_OK);
                    return;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            chucNang = 2;
            grbThongTinChiTiet.Enabled = true;
            txtUser.ReadOnly = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
             XoaDuLieuUser();
        }

        private void XoaDuLieuUser()
        {
               
                DataGridViewRow selectedRow = dgvThongTinNguoiDung.SelectedRows[0];
                string usernameToDelete = selectedRow.Cells["Username"].Value.ToString();
                // Gọi phương thức xóa từ lớp BLL
                NguoiDungBLL tkBLL = new NguoiDungBLL();
                string Delete_OK = tkBLL.XoaTTNguoiDung(usernameToDelete);

                switch (Delete_OK)
                {
                    case "delete_Success":
                        MessageBox.Show("Xóa người dùng thành công!");
                        HienThiThongTin();  // Cập nhật lại DataGridView
                        btn_Sua.Enabled = false;
                        btn_Xoa.Enabled = false;
                        break;
                    case "error_Delete_Success":
                        MessageBox.Show("Lỗi khi xóa người dùng.");
                        break;
                    default:
                        MessageBox.Show("Có lỗi xảy ra.");
                        break;
                }
            
        }

        int chucNang = 0;
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(chucNang == 1)
            {
                ThemSinhVien();
            }
            if(chucNang == 2)
            {
                SuaTTSinhVien();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn hủy bỏ thay đổi này không",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(rs == DialogResult.Yes)
            {
                XoaThongTin();
                grbThongTinChiTiet.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }    
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string Users = txtTKUser.Text.Trim();
                string HoTen = txtTKHoTen.Text.Trim();
                DataTable dtUser = taiKhoanBLL.TimKiemUsers(Users);
                DataTable dtHoTen = taiKhoanBLL.TimKiemUser(HoTen);
                if (dtUser.Rows.Count > 0 )
                {
                    dgvThongTinNguoiDung.DataSource = dtUser;
                   
                }
                else if(dtHoTen.Rows.Count > 0)
                {
                    dgvThongTinNguoiDung.DataSource = dtHoTen;
                }    
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin người dùng");
                    dgvThongTinNguoiDung.DataSource = dtNguoiDung;
                }
            }
            catch(Exception ex)  
            {
                MessageBox.Show("Lỗi :"+ ex.Message);
            }
        }
        
        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            grbThongTinChiTiet.Enabled = false;
            
        }
        int vt = -1;

        private void dgvThongTinNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if(vt == -1) return;
           
            dgvThongTinNguoiDung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataRow dtRow = dtNguoiDung.Rows[vt]; 
            // gán giá trị NguoiDung vào các ô textbox
            txtUser.Text=dtRow["Username"].ToString().Trim() ;
            txtPass.Text= dtRow["Pass"].ToString().Trim();
            txtMaQuyen.Text = dtRow["MaQuyen"].ToString().Trim();
             txtHoTen.Text = dtRow["HoVaTen"].ToString().Trim();
            string[] a = dtRow["NamSinh"].ToString().Trim().Split(' ');
            string[] ns = a[0].Split('/');
            dtpNamSinh.Value = new DateTime(int.Parse(ns[2]), int.Parse(ns[0]), int.Parse(ns[1]));
            if (dtRow["GioiTinh"].ToString().Trim() == "Nam")
                cbGioiTinh.SelectedIndex = 0;
            else if (dtRow["GioiTinh"].ToString().Trim() == "Nữ")
                cbGioiTinh.SelectedIndex = 1;
            txtDiaChi.Text = dtRow["DiaChi"].ToString().Trim();
            txtSoDienThoai.Text = dtRow["SoDienThoai"].ToString().Trim();
            
            //hien thi button sửa và xóa
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            grbThongTinChiTiet.Enabled = false;
        }
    }
}
