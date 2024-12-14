using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI.FormMaster
{
    public partial class QuanLySach : Form
    {
        private NguoiDung taiKhoan;
        private DataTable dtSach;
        private BookBLL bookBLLs = new BookBLL();
        public QuanLySach()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
        private void HienThiThongTin()
        {
            dtSach = bookBLLs.HienThiDuLieuBook();
            dgvThongTinSach.DataSource = dtSach;
            dgvThongTinSach.Columns["Gia"].DefaultCellStyle.Format = "C2";


        }
        private void XoaThongTin()
        {
            txtTenSach.Clear();
            numberGia.Value = 0;
            numberSoLuong.Value = 0;
            txtMaSach.Clear();
            cbTheLoai.SelectedIndex = 0;
            txtDuongDanAnh.Clear();
            picImage.Image = null;
        }
        private void XoaAnh()
        {
            if (picImage.Image != null)
            {
                picImage.Image.Dispose(); //Xóa ảnh 
                picImage.Image = null;
            }
            //Xóa đường dẫn ảnh
            txtDuongDanAnh.Text = ""; 
            MessageBox.Show("Ảnh đã được xóa!");
        }
        private void QuanLySach_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            grbThongTinChiTiet.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
          
        }
        int vt = -1;
        private void dgvThongTinSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            dgvThongTinSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataRow dtRow = dtSach.Rows[vt];
            txtMaSach.Text = dtRow["MaSach"].ToString().Trim();
            txtTenSach.Text = dtRow["TenSach"].ToString().Trim();
            numberGia.Value = decimal.Parse(dtRow["Gia"].ToString().Trim());
            numberSoLuong.Value = decimal.Parse(dtRow["SoLuong"].ToString().Trim());
            string[] a = dtRow["NamSanXuat"].ToString().Trim().Split(' ');
            string[] ns = a[0].Split('/');
            dtpNamSanXuat.Value = new DateTime(int.Parse(ns[2]), int.Parse(ns[0]), int.Parse(ns[1]));
            if (dtRow["MaLoaiSach"].ToString().Trim() == "HH")
            {
                cbTheLoai.SelectedIndex = 0;
            }
            else if (dtRow["MaLoaiSach"].ToString().Trim() == "KD")
            {
                cbTheLoai.SelectedIndex = 1;
            }
            else if (dtRow["MaLoaiSach"].ToString().Trim() == "BT")
            {
                cbTheLoai.SelectedIndex = 2;
            }
            else if(dtRow["MaLoaiSach"].ToString().Trim() == "AN")
            {
                cbTheLoai.SelectedIndex = 3;
            }
            else 
                cbTheLoai.SelectedIndex = 4;
            // lấy đường dẫn ảnh từ cột "Poster"
            string relativePath = dtRow["Poster"].ToString().Trim();
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            //Kiểm tra ảnh tồn tại k
            if (File.Exists(fullPath))
            {
                // Hiển thị ảnh 
                picImage.Image = Image.FromFile(fullPath);
            }
            else
            {
                //Nếu k có ảnh trả về null
                picImage.Image = null;
            }

            grbThongTinChiTiet.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void dgvThongTinSach_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Bỏ qua lỗi DataError (do dữ liệu không đúng kiểu)
            e.ThrowException = false;
        }
       
        private void btnThemImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\User\source\repos\QLBanSach\GUI\Image";
            ofd.Title = "Chọn Ảnh";
            ofd.Filter = "Image File *.gif;*.png;*.jpg;*.jpeg;*.bmp;*.wmf)|*.gif;*.png;*.jpg;*.jpeg;*.bmp;*.wmf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picImage.ImageLocation = ofd.FileName;
                txtDuongDanAnh.Text = ofd.FileName;
            }
            if (txtDuongDanAnh.Text != "")
            {
                btnThemImg.Enabled = false;
                btnSuaImg.Enabled = true;
                btnXoaImg.Enabled = true;
            }
        }

        private void btnSuaImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //Khi mở file thì truy nhập vào thẳng đường link này
            ofd.InitialDirectory = @"C:\Users\User\source\repos\QLBanSach\GUI\Image";
            ofd.Title = "Chọn Ảnh";
            ofd.Filter = "Image File *.gif;*.png;*.jpg;*.jpeg;*.bmp;*.wmf)|*.gif;*.png;*.jpg;*.jpeg;*.bmp;*.wmf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picImage.ImageLocation = ofd.FileName;
                txtDuongDanAnh.Text = ofd.FileName;
            }
            if(picImage != null)
            {
                btnThemImg.Enabled = false;
                btnSuaImg.Enabled = true;
                btnXoaImg.Enabled = true;
            }    
        }
        private void btnXoaImg_Click(object sender, EventArgs e)
        {
            XoaAnh();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            chucNang = 1;
            grbThongTinChiTiet.Enabled = true;
            btnThemImg.Enabled = true;
            btnSuaImg.Enabled = false;
            btnXoaImg.Enabled = false;
            XoaThongTin();
            
        }
        private void ThemThongTinSach()
        {
            BookBLL bookBLL = new BookBLL();
            Sach sach = new Sach();
            
            sach.TenSach = txtTenSach.Text;
            if (cbTheLoai.SelectedIndex == 0)
            {
                sach.MaLoaiSach = "HH";// Hoat hinh
            }
            else if (cbTheLoai.SelectedIndex == 1)
            {
                sach.MaLoaiSach = "KD";//Kinh di
            }
            else if (cbTheLoai.SelectedIndex == 2)
            {
                sach.MaLoaiSach = "BT";//Bomtan
            }
            else if(cbTheLoai.SelectedIndex == 3)
            {
                sach.MaLoaiSach = "AN";
            }    
            else
            sach.MaLoaiSach = "KXD";//Khong xac dinh
            sach.NamSanXuat = dtpNamSanXuat.Value;
            sach.Gia = (int)numberGia.Value;
            sach.SoLuong = (int)numberSoLuong.Value;
            sach.Poster = txtDuongDanAnh.Text.Trim();
            // sự kiện thêm sách
            string add_OK = bookBLL.ThemSach(sach);
            switch(add_OK)
            {
                case "error_null_book":
                    {
                        MessageBox.Show("Bạn chưa điền đầy đủ thông tin.Mời bạn kiểm tra lại thông tin!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                case "error_book":
                    {
                        MessageBox.Show("Lỗi null sách!");
                        return;
                    }
                case "add_Success":
                    {
                        MessageBox.Show(" Chúc mừng bạn thêm sách thành công!");
                        HienThiThongTin();
                        XoaThongTin();
                        grbThongTinChiTiet.Enabled = false;
                        return;
                    }
                case "error_Add_Success":
                    {
                        MessageBox.Show("Lỗi Không Thêm Được Sách!");
                        return;
                    }
                default:
                    MessageBox.Show("Lỗi không xác định được" + add_OK);
                    return;
            }
        }
        private void SuaThongTinSach()
        {
            BookBLL bookBLL = new BookBLL();
            //khởi tạo đối tượng sách
            Sach sach = new Sach();
            sach.MaSach = int.Parse(txtMaSach.Text);
            sach.TenSach = txtTenSach.Text.Trim();
            if (cbTheLoai.SelectedIndex == 0)
            {
                sach.MaLoaiSach = "HH";// Hoat hinh
            }
            else if (cbTheLoai.SelectedIndex == 1)
            {
                sach.MaLoaiSach = "KD";//Kinh di
            }
            else if (cbTheLoai.SelectedIndex == 2)
            {
                sach.MaLoaiSach = "BT";//Bomtan
            }
            else if (cbTheLoai.SelectedIndex == 3)
            {
                sach.MaLoaiSach = "AN";//Anime
            }
            else
             sach.MaLoaiSach = "KXD";//Khong xac dinh

            sach.NamSanXuat = dtpNamSanXuat.Value;
            sach.Gia = (int)numberGia.Value;
            sach.SoLuong = (int)numberSoLuong.Value;
            sach.Poster = txtDuongDanAnh.Text.Trim();

            // sự kiện sửa thông tin sách
            string edit_OK = bookBLL.SuaTTSach(sach);
            // xử lý kết quả
            switch(edit_OK)
            {
                case "error_null_book":
                    {
                        MessageBox.Show("Bạn chưa điền đầy đủ thông tin.Mời bạn kiểm tra lại thông tin!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                case "error_book":
                    {
                        MessageBox.Show("Lỗi null sách!");
                        return;
                    }
                case "edit_Success":
                    {
                        MessageBox.Show("Sửa Sách Thành Công!");
                        XoaThongTin();
                        HienThiThongTin();
                        grbThongTinChiTiet.Enabled = false;
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        return;
                    }
                case "error_Edit_Success":
                    {
                        MessageBox.Show("Lỗi Sửa Sách !");
                        return;
                    }
                default:
                    MessageBox.Show("Lỗi không xác định được" + edit_OK);
                    return;
            }
        }
        int chucNang = 0;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(chucNang == 1)
            {
                ThemThongTinSach();
            }
            if(chucNang == 2)
            {
                SuaThongTinSach();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn hủy bỏ thay đổi này không",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                XoaThongTin();
                grbThongTinChiTiet.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSach();
        }
        private void XoaSach()
        {
            DataGridViewRow dataGridViewRow = dgvThongTinSach.SelectedRows[0];
            string maSachToDelete = dataGridViewRow.Cells["MaSach"].Value.ToString();
            // Gọi phương thức xóa từ lớp BLL
            BookBLL bookBLL = new BookBLL();
            string Delete_OK = bookBLL.XoaSach(maSachToDelete);
            switch (Delete_OK)
            {
                case "delete_Success":
                    MessageBox.Show("Xóa sách thành công!");
                    HienThiThongTin();  // Cập nhật lại DataGridView
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    break;
                case "error_Delete_Success":
                    MessageBox.Show("Lỗi khi xóa sách.");
                    break;
                default:
                    MessageBox.Show("Có lỗi xảy ra." + Delete_OK);
                    break;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            chucNang = 2;
            grbThongTinChiTiet.Enabled = true;
            btnThemImg.Enabled = false;
            btnXoaImg.Enabled = false;
            btnSuaImg.Enabled = true;
            
        }

        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BookBLL bookBLL = new BookBLL();
            try
            {
                string tenSach = txtTKTenSach.Text.Trim();
                string maLoaiSach = txtTKLoaiSach.Text.Trim();
                decimal gia = numberTKGia.Value;
                DataTable dtTenSach = bookBLL.TimKiemTenSach(tenSach);
                DataTable dtLoaiSach = bookBLL.TimKiemLoaiSach(maLoaiSach);
                DataTable dtGia = bookBLL.TimKiemGia(gia); 
                if(dtTenSach.Rows.Count > 0)
                {
                    dgvThongTinSach.DataSource = dtTenSach;
                }
                else if(dtLoaiSach.Rows.Count > 0)
                {
                    dgvThongTinSach.DataSource = dtLoaiSach;
                } 
                else if (dtGia.Rows.Count > 0)
                { 
                    dgvThongTinSach.DataSource= dtGia;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin sách");
                    dgvThongTinSach.DataSource = dtSach;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
        }
    }
}
