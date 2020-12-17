using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.Models;

namespace QuanLyDiem
{
    public partial class LoginForm : Form
    {
        Model1 model = new Model1();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            NguoiDung user =  model.NguoiDungs.Where(x => x.TenDangNhap == tenDN && x.MatKhau == matKhau).SingleOrDefault();
            if (user != null)
            {
                Form1 f = new Form1();
                this.Hide();
                f.Show();

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
    }
}
