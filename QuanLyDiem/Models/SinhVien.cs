namespace QuanLyDiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        public int MaSV { get; set; }

        [StringLength(250)]
        public string HoVaTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(250)]
        public string Khoa { get; set; }

        [StringLength(250)]
        public string Lop { get; set; }

        [StringLength(250)]
        public string TenMonHoc { get; set; }

        [StringLength(250)]
        public string MaMonHoc { get; set; }

        public int? SoTinChi { get; set; }

        public int? ThiGiuaKi { get; set; }

        public int? ChuyenCan { get; set; }

        public int? ThiCuoiKi { get; set; }

        public float? TrungBinh { get; set; }

        public SinhVien(string hoVaTen, DateTime? ngaySinh, string khoa, string lop, string tenMonHoc, string maMonHoc, int? soTinChi, int? thiGiuaKi, int? chuyenCan, int? thiCuoiKi, float? trungBinh)
        {
            HoVaTen = hoVaTen;
            NgaySinh = ngaySinh;
            Khoa = khoa;
            Lop = lop;
            TenMonHoc = tenMonHoc;
            MaMonHoc = maMonHoc;
            SoTinChi = soTinChi;
            ThiGiuaKi = thiGiuaKi;
            ChuyenCan = chuyenCan;
            ThiCuoiKi = thiCuoiKi;
            TrungBinh = trungBinh;
        }

        public SinhVien()
        {
        }
    }
}
