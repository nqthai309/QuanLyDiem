namespace QuanLyDiem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTenmonhoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMamonhoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTinchi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaForm = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiuaky = new System.Windows.Forms.TextBox();
            this.txtChuyencan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCuoiky = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTrungbinh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtSinhVien = new System.Windows.Forms.DataGridView();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTinChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thiGiuaKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenCanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thiCuoiKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trungBinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(375, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHoten
            // 
            this.txtHoten.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHoten.Location = new System.Drawing.Point(111, 66);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(149, 20);
            this.txtHoten.TabIndex = 1;
            // 
            // txtMasv
            // 
            this.txtMasv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMasv.Location = new System.Drawing.Point(322, 66);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.ReadOnly = true;
            this.txtMasv.Size = new System.Drawing.Size(66, 20);
            this.txtMasv.TabIndex = 1;
            // 
            // txtKhoa
            // 
            this.txtKhoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtKhoa.Location = new System.Drawing.Point(111, 137);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(149, 20);
            this.txtKhoa.TabIndex = 1;
            // 
            // txtLop
            // 
            this.txtLop.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLop.Location = new System.Drawing.Point(111, 173);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(149, 20);
            this.txtLop.TabIndex = 1;
            // 
            // txtTenmonhoc
            // 
            this.txtTenmonhoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTenmonhoc.Location = new System.Drawing.Point(111, 206);
            this.txtTenmonhoc.Name = "txtTenmonhoc";
            this.txtTenmonhoc.Size = new System.Drawing.Size(149, 20);
            this.txtTenmonhoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(283, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Msv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(13, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lớp";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên môn học";
            // 
            // txtMamonhoc
            // 
            this.txtMamonhoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMamonhoc.Location = new System.Drawing.Point(111, 241);
            this.txtMamonhoc.Name = "txtMamonhoc";
            this.txtMamonhoc.Size = new System.Drawing.Size(149, 20);
            this.txtMamonhoc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(13, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã môn học";
            // 
            // txtTinchi
            // 
            this.txtTinchi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTinchi.Location = new System.Drawing.Point(111, 276);
            this.txtTinchi.MaxLength = 1;
            this.txtTinchi.Name = "txtTinchi";
            this.txtTinchi.Size = new System.Drawing.Size(149, 20);
            this.txtTinchi.TabIndex = 1;
            this.txtTinchi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiuaky_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(12, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số tín chỉ";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(278, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 51);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(277, 243);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 53);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "CẬP NHẬT";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(278, 320);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 51);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaForm
            // 
            this.btnXoaForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaForm.Location = new System.Drawing.Point(278, 390);
            this.btnXoaForm.Name = "btnXoaForm";
            this.btnXoaForm.Size = new System.Drawing.Size(111, 55);
            this.btnXoaForm.TabIndex = 6;
            this.btnXoaForm.Text = "XÓA FORM";
            this.btnXoaForm.UseVisualStyleBackColor = false;
            this.btnXoaForm.Click += new System.EventHandler(this.btnXoaForm_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Location = new System.Drawing.Point(395, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "TÌM KIẾM";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearch.Location = new System.Drawing.Point(483, 435);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(391, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã Sinh Viên",
            "Tên Sinh Viên",
            "Khoa",
            "Lớp"});
            this.comboBox1.Location = new System.Drawing.Point(890, 434);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(13, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Thi giữa kì";
            // 
            // txtGiuaky
            // 
            this.txtGiuaky.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGiuaky.Location = new System.Drawing.Point(111, 311);
            this.txtGiuaky.MaxLength = 2;
            this.txtGiuaky.Name = "txtGiuaky";
            this.txtGiuaky.Size = new System.Drawing.Size(149, 20);
            this.txtGiuaky.TabIndex = 1;
            this.txtGiuaky.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiuaky_KeyPress);
            // 
            // txtChuyencan
            // 
            this.txtChuyencan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtChuyencan.Location = new System.Drawing.Point(111, 351);
            this.txtChuyencan.MaxLength = 2;
            this.txtChuyencan.Name = "txtChuyencan";
            this.txtChuyencan.Size = new System.Drawing.Size(149, 20);
            this.txtChuyencan.TabIndex = 1;
            this.txtChuyencan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiuaky_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(13, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Chuyên cần";
            // 
            // txtCuoiky
            // 
            this.txtCuoiky.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCuoiky.Location = new System.Drawing.Point(111, 390);
            this.txtCuoiky.MaxLength = 2;
            this.txtCuoiky.Name = "txtCuoiky";
            this.txtCuoiky.Size = new System.Drawing.Size(149, 20);
            this.txtCuoiky.TabIndex = 1;
            this.txtCuoiky.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiuaky_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(13, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Thi cuối kì";
            // 
            // txtTrungbinh
            // 
            this.txtTrungbinh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTrungbinh.Location = new System.Drawing.Point(111, 425);
            this.txtTrungbinh.MaxLength = 2;
            this.txtTrungbinh.Name = "txtTrungbinh";
            this.txtTrungbinh.Size = new System.Drawing.Size(149, 20);
            this.txtTrungbinh.TabIndex = 1;
            this.txtTrungbinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiuaky_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(13, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Trung bình";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(13, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 105);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 2, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 2, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtSinhVien
            // 
            this.dtSinhVien.AllowUserToAddRows = false;
            this.dtSinhVien.AllowUserToDeleteRows = false;
            this.dtSinhVien.AutoGenerateColumns = false;
            this.dtSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.hoVaTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.khoaDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.tenMonHocDataGridViewTextBoxColumn,
            this.maMonHocDataGridViewTextBoxColumn,
            this.soTinChiDataGridViewTextBoxColumn,
            this.thiGiuaKiDataGridViewTextBoxColumn,
            this.chuyenCanDataGridViewTextBoxColumn,
            this.thiCuoiKiDataGridViewTextBoxColumn,
            this.trungBinhDataGridViewTextBoxColumn});
            this.dtSinhVien.DataSource = this.sinhVienBindingSource;
            this.dtSinhVien.Location = new System.Drawing.Point(394, 66);
            this.dtSinhVien.Name = "dtSinhVien";
            this.dtSinhVien.ReadOnly = true;
            this.dtSinhVien.Size = new System.Drawing.Size(825, 362);
            this.dtSinhVien.TabIndex = 12;
            this.dtSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSinhVien_CellClick);
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoVaTenDataGridViewTextBoxColumn
            // 
            this.hoVaTenDataGridViewTextBoxColumn.DataPropertyName = "HoVaTen";
            this.hoVaTenDataGridViewTextBoxColumn.HeaderText = "HoVaTen";
            this.hoVaTenDataGridViewTextBoxColumn.Name = "hoVaTenDataGridViewTextBoxColumn";
            this.hoVaTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // khoaDataGridViewTextBoxColumn
            // 
            this.khoaDataGridViewTextBoxColumn.DataPropertyName = "Khoa";
            this.khoaDataGridViewTextBoxColumn.HeaderText = "Khoa";
            this.khoaDataGridViewTextBoxColumn.Name = "khoaDataGridViewTextBoxColumn";
            this.khoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "Lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "Lop";
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            this.lopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenMonHocDataGridViewTextBoxColumn
            // 
            this.tenMonHocDataGridViewTextBoxColumn.DataPropertyName = "TenMonHoc";
            this.tenMonHocDataGridViewTextBoxColumn.HeaderText = "TenMonHoc";
            this.tenMonHocDataGridViewTextBoxColumn.Name = "tenMonHocDataGridViewTextBoxColumn";
            this.tenMonHocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maMonHocDataGridViewTextBoxColumn
            // 
            this.maMonHocDataGridViewTextBoxColumn.DataPropertyName = "MaMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.HeaderText = "MaMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.Name = "maMonHocDataGridViewTextBoxColumn";
            this.maMonHocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soTinChiDataGridViewTextBoxColumn
            // 
            this.soTinChiDataGridViewTextBoxColumn.DataPropertyName = "SoTinChi";
            this.soTinChiDataGridViewTextBoxColumn.HeaderText = "SoTinChi";
            this.soTinChiDataGridViewTextBoxColumn.Name = "soTinChiDataGridViewTextBoxColumn";
            this.soTinChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thiGiuaKiDataGridViewTextBoxColumn
            // 
            this.thiGiuaKiDataGridViewTextBoxColumn.DataPropertyName = "ThiGiuaKi";
            this.thiGiuaKiDataGridViewTextBoxColumn.HeaderText = "ThiGiuaKi";
            this.thiGiuaKiDataGridViewTextBoxColumn.Name = "thiGiuaKiDataGridViewTextBoxColumn";
            this.thiGiuaKiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chuyenCanDataGridViewTextBoxColumn
            // 
            this.chuyenCanDataGridViewTextBoxColumn.DataPropertyName = "ChuyenCan";
            this.chuyenCanDataGridViewTextBoxColumn.HeaderText = "ChuyenCan";
            this.chuyenCanDataGridViewTextBoxColumn.Name = "chuyenCanDataGridViewTextBoxColumn";
            this.chuyenCanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thiCuoiKiDataGridViewTextBoxColumn
            // 
            this.thiCuoiKiDataGridViewTextBoxColumn.DataPropertyName = "ThiCuoiKi";
            this.thiCuoiKiDataGridViewTextBoxColumn.HeaderText = "ThiCuoiKi";
            this.thiCuoiKiDataGridViewTextBoxColumn.Name = "thiCuoiKiDataGridViewTextBoxColumn";
            this.thiCuoiKiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trungBinhDataGridViewTextBoxColumn
            // 
            this.trungBinhDataGridViewTextBoxColumn.DataPropertyName = "TrungBinh";
            this.trungBinhDataGridViewTextBoxColumn.HeaderText = "TrungBinh";
            this.trungBinhDataGridViewTextBoxColumn.Name = "trungBinhDataGridViewTextBoxColumn";
            this.trungBinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(QuanLyDiem.Models.SinhVien);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1104, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 46);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 483);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dtSinhVien);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnXoaForm);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTrungbinh);
            this.Controls.Add(this.txtCuoiky);
            this.Controls.Add(this.txtChuyencan);
            this.Controls.Add(this.txtGiuaky);
            this.Controls.Add(this.txtTinchi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMamonhoc);
            this.Controls.Add(this.txtTenmonhoc);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTenmonhoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMamonhoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTinchi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaForm;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGiuaky;
        private System.Windows.Forms.TextBox txtChuyencan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCuoiky;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTrungbinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dtSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTinChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thiGiuaKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyenCanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thiCuoiKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trungBinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.Button btnLogout;
    }
}

