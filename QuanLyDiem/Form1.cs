using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.Models;

namespace QuanLyDiem
{
    public partial class Form1 : Form
    {
        static Model1 model = new Model1();
        string hoVaTen;
        DateTime ngaySinh;
        string khoa;
        string Lop;
        string tenMonHoc;
        string maMonHoc;
        string soTinChi;
        string thiGiuaKy;
        string chuyenCan;
        string cuoiKi;
        string trungBinh;

        int id = -1;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SinhVien> sinhViens = model.SinhViens.Where(x => x.MaSV != 0).ToList();
            dtSinhVien.DataSource = sinhViens;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

            //MessageBox.Show(dateTimePicker1.Value.ToShortDateString().ToString());
        }

        private void dtSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dtSinhVien.Rows[index];
                txtHoten.Text = selectRow.Cells[1].Value.ToString().Trim();
                dateTimePicker1.Text = selectRow.Cells[2].Value.ToString().Trim();
                txtKhoa.Text = selectRow.Cells[3].Value.ToString().Trim();
                txtLop.Text = selectRow.Cells[4].Value.ToString().Trim();
                txtTenmonhoc.Text = selectRow.Cells[5].Value.ToString().Trim();
                txtMamonhoc.Text = selectRow.Cells[6].Value.ToString().Trim();
                txtTinchi.Text = selectRow.Cells[7].Value.ToString().Trim();
                txtGiuaky.Text = selectRow.Cells[8].Value.ToString().Trim();
                txtChuyencan.Text = selectRow.Cells[9].Value.ToString().Trim();
                txtCuoiky.Text = selectRow.Cells[10].Value.ToString().Trim();
                txtTrungbinh.Text = selectRow.Cells[11].Value.ToString().Trim();

                txtMasv.Text = selectRow.Cells[0].Value.ToString().Trim();
                id = int.Parse(txtMasv.Text);

            }
            catch
            {

            }
        }
        private int checkEmpty()
        {
            hoVaTen = txtHoten.Text.Trim();
            ngaySinh = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            khoa = txtKhoa.Text;
            Lop = txtLop.Text;
            tenMonHoc = txtTenmonhoc.Text;
            maMonHoc = txtMamonhoc.Text;
            soTinChi = txtTinchi.Text;
            thiGiuaKy = txtGiuaky.Text;
            chuyenCan = txtChuyencan.Text;
            cuoiKi = txtCuoiky.Text;
            trungBinh = txtTrungbinh.Text;

            if(hoVaTen == "" || ngaySinh.ToString() == "" || khoa == "" || Lop == "" || tenMonHoc == "" || maMonHoc == "" || soTinChi == "" || 
                thiGiuaKy == "" || chuyenCan == "" || cuoiKi == "" || trungBinh == "")
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(checkEmpty() == 1 && checkThongTin() == 1)
            {
                SinhVien sv = new SinhVien(hoVaTen, ngaySinh, khoa, Lop, tenMonHoc, maMonHoc, int.Parse(soTinChi),
                    int.Parse(thiGiuaKy), int.Parse(chuyenCan), int.Parse(cuoiKi), float.Parse(trungBinh));
                model.SinhViens.Add(sv);
                model.SaveChanges();
                Form1_Load(sender, e);
                id = -1;
            }
            else
            {
                MessageBox.Show("Thiếu Thông Tin hoặc chưa chính xác");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(id != -1)
            {
                model.SinhViens.Remove(model.SinhViens.Find(id));
                model.SaveChanges();
                Form1_Load(sender, e);
                id = -1;

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(checkEmpty() == 1 && checkThongTin() == 1)
            {
                SinhVien sv = new SinhVien(hoVaTen, ngaySinh, khoa, Lop, tenMonHoc, maMonHoc, int.Parse(soTinChi),
                    int.Parse(thiGiuaKy), int.Parse(chuyenCan), int.Parse(cuoiKi), float.Parse(trungBinh));
                model.SinhViens.Remove(model.SinhViens.Find(id));
                model.SinhViens.Add(sv);
                model.SaveChanges();
                Form1_Load(sender, e);
                id = -1;
            }
            else
            {
                MessageBox.Show("Thiếu thông tin hoặc chưa chính xác");
            }
        }
        private void ClearTextBox()
        {
            txtMasv.Text = "";
            txtHoten.Text = "";
            txtKhoa.Text = "";
            txtLop.Text = "";
            txtTenmonhoc.Text = "";
            txtMamonhoc.Text = "";
            txtTinchi.Text = "";
            txtGiuaky.Text = "";
            txtChuyencan.Text = "";
            txtCuoiky.Text = "";
            txtTrungbinh.Text = "";
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            id = -1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string comboBox = comboBox1.Text;
            string textSearch = txtSearch.Text.Trim();
            List<SinhVien> sinhViens = null;
            switch (comboBox)
            {
                case "Mã Sinh Viên":
                    sinhViens = model.SinhViens.SqlQuery("select * from SinhVien where MaSV like '%" + textSearch + "%' ").ToList();
                    
                    break;
                case "Tên Sinh Viên":
                    sinhViens = model.SinhViens.SqlQuery("select * from SinhVien where HoVaTen like N'%" + textSearch + "%' ").ToList();
                    break;
                case "Khoa":
                    sinhViens = model.SinhViens.SqlQuery("select * from SinhVien where Khoa like N'%" + textSearch + "%' ").ToList();
                    break;
                case "Lớp":
                    sinhViens = model.SinhViens.SqlQuery("select * from SinhVien where Lop like N'%" + textSearch + "%' ").ToList();
                    break;
            }
            dtSinhVien.DataSource = sinhViens;
        }
        private int checkThongTin()
        {
            if(int.Parse(soTinChi) == 0 || int.Parse(thiGiuaKy) > 10 || int.Parse(chuyenCan) > 10 || int.Parse(cuoiKi) > 10 || int.Parse(trungBinh) > 10)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        private void txtGiuaky_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                
            {
                e.Handled = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }
    }
}
