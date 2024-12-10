using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormCustomer
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent(); 
        }
        private Form currentChildForm;

        //Sự kiện hiển thị form con bên trong form cha
        private void OpenChillForm(Form ChildForm)
        {

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            //sự kiện lam cho phan ben trên ẩn đi
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel12.Controls.Add(ChildForm);
            panel12.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChillForm(new Home());
        }
        private void btnAddress_Click(object sender, EventArgs e)
        {
            OpenChillForm(new DiaChi());
        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChillForm(new GioHang());
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChillForm(new LichSu());
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChillForm(new ThongTinCaNhan());
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn trở về trang đăng nhập không?",
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
    }
}
